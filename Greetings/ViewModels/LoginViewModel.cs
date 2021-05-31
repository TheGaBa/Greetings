using Greetings.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Windows.Input;
using Database;
using System.Linq;
using Database.Models;
using Windows.Storage;
using Greetings.Helpers;
using Windows.UI.Popups;

namespace Greetings.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        private string _login;

        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        private string _password;

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _repeatPassword;

        public string RepeatPassword
        {
            get => _repeatPassword;
            set => SetProperty(ref _repeatPassword, value);
        }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginMethod);
            RegisterCommand = new RelayCommand(RegisterMethod);
        }

        public ICommand LoginCommand { get; }

        public ICommand RegisterCommand { get; }

        private async void LoginMethod()
        {

            if (String.IsNullOrEmpty(_login))
            {
                var dialog = new MessageDialog("Введіть логін");
                await dialog.ShowAsync();
                return;
            }
            if (String.IsNullOrEmpty(_password))
            {
                var dialog = new MessageDialog("Введіть пароль");
                await dialog.ShowAsync();
                return;
            }
            User userToLogin = await ApplicationData.Current.LocalFolder.ReadAsync<User>("UsersRegister");

            using (MyDBContext context = new MyDBContext())
            {
                userToLogin = context.Users.FirstOrDefault(user => user.Login == _login);
            }

            if (userToLogin != null && userToLogin.Password == _password)
            {
                NavigationService.Navigate(typeof(MainPage));
            }
            else
            {
                var dialog = new MessageDialog("Неправильно введено логін або пароль");
                await dialog.ShowAsync();
            }
        }

        private async void RegisterMethod()
        {
            if (String.IsNullOrEmpty(_login))
            {
                var dialog = new MessageDialog("Введіть логін");
                await dialog.ShowAsync();
                return;
            }
            if (String.IsNullOrEmpty(_password))
            {
                var dialog = new MessageDialog("Введіть пароль");
                await dialog.ShowAsync();
                return;
            }
            if (String.IsNullOrEmpty(_repeatPassword))
            {
                var dialog = new MessageDialog("Введіть повторний пароль");
                await dialog.ShowAsync();
                return;
            }
            if (_password != _repeatPassword)
            {
                var dialog = new MessageDialog("Паролі не співпадають");
                await dialog.ShowAsync();
                return;
            }


            // User currentUser = new User(_login, _password);
            // await ApplicationData.Current.LocalFolder.SaveAsync("UsersRegister", currentUser);

            User userToLogin = await ApplicationData.Current.LocalFolder.ReadAsync<User>("UsersRegister");

            using (MyDBContext context = new MyDBContext())
            {
                userToLogin = context.Users.FirstOrDefault(user => user.Login == _login);
            }

            if (userToLogin != null)
            {
                var dialog = new MessageDialog("Користувач з таким логіном вже існує");
                await dialog.ShowAsync();
            }
            else
            {
                using (MyDBContext context = new MyDBContext())
                {
                    context.Users.Add(new User(_login, _password));
                    await context.SaveChangesAsync();
                }
                LoginMethod();
            }


        }
    }
}