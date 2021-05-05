using Database;
using Database.Helpers;
using Greetings.Models;
using Greetings.Services;
using Greetings.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace Greetings.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<CityModel> Cities = new ObservableCollection<CityModel>();

        public MainViewModel()
        {
            ExitCommand = new RelayCommand(Exit);
            ShowInfoCommand = new RelayCommand(ShowInfo);
            ShowHelpCommand = new RelayCommand(ShowHelp);
            ShowFavouritesCommand = new RelayCommand(ShowFavourites);
            LoadedCommand = new RelayCommand(Loaded);

            if ((Application.Current as App).MainViewModel == null)
            {
                (Application.Current as App).MainViewModel = this;
            }
        }

        internal ICommand ShowInfoCommand { get; }
        internal ICommand ShowHelpCommand { get; }
        internal ICommand ShowFavouritesCommand { get; }
        internal ICommand ExitCommand { get; }
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

        private void Exit() => NavigationService.Navigate(typeof(LoginPage));
        private void ShowInfo() => NavigationService.Navigate(typeof(InfoPage));
        private void ShowHelp() => NavigationService.Navigate(typeof(HelpPage));
        private void ShowFavourites() => NavigationService.Navigate(typeof(FavouritesPage));
    }
}