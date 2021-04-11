using Greetings.Models;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Greetings
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static ObservableCollection<VoucherModel> Newest = new ObservableCollection<VoucherModel>()
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
        public static ObservableCollection<VoucherModel> Popular = new ObservableCollection<VoucherModel>();
        public static ObservableCollection<VoucherModel> Recommendations = new ObservableCollection<VoucherModel>();
        public static ObservableCollection<VoucherModel> BestPrices = new ObservableCollection<VoucherModel>();

        public MainPage()
        {
            this.InitializeComponent();
            
            newItems.Cards = Newest;
            popularItems.Cards = Popular;
            recommendationsItems.Cards = Recommendations;
            bestPriceItems.Cards = BestPrices;
        }

        private void element_PointerEnteredHome(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationHome.Begin();
        }

        private void element_PointerEnteredLocation(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationLocation.Begin();
        }

        private void element_PointerEnteredFavorite(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationFavorite.Begin();
        }

        private void element_PointerEnteredInfo(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationInfo.Begin();
        }

        private void element_PointerEnteredExit(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationExit.Begin();
        }

        private void element_PointerEnteredHelp(object sender, PointerRoutedEventArgs e)
        {
            PointerEnterAnimationHelp.Begin();
        }
    }
}