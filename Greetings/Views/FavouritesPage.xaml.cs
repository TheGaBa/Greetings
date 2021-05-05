using Greetings.Models;
using Greetings.Services;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Input;

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

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            NavigationService.Navigate(typeof(MainPage), (Application.Current as App).MainViewModel);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Favourites = e.Parameter as ObservableCollection<PlaceModel>;
    
            base.OnNavigatedTo(e);
        }
    }
}