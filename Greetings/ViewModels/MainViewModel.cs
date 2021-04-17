using Greetings.Models;
using Greetings.Services;
using Greetings.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;

namespace Greetings.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<VoucherModel> Newest = new ObservableCollection<VoucherModel>()
        {
            new VoucherModel()
            {
                Name = "NewYork",
                Price = "300$",
                Stars = "4.4",
                Location = "losangeles",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/losangeles.jpg"))
            },
            new VoucherModel()
            {
                Name = "Tokyo",
                Price = "390$",
                Stars = "4.1",
                Location = "Tokyo",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/Tokio.jpg"))
            },
            new VoucherModel()
            {
                Name = "Lapland",
                Price = "360$",
                Stars = "4.7",
                Location = "Tornio",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/lapland.jpg"))
            }
        };
        public ObservableCollection<VoucherModel> Popular = new ObservableCollection<VoucherModel>()
        {
            new VoucherModel()
            {
                Name = "GreenLand",
                Price = "240$",
                Stars = "4.7",
                Location = "Nuk",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/greenland.png"))
            },
            new VoucherModel()
            {
                Name = "Japan",
                Price = "460$",
                Stars = "4.3",
                Location = "Kioto",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/japan.jpg"))
            },
            new VoucherModel()
            {
                Name = "Russia",
                Price = "210$",
                Stars = "4.8",
                Location = "Gelendzhik",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/Russia.png"))
            }
        };
        public ObservableCollection<VoucherModel> Recommendations = new ObservableCollection<VoucherModel>()
        {
            new VoucherModel()
            {
                Name = "India",
                Price = "340$",
                Stars = "4.5",
                Location = "Sri Lanka",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/India.jpg"))
            },
            new VoucherModel()
            {
                Name = "United States",
                Price = "420$",
                Stars = "4.5",
                Location = "NewYork",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/NewYork.png"))
            },
            new VoucherModel()
            {
            Name = "New Zeland",
                Price = "250$",
                Stars = "4.8",
                Location = "Nelson",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/NewZeland.png"))
            }
        };
        public ObservableCollection<VoucherModel> BestPrices = new ObservableCollection<VoucherModel>()
{
            new VoucherModel()
            {
                Name = "Norway",
                Price = "200$",
                Stars = "4.2",
                Location = "Oslo",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/norvegia.jpg"))
            },
            new VoucherModel()
            {
                Name = "Russian Federation",
                Price = "190$",
                Stars = "4.4",
                Location = "Yakutia",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/Russia1.png"))
            },
            new VoucherModel()
            {
                Name = "USA",
                Price = "220$",
                Stars = "4.1",
                Location = "NewYork",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/NewYork.png"))
            }
        };
        public ObservableCollection<VoucherModel> Favourites = new ObservableCollection<VoucherModel>();

        public MainViewModel()
        {
            ExitCommand = new RelayCommand(Exit);
            ShowInfoCommand = new RelayCommand(ShowInfo);
            ShowHelpCommand = new RelayCommand(ShowHelp);
            ShowFavouritesCommand = new RelayCommand(ShowFavourites);

            if ((Application.Current as App).MainViewModel == null)
            {
                (Application.Current as App).MainViewModel = this;
            }
        }

        public ICommand ShowInfoCommand { get; }
        public ICommand ShowHelpCommand { get; }
        public ICommand ShowFavouritesCommand { get; set; }
        public ICommand ExitCommand { get; }

        internal void AddToFavourite(string nameOfTour)
        {
            VoucherModel selected = Popular.FirstOrDefault(item => item.Name == nameOfTour);
            if (selected == null)
            {
                selected = Recommendations.FirstOrDefault(item => item.Name == nameOfTour);
            }
            if (selected == null)
            {
                selected = BestPrices.FirstOrDefault(item => item.Name == nameOfTour);
            }
            if (selected == null)
            {
                selected = Newest.FirstOrDefault(item => item.Name == nameOfTour);
            }
            if (Favourites.Contains(selected)) return;

            Favourites.Add(selected);
        }

        internal void RemoveFromFavourite(VoucherModel selected)
        {
            if (Favourites.Contains(selected))
            {
                Favourites.Remove(selected);
            }
        }

        private void Exit() => NavigationService.Navigate(typeof(LoginPage));
        private void ShowInfo() => NavigationService.Navigate(typeof(InfoPage));
        private void ShowHelp() => NavigationService.Navigate(typeof(HelpPage));
        private void ShowFavourites() => NavigationService.Navigate(typeof(FavouritesPage), Favourites);
    }
}