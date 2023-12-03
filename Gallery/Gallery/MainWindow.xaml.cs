using Gallery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AuthService.Instance.LoadUsersFromJson();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Authorisation authorisation = new Authorisation();
            authorisation.Show();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            Autentification autentification = new Autentification();
            autentification.Show();
        }


    }
}
