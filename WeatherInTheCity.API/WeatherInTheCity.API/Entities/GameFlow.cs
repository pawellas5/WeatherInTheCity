using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WeatherInTheCity.API.Entities
{
    public class GameFlow
    {
  
        public Guid Id { get; set; }
        [Required]
        public string Question { get; set; } = string.Empty;
        public DateTime? LastUpdate { get; set; }
    }

   
}
