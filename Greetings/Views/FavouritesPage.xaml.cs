using Greetings.Models;
using Greetings.Services;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Greetings.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FavouritesPage : Page
    {       
        public FavouritesPage()
        {
            this.InitializeComponent();
        }

        private void Image_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            NavigationService.Navigate(typeof(MainPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Favourites = e.Parameter as ObservableCollection<VoucherModel>;
            base.OnNavigatedTo(e);
        }
    }
}