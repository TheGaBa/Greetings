using System.Linq;

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
    }
}