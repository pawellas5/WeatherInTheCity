using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using WeatherInTheCity.API.Models;
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
        public async Task<IActionResult> AddOrUpdate(UserStatsDTO userStatsDTO)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity == null) return Unauthorized();

            var userId = identity.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            await _userStatsService.AddOrUpdate(userStatsDTO, userId!);

            return NoContent();
        }

        [HttpGet]
        [Authorize]
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
