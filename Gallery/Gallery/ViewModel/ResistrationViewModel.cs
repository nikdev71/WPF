using Gallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Gallery.ViewModel
{
    class RegistrationViewModel:DependencyObject
    {
        public static readonly DependencyProperty UsernameProperty =
        DependencyProperty.Register("Username", typeof(string), typeof(RegistrationViewModel));

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(RegistrationViewModel));

        public static readonly DependencyProperty PasswordAgainProperty =
            DependencyProperty.Register("PasswordAgain", typeof(string), typeof(RegistrationViewModel));

        public static readonly DependencyProperty AuthorProperty =
           DependencyProperty.Register("Author", typeof(string), typeof(LoginViewModel));
        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }

        }
        public string PasswordAgain
        {
            get { return (string)GetValue(PasswordAgainProperty); }
            set { SetValue(PasswordAgainProperty, value); }

        }
        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            set { SetValue(AuthorProperty, value); }
        }
        private RelayCommand _registrationCommand;
        public ICommand RegisterCommand {
            get
            {
                if (_registrationCommand == null)
                {
                    _registrationCommand = new RelayCommand(param=>Register(),param=>CanRegister());
                }
                return _registrationCommand;
            }
        }
        private void Register()
        {
            if (Password != PasswordAgain)
            {
                MessageBox.Show("Passwrod mismatch"); 
                return;
            }
            bool success = AuthService.Instance.RegisterUser(Username, Password, Author);
            if (success)
            {
                MessageBox.Show("Registration succesfull", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                AuthService.Instance.SaveUsersToJson();
            }
            else
            {
                MessageBox.Show("This username already exists or password too small, please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            Username = string.Empty;
            Password = string.Empty;
            PasswordAgain = string.Empty;
        }

        private bool CanRegister()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(Author);
        }
    }
}
