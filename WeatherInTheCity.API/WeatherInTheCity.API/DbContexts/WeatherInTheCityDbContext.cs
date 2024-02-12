using Microsoft.EntityFrameworkCore;
using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.DbContexts
{
    public class WeatherInTheCityDbContext:DbContext
    {
        public WeatherInTheCityDbContext(DbContextOptions<WeatherInTheCityDbContext> options)
            :base(options)
        {
                
        }

        public DbSet<City> Cities { get; set; }
    }
}
