using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media;

namespace Greetings.Models
{
    public class PlaceModel
    {
        internal int ID { get; set; }

        internal string Name { get; set; }

        internal string Address { get; set; }

        public double Cost { get; set; }

        public int Time { get; set; }

        public string Descriprion { get; set; }

        internal ImageSource ImageSource { get; set; }

        public ObservableCollection<ImageSource> ImageSources { get; set; }

    }
}