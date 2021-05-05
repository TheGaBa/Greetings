using Database;
using Database.Helpers;
using Greetings.Models;
using Greetings.Services;
using Greetings.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Windows.Security.Cryptography.Certificates;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;

namespace Greetings.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<VoucherModel> Cards = new ObservableCollection<VoucherModel>();

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

        public ICommand ShowInfoCommand { get; }
        public ICommand ShowHelpCommand { get; }
        public ICommand ShowFavouritesCommand { get; set; }
        public ICommand ExitCommand { get; }
        public ICommand LoadedCommand { get; }

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

        internal void RemoveFromFavourite(VoucherModel selected)
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
                    var card = new VoucherModel();

                    card.ImageSource = await ImageConverter.GetBitmapAsync(city.Image);
                    card.Name = city.CityName;
                    card.Location = "Count of attractions: " + Repository.GetPlacesCount(city.CityId).ToString();
                    card.Stars = city.Rating;

                    Cards.Add(card);
                }
            }
        }

        private void Exit() => NavigationService.Navigate(typeof(LoginPage));
        private void ShowInfo() => NavigationService.Navigate(typeof(InfoPage));
        private void ShowHelp() => NavigationService.Navigate(typeof(HelpPage));
        private void ShowFavourites() => NavigationService.Navigate(typeof(FavouritesPage));
    }
}