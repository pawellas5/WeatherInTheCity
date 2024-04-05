using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public interface IUserStatsService
    {
        public Task AddOrUpdate(string gameFlowId, string userId);
        public Task<UserStatsDTO> GetByUserId(string userId);

    }
}
