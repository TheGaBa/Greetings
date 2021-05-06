using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
    }
}