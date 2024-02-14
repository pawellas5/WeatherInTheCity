using Microsoft.EntityFrameworkCore;
using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;
using Serilog;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Services;

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
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddHttpClient<IOpenWeatherService, OpenWeatherService>()
    .SetHandlerLifetime(TimeSpan.FromMinutes(3))
    .AddPolicyHandler(retryPolicy)
    .AddPolicyHandler(circuitBreakerPolicy)
    .AddPolicyHandler(timeoutPolicy);
builder.Services.AddDbContext<WeatherInTheCityDbContext>(o =>
    o.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                      });
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


app.UseAuthorization();

app.MapControllers();

app.Run();
