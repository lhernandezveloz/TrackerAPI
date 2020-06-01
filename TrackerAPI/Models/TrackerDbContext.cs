using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerAPI.Models
{
    public class TrackerDbContext : DbContext
    {
        public TrackerDbContext(DbContextOptions<TrackerDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(c => c.Tracks);
            modelBuilder.Entity<Track>().HasMany(c => c.Locations);
            modelBuilder.Entity<Location>().HasMany(c => c.Coordinates);
            modelBuilder.Entity<Coordinate>();

            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Coordinate> Coordinates { get; set; }
    }
}
