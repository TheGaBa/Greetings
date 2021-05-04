using System.Linq;

namespace Database
{
    public static class Repository
    {
        public static string GetCityName(int cityId)
        {
            string cityName = string.Empty;

            using (MyDBContext context = new MyDBContext())
            {
                cityName = context.Cities.FirstOrDefault(city => city.CityId == cityId)?.CityName;
            }

            return cityName ?? "Unknown";
        }
    }
}