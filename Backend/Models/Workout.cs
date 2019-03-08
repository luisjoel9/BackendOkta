using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Workout
    {
        public int Id { get; set; }
        [Required]
        public DateTimeOffset Date { get; set; }
        public int DistanceInMeters { get; set; }
        [Required]
        public long TimeInSeconds { get; set; }
    }
}
