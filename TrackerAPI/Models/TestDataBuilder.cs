using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerAPI.Models
{
    public static class TestDataBuilder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Leonal", Email = "Test@email.com", Password = "Password"}
                );

            modelBuilder.Entity<Track>().HasData(
               new Track { Id = 1, Name = "Track1", UserId = 1 }
               );

            modelBuilder.Entity<Location>().HasData(
               new Location { Id = 1, CreatedDate = new DateTime() }
               );

            modelBuilder.Entity<Coordinate>().HasData(
               new Coordinate { Id = 1, Latitude = 1000, Accuracy = 1000, Altitude = 1000, Heading = 1000, Longitude = 1000, Speed = 100 }
               );
        }
    }
}
