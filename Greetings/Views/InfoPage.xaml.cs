using Greetings.Services;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Greetings.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InfoPage : Page
    {
        public InfoPage()
        {
            this.InitializeComponent();
            mediaPlayerControl.MediaPlayer.IsLoopingEnabled = true;
            mediaPlayerControl.MediaPlayer.AutoPlay = true;
            mediaPlayerControl.MediaPlayer.Play();
        }

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            mediaPlayerControl.MediaPlayer.Pause();
            NavigationService.Navigate(typeof(MainPage));
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            mediaPlayerControl.MediaPlayer.Pause();
            base.OnNavigatedFrom(e);
        }
    }
}