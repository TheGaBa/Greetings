using Greetings.Models;
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

namespace Greetings.ViewModels
{
    public class FavoritesViewModel
    {
        public ObservableCollection<VoucherModel> Favourites { get; set; }
       
        public FavoritesViewModel()
        {
        }
    }
}