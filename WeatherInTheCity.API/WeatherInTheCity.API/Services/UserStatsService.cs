using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Entities;
using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public class UserStatsService : IUserStatsService
    {
        private readonly WeatherInTheCityDbContext _context;
        public UserStatsService(WeatherInTheCityDbContext context)
        {
            _context = context;
        }

        public async Task AddOrUpdate(UserStatsDTO userStatsDTO, string userId)
        {
            UserStats userStats = new UserStats() { UserId = userId, Defeats = userStatsDTO.Defeats, Wins = userStatsDTO.Wins, Games = userStatsDTO.Games };
            FormattableString myCommand = $"MERGE INTO dbo.UserStats AS Target USING (VALUES ({userStats.UserId})) AS Source (UserId) ON Target.UserId = Source.UserId WHEN MATCHED THEN UPDATE SET Defeats = {userStats.Defeats}, Wins = {userStats.Wins}, Games = {userStats.Games} WHEN NOT MATCHED THEN INSERT(UserId,Wins,Defeats,Games) VALUES ({userStats.UserId},{userStats.Wins},{userStats.Defeats},{userStats.Games});";
            Console.WriteLine($"myCommand: {myCommand}");
            await _context.Database.ExecuteSqlInterpolatedAsync(myCommand);


        }




    }
}
