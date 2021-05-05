using Greetings.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Greetings.Controls
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlaseDetailControl : Page
    {
        public PlaceModel Place
        {
            get => GetValue(PlaceProperty) as PlaceModel; 
            set => SetValue(PlaceProperty, value);
        }

        // Using a DependencyProperty as the backing store for Place.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceProperty =
            DependencyProperty.Register("Place", typeof(PlaceModel), typeof(PlaseDetailControl), new PropertyMetadata(0));

        public PlaseDetailControl()
        {
            this.InitializeComponent();
        }
    }
}