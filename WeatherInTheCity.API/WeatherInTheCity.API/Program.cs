using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;
using Serilog;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Services;
using System.Threading.RateLimiting;
using System.Net;
using System.Globalization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

var retryPolicy = HttpPolicyExtensions
    .HandleTransientHttpError()
    .Or<TimeoutRejectedException>()
    .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

var circuitBreakerPolicy = HttpPolicyExtensions
    .HandleTransientHttpError()
    .CircuitBreakerAsync(4, TimeSpan.FromSeconds(30));

var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(5);

// Add services to the container.
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File(
        path: "./Logs/.txt",
        rollingInterval: RollingInterval.Day)
    .CreateLogger();
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Logging.AddSerilog(Log.Logger);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
        c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "WeatherInTheCity.API", Version = "v1.0.0" });


            var securitySchema = new OpenApiSecurityScheme
            {
                Description = "Using the Authorization header with the Bearer scheme.",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            };

            c.AddSecurityDefinition("Bearer", securitySchema);

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
          {
              { securitySchema, new[] { "Bearer" } }
          });

        }

    );
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<IUserStatsService, UserStatsService>();
builder.Services.AddScoped<IGameFlowService, GameFlowService>();

builder.Services.AddHttpClient<IOpenWeatherService, OpenWeatherService>()
    .SetHandlerLifetime(TimeSpan.FromMinutes(3))
    .AddPolicyHandler(retryPolicy)
    .AddPolicyHandler(circuitBreakerPolicy)
    .AddPolicyHandler(timeoutPolicy);

builder.Services.AddDbContext<WeatherInTheCityDbContext>(o =>
   o.UseNpgsql(builder.Configuration["ConnectionStrings:WeatherInTheCityDB"]));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyMethod()
                                 .AllowAnyHeader()
                                 .WithOrigins("http://localhost:8080");
                      });
});


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}/";
    options.TokenValidationParameters =
      new Microsoft.IdentityModel.Tokens.TokenValidationParameters
      {
          ValidAudience = builder.Configuration["Auth0:Audience"],
          ValidIssuer = $"{builder.Configuration["Auth0:Domain"]}",
          ValidateLifetime = true,
      };
});

builder.Services.AddRateLimiter(_ =>
{
    _.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    _.OnRejected = (context, cancellationToken) =>
    {
        if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
        {
            context.HttpContext.Response.Headers.RetryAfter =
                ((int)retryAfter.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
        }

        context.HttpContext.RequestServices.GetService<ILoggerFactory>()?
            .CreateLogger("Microsoft.AspNetCore.RateLimitingMiddleware")
            .LogWarning("OnRejected: RemoteIpAddress: {}", context.HttpContext.Connection.RemoteIpAddress);

        context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;


        return new ValueTask();
    };

    _.GlobalLimiter = PartitionedRateLimiter.CreateChained(
        PartitionedRateLimiter.Create<HttpContext, IPAddress>(httpContext =>
        {

            IPAddress? remoteIpAddress = httpContext.Connection.RemoteIpAddress;

            if (!IPAddress.IsLoopback(remoteIpAddress!))
            {

                return RateLimitPartition.GetFixedWindowLimiter
        (remoteIpAddress!, _ =>
            new FixedWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 10,
                Window = TimeSpan.FromSeconds(17),
                QueueLimit = 1,

            });
            }

            return RateLimitPartition.GetNoLimiter(IPAddress.Loopback);


        }),

        PartitionedRateLimiter.Create<HttpContext, IPAddress>(httpContext =>
        {
            IPAddress? remoteIpAddress = httpContext.Connection.RemoteIpAddress;
            if (!IPAddress.IsLoopback(remoteIpAddress!))
            {

                return RateLimitPartition.GetFixedWindowLimiter
            (remoteIpAddress!, _ =>
                new FixedWindowRateLimiterOptions
                {
                    AutoReplenishment = true,
                    PermitLimit = 250,
                    Window = TimeSpan.FromDays(1),
                    QueueLimit = 1,

                });
            }
            return RateLimitPartition.GetNoLimiter(IPAddress.Loopback);

        }));
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


if (app.Environment.IsDevelopment())
    app.UseCors(MyAllowSpecificOrigins);

app.UseRateLimiter();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
