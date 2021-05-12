using Database;
using Database.Models;
using Greetings.Helpers;
using Greetings.Helpers.Comparers;
using Greetings.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
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
            List<CityModel> loadedCities = await CastToCityModelAsync(await Repository.GetCities());

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

            var overpals = await CastToCityModelAsync(await Repository.FindOverlaps(searchText));

            ExcludeUselessFromCities(overpals);

            ExcludeRepeated(overpals);

            AddCities(overpals);
        }

        /// <summary>
        /// Add collection of cities of <see cref="WelcomeViewModel.Cities"/>
        /// </summary>
        /// <param name="list">List of items for adding</param>
        private void AddCities(List<CityModel> list) => list.ForEach(city => Cities.Add(city));

        /// <summary>
        /// Exclude items from matches, that is already exist in cities to optimize interface performance 
        /// </summary>
        /// <param name="matches">List of items to compare</param>
        private void ExcludeRepeated(List<CityModel> matches) => matches.RemoveAll(match => Cities.Count(city => city.ID == match.ID) > 0);

        /// <summary>
        /// Exclude items from cities, that is not exist in matches
        /// </summary>
        /// <param name="matches">List of items to compare</param>
        private void ExcludeUselessFromCities(List<CityModel> matches)
        {
            CityModel[] cityModels = new CityModel[Cities.Count];
            Cities.CopyTo(cityModels, 0);

            var useless = cityModels.Except(matches, new CityComparer());

            foreach (var item in useless)
            {
                Cities.Remove(item);
            }
        }

        private async Task<List<CityModel>> CastToCityModelAsync(List<City> cities)
        {
            List<CityModel> cityModels = new List<CityModel>();

            foreach (var city in cities)
            {
                cityModels.Add(new CityModel()
                {
                    ID = city.CityId,
                    ImageSource = await ImageConverter.GetBitmapAsync(city.Image),
                    Name = city.CityName,
                    CountOfPlaces = "Count of attractions: " + Repository.GetPlacesCount(city.CityId).ToString(),
                    Rating = city.Rating,
                    Like = city.Like
                });

            }
            return cityModels;
        }
    }
}