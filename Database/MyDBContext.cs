using Database.Helpers;
using Database.Models;
using Database.Properties;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Database
{
    public class MyDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=MyDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(
               new City()
               {
                   CityId = 1,
                   CityName = "Los Angeles",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 2,
                   CityName = "Zp",
                   Image = Resources.greenland,
                   Places = new List<Place>()
               }
            );

            modelBuilder.Entity<Place>().HasData(
                new Place() { PlaceId = 1, CityId = 1, PlaceName = "Santa Monica Beach", Street = "None", Cost = 300, Time = 99999 },
                new Place() { PlaceId = 2, CityId = 1, PlaceName = "Hollywood", Street = "None", Cost = 300, Time = 99999 },
                new Place() { PlaceId = 3, CityId = 2, PlaceName = "Baburka", Street = "None", Cost = 300, Time = 0 },
                new Place() { PlaceId = 4, CityId = 2, PlaceName = "Center", Street = "None", Cost = 300, Time = 0 }
            );
        }
    }
}