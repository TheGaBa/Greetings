using Greetings.Models;
using Greetings.Services;
using Greetings.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml.Media.Imaging;

namespace Greetings.ViewModels
{
    public class MainViewModel : ObservableObject
    {

        public ObservableCollection<VoucherModel> Newest = new ObservableCollection<VoucherModel>()
        {
            new VoucherModel()
            {
                Name = "South Lake",
                Price = "300$",
                Stars = "4.4",
                Location = "South City",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/losangeles.jpg"))
            },
            new VoucherModel()
            {
                Name = "South Lake",
                Price = "300$",
                Stars = "4.4",
                Location = "South City",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/Tokio.jpg"))
            },
            new VoucherModel()
            {
                Name = "South Lake",
                Price = "300$",
                Stars = "4.4",
                Location = "South City",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/lapland.jpg"))
            }
        };
        public ObservableCollection<VoucherModel> Popular = new ObservableCollection<VoucherModel>();
        public ObservableCollection<VoucherModel> Recommendations = new ObservableCollection<VoucherModel>();
        public ObservableCollection<VoucherModel> BestPrices = new ObservableCollection<VoucherModel>();
        public ObservableCollection<VoucherModel> Favourites = new ObservableCollection<VoucherModel>();

        public MainViewModel()
        {
            ExitCommand = new RelayCommand(Exit);
            ShowInfoCommand = new RelayCommand(ShowInfo);
            ShowHelpCommand = new RelayCommand(ShowHelp);
            ShowFavouritesCommand = new RelayCommand(ShowFavourites);
        }

        
        public ICommand ShowInfoCommand { get; }
        public ICommand ShowHelpCommand { get; }
        public ICommand ShowFavouritesCommand { get; set; }
        public ICommand ExitCommand { get; }

        private void Exit() => NavigationService.Navigate(typeof(LoginPage));
        private void ShowInfo() => NavigationService.Navigate(typeof(InfoPage));
        private void ShowHelp() => NavigationService.Navigate(typeof(HelpPage));
        private void ShowFavourites() => NavigationService.Navigate(typeof(FavouritesPage), Favourites);
    }
}