using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrackerAPI.Models;

namespace TrackerAPI.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public List<Coordinate> Coordinates { get; set; } = new List<Coordinate>();
    }
}
