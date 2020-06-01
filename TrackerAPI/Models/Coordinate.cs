using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerAPI.Models
{
    public class Coordinate
    {
        public int Id { get; set; }

        [Required]
        public int Latitude { get; set; }

        [Required]
        public int Longitude { get; set; }

        [Required]
        public int Altitude { get; set; }

        [Required]
        public int Accuracy { get; set; }

        [Required]
        public int Heading { get; set; }

        [Required]
        public int Speed { get; set; }
    }
}
