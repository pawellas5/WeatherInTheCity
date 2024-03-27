using WeatherInTheCity.API.Entities;
using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public interface IUserStatsService
    {
        public Task AddOrUpdate(UserStatsDTO userStatsDTO, string userId);
        public Task<UserStatsDTO> GetByUserId(string userId);

    }
}
