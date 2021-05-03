using Greetings.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Windows.Input;
using Database;
using System.Linq;
using Database.Models;

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
            if (String.IsNullOrEmpty(_login)) return;
            if (String.IsNullOrEmpty(_password)) return;

            // User userToLogin = await ApplicationData.Current.LocalFolder.ReadAsync<User>("UsersRegister");

            User userToLogin;

            using (MyDBContext context = new MyDBContext())
            {
                userToLogin = context.Users.FirstOrDefault(user => user.Login == _login);
            }

            if (userToLogin != null && userToLogin.Password == _password)
            {
                NavigationService.Navigate(typeof(MainPage));
            }
        }

        private async void RegisterMethod()
        {
            if (String.IsNullOrEmpty(_login)) return;
            if (String.IsNullOrEmpty(_password)) return;
            if (String.IsNullOrEmpty(_repeatPassword)) return;
            if (_password != _repeatPassword) return;

            // User currentUser = new User(_login, _password);
            // await ApplicationData.Current.LocalFolder.SaveAsync("UsersRegister", currentUser);

            using (MyDBContext context = new MyDBContext())
            {
                context.Users.Add(new User(_login, _password));
                await context.SaveChangesAsync();
            }

            LoginMethod();
        }
    }
}