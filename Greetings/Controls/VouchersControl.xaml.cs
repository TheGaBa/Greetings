using Greetings.Models;
using Greetings.ViewModels;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

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

            var parent = (sender as AnimatedVisualPlayer).Parent;
            var textBlock = FindControl<TextBlock>(parent as UIElement, typeof(TextBlock), "tourName");
            string nameOfTour = textBlock.Text;


            (Application.Current as App).MainViewModel.AddToFavourite(nameOfTour);

            myGridView.SelectedItem = ((sender as AnimatedVisualPlayer).Parent as Grid);
            AnimatedVisualPlayer player = sender as AnimatedVisualPlayer;

            if (player.IsPlaying)
            {
                player.PlaybackRate = -3.5;
            }

            await player.PlayAsync(0, 1, false);
        }

        private static T FindControl<T>(UIElement parent, Type targetType, string ControlName) where T : FrameworkElement
        {

            if (parent == null) return null;

            if (parent.GetType() == targetType && ((T)parent).Name == ControlName)
            {
                return (T)parent;
            }
            T result = null;
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                UIElement child = (UIElement)VisualTreeHelper.GetChild(parent, i);

                if (FindControl<T>(child, targetType, ControlName) != null)
                {
                    result = FindControl<T>(child, targetType, ControlName);
                    break;
                }
            }
            return result;
        }
    }
}