using Database;
using Greetings.Helpers;
using Greetings.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Greetings.ViewModels
{
    internal class PlacesViewModel : ObservableObject
    {
        private PlaceModel _selected;

        public PlaceModel Selected
        {
            get => _selected;
            set => SetProperty(ref _selected, value);
        }

        public ObservableCollection<PlaceModel> Places = new ObservableCollection<PlaceModel>();

        internal async void Initialize(int cityId)
        {
            await LoadPlacesfromDB(cityId);
            SetSelectedItem();
        }

        private void SetSelectedItem() => Selected = Places.FirstOrDefault();

        private async Task LoadPlacesfromDB(int cityId)
        {
            using (MyDBContext context = new MyDBContext())
            {
                foreach (var place in await context.Places.Where(place => place.CityId == cityId).ToListAsync())
                {
                    var imagesData = await Repository.GetImagesDataAsync(place.PlaceId);
                    var imagesSource = await ImageConverter.GetImagesSourceAsync(imagesData);

                    var card = new PlaceModel()
                    {
                        ID = place.PlaceId,
                        ImageSource = await ImageConverter.GetBitmapAsync(place.Image),
                        Name = place.PlaceName,
                        Address = place.Address,
                        Cost = place.Cost,
                        Time = place.Time,
                        Descriprion = place.Descriprion,
                        ImageSources = imagesSource.ToList()
                    };

                    Places.Add(card);
                }
            }
        }
    }
}