using Greetings.Helpers;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Greetings.Models
{
    public class CityModel
    {
        public CityModel()
        {
            FavouriteChangedCommand = new RelayCommand<AnimatedVisualPlayer>(ChangeFavouriteState);
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public bool Like { get; set; } = false;

        public string Rating { get; set; }

        public string CountOfPlaces { get; set; }

        public ImageSource ImageSource { get; set; }

        public ICommand FavouriteChangedCommand { get; set; }

        private void ChangeFavouriteState(AnimatedVisualPlayer player)
        {
            var parent = (player.Parent as Control).Parent;
            var textBlock = VisualManager.FindControl<TextBlock>(parent as UIElement, typeof(TextBlock), "tourName");
            string nameOfTour = textBlock.Text;

            if (Like)
            {
                player.SetProgress(0);
                Like = false;
                //(Application.Current as App).MainViewModel.RemoveFromFavourite(this);
            }
            else
            {
                _ = player.PlayAsync(0, 1, false);
                Like = true;
                //(Application.Current as App).MainViewModel.AddToFavourite(nameOfTour);
            }
        }
    }
}