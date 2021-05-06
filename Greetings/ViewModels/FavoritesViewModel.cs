using Database;
using Greetings.Helpers;
using Greetings.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;

namespace Greetings.ViewModels
{
    public class FavoritesViewModel
    {
        public ObservableCollection<CityModel> Favourites = new ObservableCollection<CityModel>();

        internal async void Initialize()
        {
            using (MyDBContext context = new MyDBContext())
            {
                foreach (var city in await context.Cities.Where(city => city.Like).ToListAsync())
                {
                    var card = new CityModel()
                    {
                        ID = city.CityId,
                        ImageSource = await ImageConverter.GetBitmapAsync(city.Image),
                        Name = city.CityName,
                        CountOfPlaces = "Count of attractions: " + Repository.GetPlacesCount(city.CityId).ToString(),
                        Rating = city.Rating,
                        Like = city.Like
                    };

                    Favourites.Add(card);
                }
            }
        }
    }
}