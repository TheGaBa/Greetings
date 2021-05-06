using Greetings.Services;
using Greetings.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Greetings.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            ExitCommand = new RelayCommand(Exit);
            ShowInfoCommand = new RelayCommand(ShowInfo);
            ShowHelpCommand = new RelayCommand(ShowHelp);
            ShowFavouritesCommand = new RelayCommand(ShowFavourites);
            ShowWelcomePageCommand = new RelayCommand(ShowWelcomePage);
        }

        internal void Initialize(Frame mainFrame)
        {
            NavigationService.Frame = mainFrame;
            ShowWelcomePage();
        }

        internal ICommand ShowWelcomePageCommand { get; }
        internal ICommand ShowInfoCommand { get; }
        internal ICommand ShowHelpCommand { get; }
        internal ICommand ShowFavouritesCommand { get; }
        internal ICommand ExitCommand { get; }


        private void ShowWelcomePage() => NavigationService.Navigate(typeof(WelcomePage));
        private void ShowInfo() => NavigationService.Navigate(typeof(InfoPage));
        private void ShowHelp() => NavigationService.Navigate(typeof(HelpPage));
        private void ShowFavourites() => NavigationService.Navigate(typeof(FavouritesPage));
        private void Exit()
        {
            NavigationService.Frame = Window.Current.Content as Frame;
            NavigationService.Navigate(typeof(LoginPage));
        }
    }
}