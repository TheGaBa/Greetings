using Greetings.Models;
using Microsoft.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Greetings.Controls
{
    public sealed partial class VouchersControl : UserControl
    {

        public VouchersControl()
        {
            this.InitializeComponent();

            myGridView.Items.Add(new VoucherModel()
            {
                Name = "South Lake",
                Price = 300,
                Stars = 4.4,
                Location = "South City",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/losangeles.jpg"))
            });
            myGridView.Items.Add(new VoucherModel()
            {
                Name = "South Lake",
                Price = 300,
                Stars = 4.4,
                Location = "South City",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/Tokio.jpg"))
            });
            myGridView.Items.Add(new VoucherModel()
            {
                Name = "South Lake",
                Price = 300,
                Stars = 4.4,
                Location = "South City",
                ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Titles/lapland.jpg"))
            });

        }

        private async void AnimatedVisualPlayer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            AnimatedVisualPlayer player = sender as AnimatedVisualPlayer;

            if (player.IsPlaying)
            {
                player.PlaybackRate = -3.5;

                //await player.PlayAsync(0, 0.8, false);

                //player.PlaybackRate = 2;
                //await player.PlayAsync(0, 1, false);

            }

            await player.PlayAsync(0, 1, false);
        }
    }
}