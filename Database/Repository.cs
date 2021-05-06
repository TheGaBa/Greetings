using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Database
{
    public static class Repository
    {
        public static int GetPlacesCount(int cityId)
        {
            int countOfPlaces = 0;

            using (MyDBContext context = new MyDBContext())
            {
                countOfPlaces = context.Places.Count(place => place.CityId == cityId);
            }

            return countOfPlaces;
        }

        public static async Task<List<byte[]>> GetImagesDataAsync(int placeId)
        {
            using (MyDBContext context = new MyDBContext())
            {
                return await context.ImageStorage.Where(item => item.PlaceID == placeId).Select(column => column.Image).ToListAsync();
            }
        }

        public static async void SetFavourite(int id, bool like)
        {
            using (MyDBContext context = new MyDBContext())
            {
                var city = await context.Cities.FindAsync(id);
                city.Like = like;

                await context.SaveChangesAsync();
            }
        }

        public static async Task<List<City>> FindOverlaps(string searchText)
        {
            List<City> cities;

            using (MyDBContext context = new MyDBContext())
            {
                cities = await context.Cities.Where(city => city.CityName.ToLower().Contains(searchText.ToLower())).ToListAsync();
            }

            return cities;
        }

        public static async Task<List<City>> GetCities()
        {
            List<City> cities;
            using (MyDBContext context = new MyDBContext())
            {
                cities = await context.Cities.ToListAsync();
            }

            return cities;
        }
    }
}