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

namespace Containers2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            tx1.Text += button.Content.ToString();
        }

        private void Button_clickOK(object sender, RoutedEventArgs e)
        {
            if (tx1.Text == "12345")
            {
                MessageBox.Show("Password is correct");
            }
            else MessageBox.Show("Password is incorect");
        }

        private void Button_clickC(object sender, RoutedEventArgs e)
        {
            tx1.Text = "";
        }
    }
}
