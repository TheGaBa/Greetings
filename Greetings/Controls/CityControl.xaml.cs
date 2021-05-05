using Greetings.Helpers;
using Greetings.Models;
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
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<VoucherModel>), typeof(CityControl), new PropertyMetadata(null));

        public ObservableCollection<VoucherModel> ItemsSource
        {
            get => (ObservableCollection<VoucherModel>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

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
    }
}