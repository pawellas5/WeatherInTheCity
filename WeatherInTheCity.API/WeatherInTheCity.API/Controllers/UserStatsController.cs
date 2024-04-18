using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using System.Security.Claims;
using WeatherInTheCity.API.Services;

namespace WeatherInTheCity.API.Controllers
{
    [ApiController]
    [Route("user/stats")]
    public class UserStatsController : ControllerBase
    {
        private readonly IUserStatsService _userStatsService;
        public UserStatsController(IUserStatsService userStatsService)
        {
            _userStatsService = userStatsService;
        }

        [HttpPut]
        [Authorize]
        [DisableRateLimiting]

        public async Task<IActionResult> AddOrUpdate([FromHeader] string gameFlowId)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) return Unauthorized();

            var userId = identity.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            await _userStatsService.AddOrUpdate(gameFlowId, userId!);

            return NoContent();
        }
        [HttpGet]
        [Authorize]
        [DisableRateLimiting]
        public async Task<IActionResult> Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) return Unauthorized();

            var userId = identity.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            var userStats = await _userStatsService.GetByUserId(userId!);

            if (userStats == null) return NotFound();
            return Ok(userStats);
        }
    }
}
