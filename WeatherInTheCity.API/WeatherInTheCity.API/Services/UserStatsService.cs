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
            FormattableString myCommand = $"MERGE INTO dbo.UserStats AS Target USING (VALUES ({userId})) AS Source (UserId) ON Target.UserId = Source.UserId WHEN MATCHED THEN UPDATE SET Defeats = Defeats + {userStatsDTO.Defeats}, Wins = Wins + {userStatsDTO.Wins}, Games = Games + {userStatsDTO.Games} WHEN NOT MATCHED THEN INSERT(UserId,Wins,Defeats,Games) VALUES ({userId},{userStatsDTO.Wins},{userStatsDTO.Defeats},{userStatsDTO.Games});";
            Console.WriteLine($"myCommand: {myCommand}");
            await _context.Database.ExecuteSqlInterpolatedAsync(myCommand);


        }




    }
}
