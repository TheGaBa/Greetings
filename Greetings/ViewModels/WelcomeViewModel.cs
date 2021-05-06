using Database;
using Greetings.Helpers;
using Greetings.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Greetings.ViewModels
{
    public class WelcomeViewModel : ObservableObject
    {
        public ObservableCollection<CityModel> Cities = new ObservableCollection<CityModel>();

        public WelcomeViewModel()
        {
            LoadedCommand = new RelayCommand(Loaded);
        }

        internal ICommand LoadedCommand { get; }

        internal void AddToFavourite(string nameOfTour)
        {
            //VoucherModel selected = Popular.FirstOrDefault(item => item.Name == nameOfTour);
            //if (selected == null)
            //{
            //    selected = Recommendations.FirstOrDefault(item => item.Name == nameOfTour);
            //}
            //if (selected == null)
            //{
            //    selected = BestPrices.FirstOrDefault(item => item.Name == nameOfTour);
            //}
            //if (selected == null)
            //{
            //    selected = Newest.FirstOrDefault(item => item.Name == nameOfTour);
            //}
            //if (Favourites.Contains(selected)) return;

            //Favourites.Add(selected);
        }

        internal void RemoveFromFavourite(PlaceModel selected)
        {
            //if (Favourites.Contains(selected))
            //{
            //    Favourites.Remove(selected);
            //}
        }

        private async void Loaded()
        {
            using (MyDBContext context = new MyDBContext())
            {
                foreach (var city in await context.Cities.ToListAsync())
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

                    Cities.Add(card);
                }
            }
        }
    }
}