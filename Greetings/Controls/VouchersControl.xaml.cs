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
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<VoucherModel>), typeof(VouchersControl), new PropertyMetadata(null));

        public ObservableCollection<VoucherModel> ItemsSource
        {
            get => (ObservableCollection<VoucherModel>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public VouchersControl()
        {
            this.InitializeComponent();
        }

        private async void AnimatedVisualPlayer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {   
            myGridView.SelectedItem = ((sender as AnimatedVisualPlayer).Parent as Grid);
            AnimatedVisualPlayer player = sender as AnimatedVisualPlayer;

            if (player.IsPlaying)
            {
                player.PlaybackRate = -3.5;
            }

            await player.PlayAsync(0, 1, false);
        }
    }
}