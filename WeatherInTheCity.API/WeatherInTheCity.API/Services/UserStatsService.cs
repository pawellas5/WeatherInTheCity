﻿using Microsoft.EntityFrameworkCore;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public class UserStatsService : IUserStatsService
    {
        private readonly WeatherInTheCityDbContext _context;
        private readonly IGameFlowService _gameFlowService;
        public UserStatsService(WeatherInTheCityDbContext context, IGameFlowService gameFlowService)
        {
            _context = context;
            _gameFlowService = gameFlowService;
        }

        public async Task AddOrUpdate(string gameFlowId, string userId)
        {

            var percentageResult = await _gameFlowService.GetPercentageResult(gameFlowId);
            if (percentageResult != null)
            {
                if (percentageResult >= 50)
                {
                    FormattableString myCommand = $"MERGE INTO \"UserStats\" as Target using (VALUES({userId})) as Source(\"UserId\") ON \"target\".\"UserId\" = \"source\".\"UserId\" WHEN MATCHED THEN  UPDATE SET \"Wins\" = \"target\".\"Wins\" + 1, \"Games\" = \"target\".\"Games\" + 1 WHEN NOT MATCHED THEN INSERT (\"UserId\", \"Wins\", \"Defeats\", \"Games\") VALUES ({userId}, 1, 0, 1);";
                    await _context.Database.ExecuteSqlInterpolatedAsync(myCommand);
                }
                else
                {
                    FormattableString myCommand = $"MERGE INTO \"UserStats\" as Target using (VALUES({userId})) as Source(\"UserId\") ON \"target\".\"UserId\" = \"source\".\"UserId\" WHEN MATCHED THEN  UPDATE SET \"Defeats\" = \"target\".\"Defeats\" + 1, \"Games\" = \"target\".\"Games\" + 1 WHEN NOT MATCHED THEN INSERT (\"UserId\", \"Wins\", \"Defeats\", \"Games\") VALUES ({userId}, 0, 1, 1);";
                    await _context.Database.ExecuteSqlInterpolatedAsync(myCommand);
                }
            }



        }
        public async Task<UserStatsDTO> GetByUserId(string userId)
        {
            var userStats = await _context.UserStats.FirstOrDefaultAsync(u => u.UserId == userId);
            if (userStats == null) return null!;
            return new UserStatsDTO() { Defeats = userStats.Defeats, Wins = userStats.Wins, Games = userStats.Games };

        }




    }
}
