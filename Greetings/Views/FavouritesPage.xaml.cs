﻿using Greetings.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Greetings.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FavouritesPage : Page
    {

        public static ObservableCollection<VoucherModel> Favorites = new ObservableCollection<VoucherModel>();

        public FavouritesPage()
        {
            this.InitializeComponent();
            favouritesItems.ItemsSource = Favorites;
        }
    }
}