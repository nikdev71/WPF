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
    public class LoginViewModel : DependencyObject
    {
        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(LoginViewModel));

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(LoginViewModel));


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
        private RelayCommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new RelayCommand(param => Login(), param => CanLogin());
                }
                return _loginCommand;
            }
        }
        public static string SuccesAuthor {get; set;} 
        private void Login()
        {
            bool success = AuthService.Instance.AuthenticateUser(Username, Password);
            if (success)
            {
                MessageBox.Show("Authorisation is succesfull","Info",MessageBoxButton.OK, MessageBoxImage.Information);
                SuccesAuthor = Username;
                ImageGallery imageGallery = new ImageGallery();
                imageGallery.Show();
            }
            else
            {
                MessageBox.Show("Login or password is incorrect", "Info", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool CanLogin()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }
    }
}
