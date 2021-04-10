using Greetings.Models;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Greetings.Controls
{
    public sealed partial class VouchersControl : UserControl
    {

        ObservableCollection<VoucherModel> Cards = new ObservableCollection<VoucherModel>()
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

        public VouchersControl()
        {
            this.InitializeComponent();
        }

        private async void AnimatedVisualPlayer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            AnimatedVisualPlayer player = sender as AnimatedVisualPlayer;

            if (player.IsPlaying)
            {
                player.PlaybackRate = -3.5;
            }

            await player.PlayAsync(0, 1, false);
        }
    }
}