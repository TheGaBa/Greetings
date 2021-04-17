using Greetings.Helpers;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Greetings.Models
{
    public class VoucherModel
    {

        public VoucherModel()
        {
            ChangeSelectionCommand = new RelayCommand<AnimatedVisualPlayer>(ChangeSelection);
        }

        internal string Name { get; set; }

        internal string Price { get; set; }

        internal string Stars { get; set; }

        internal bool Like { get; set; } = false;

        internal string Location { get; set; }

        internal ImageSource ImageSource { get; set; }

        internal ICommand ChangeSelectionCommand { get; set; }

        private void ChangeSelection(AnimatedVisualPlayer player)
        {
            var parent = (player.Parent as Control).Parent;
            var textBlock = VisualManager.FindControl<TextBlock>(parent as UIElement, typeof(TextBlock), "tourName");
            string nameOfTour = textBlock.Text;

            if (Like)
            {
                player.SetProgress(0);
                Like = false;
                (Application.Current as App).MainViewModel.RemoveFromFavourite(this);
            }
            else
            {
               _= player.PlayAsync(0, 1, false);
                Like = true;
                (Application.Current as App).MainViewModel.AddToFavourite(nameOfTour);
            }
        }
    }
}