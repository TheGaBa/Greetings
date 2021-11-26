using Database;
using Database.Models;
using Greetings.Helpers;
using Greetings.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Greetings.ViewModels
{
    public class WelcomeViewModel : ObservableObject
    {
        public ObservableCollection<CityModel> Cities = new ObservableCollection<CityModel>();

        public WelcomeViewModel()
        {
            LoadedCommand = new RelayCommand(Loaded);
        }

        internal ICommand LoadedCommand { get; }

        private async void Loaded()
        {
            List<City> loadedCities = await Repository.GetCities();

            ExcludeRepeated(loadedCities);

            AddCities(loadedCities);
        }

        internal async void FindOverpals(string searchText)
        {
            if (String.IsNullOrEmpty(searchText))
            {
                Loaded();
                return;
            }

            var overpals = await Repository.FindOverlaps(searchText);

            ExcludeUselessFromCities(overpals);

            ExcludeRepeated(overpals);

            AddCities(overpals);
        }

        /// <summary>
        /// Add collection of cities of <see cref="WelcomeViewModel.Cities"/>
        /// </summary>
        /// <param name="list">List of items for adding</param>
        private void AddCities(List<City> list) => list.ForEach(
               async city => Cities.Add(new CityModel()
               {
                   ID = city.CityId,
                   ImageSource = await ImageConverter.GetBitmapAsync(city.Image),
                   Name = city.CityName,
                   CountOfPlaces = "Count of attractions: " + Repository.GetPlacesCount(city.CityId).ToString(),
                   Rating = city.Rating,
                   Like = city.Like
               }));

        /// <summary>
        /// Exclude items from matches, that is already exist in cities to optimize interface performance 
        /// </summary>
        /// <param name="matches">List of items to compare</param>
        private void ExcludeRepeated(List<City> matches) => matches.RemoveAll(match => Cities.Count(city => city.ID == match.CityId) > 0);

        /// <summary>
        /// Exclude items from cities, that is not exist in matches
        /// </summary>
        /// <param name="matches">List of items to compare</param>
        private void ExcludeUselessFromCities(List<City> matches) => matches.ForEach(match =>
                {
                    var uselllesElement = Cities.FirstOrDefault(city => city.ID != match.CityId);

                    if (uselllesElement != null) Cities.Remove(uselllesElement);
                });

    }
}