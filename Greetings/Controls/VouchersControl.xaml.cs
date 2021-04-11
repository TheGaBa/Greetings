using Greetings.Models;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Greetings.Controls
{
    public sealed partial class VouchersControl : UserControl
    {

        public ObservableCollection<VoucherModel> Cards
        {
            get => (ObservableCollection<VoucherModel>)GetValue(CardsProperty);
            set => SetValue(CardsProperty, value);
        }

        // Using a DependencyProperty as the backing store for Cards.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardsProperty =
            DependencyProperty.Register("Cards", typeof(ObservableCollection<VoucherModel>), typeof(VouchersControl), new PropertyMetadata(0));


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