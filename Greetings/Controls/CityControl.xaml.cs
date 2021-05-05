using Greetings.Models;
using Greetings.Services;
using Greetings.Views;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Greetings.Controls
{
    public sealed partial class CityControl : UserControl
    {
        //internal static readonly DependencyProperty ItemsSourceProperty =
        //    DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<CityModel>), typeof(CityControl), new PropertyMetadata(null));

        //internal ObservableCollection<CityModel> ItemsSource
        //{
        //    get => (ObservableCollection<CityModel>)GetValue(ItemsSourceProperty);
        //    set => SetValue(ItemsSourceProperty, value);
        //}

        public ObservableCollection<CityModel> ItemSource
        {
            get { return (ObservableCollection<CityModel>)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(ObservableCollection<CityModel>), typeof(CityControl), new PropertyMetadata(0));


        public CityControl()
        {
            this.InitializeComponent();
        }

        private void ToggleButton_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            var player = (sender as ToggleButton).Content as AnimatedVisualPlayer;

            if ((sender as ToggleButton).IsChecked == true)
            {
                player.SetProgress(1);
            }
            else
            {
                player.SetProgress(0);
            }
        }

        private void myGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            int clickedCityId = (e.ClickedItem as CityModel).ID;
            NavigationService.Navigate<PlacesPage>(clickedCityId);
        }
    }
}