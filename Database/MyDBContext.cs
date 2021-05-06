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

        public DbSet<ImageStorage> ImageStorage { get; set; }

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
                   Image = Resources.greenland,
                   Rating = "12/10",
                   Places = new List<Place>()
               },
               new City()
               {
                   CityId = 2,
                   CityName = "Zp",
                   Image = Resources.japan,
                   Rating = "0",
                   Places = new List<Place>()
               }
            );

            modelBuilder.Entity<Place>().HasData(
                new Place() { PlaceId = 1, CityId = 1, PlaceName = "Santa Monica Beach", Address = "None", Cost = 300, Time = 99999, Image = Resources.India, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                new Place() { PlaceId = 2, CityId = 1, PlaceName = "Hollywood", Address = "None", Cost = 300, Time = 99999, Image = Resources.India, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                new Place() { PlaceId = 3, CityId = 2, PlaceName = "Baburka", Address = "None", Cost = 300, Time = 0, Image = Resources.India, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() },
                new Place() { PlaceId = 4, CityId = 2, PlaceName = "Center", Address = "None", Cost = 300, Time = 0, Image = Resources.India, Descriprion = "asda sddd ddddd dddd dd dd dd dddddd dddddd", ImageStorage = new List<ImageStorage>() }
            );

            modelBuilder.Entity<ImageStorage>().HasData(
                new ImageStorage() { ID = 1, Image = Resources.greenland, PlaceID = 1 },
                new ImageStorage() { ID = 2, Image = Resources.greenland, PlaceID = 1 },
                new ImageStorage() { ID = 3, Image = Resources.greenland, PlaceID = 1 },
                new ImageStorage() { ID = 4, Image = Resources.greenland, PlaceID = 1 },
                new ImageStorage() { ID = 5, Image = Resources.greenland, PlaceID = 1 },
                new ImageStorage() { ID = 6, Image = Resources.greenland, PlaceID = 1 }
            );
        }
    }
}