using Greetings.Services;
using Greetings.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace Greetings.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            ExitCommand = new RelayCommand(Exit);
            ShowInfoCommand = new RelayCommand(ShowInfo);
            ShowHelpCommand = new RelayCommand(ShowHelp);
        }


        public ICommand ShowInfoCommand { get; }
        public ICommand ShowHelpCommand { get; }
        public ICommand ExitCommand { get; }

        private void Exit() => NavigationService.Navigate(typeof(LoginPage));
        private void ShowInfo() => NavigationService.Navigate(typeof(InfoPage));
        private void ShowHelp() => NavigationService.Navigate(typeof(HelpPage));
    }
}