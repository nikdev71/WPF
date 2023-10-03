using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Container3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tx00.Text != String.Empty && tx01.Text != String.Empty & tx02.Text != String.Empty
                && tx10.Text != String.Empty && tx11.Text != String.Empty && tx12.Text !=String.Empty
                &&tx20.Text !=String.Empty && tx21.Text != String.Empty && tx22.Text != String.Empty)
            {
                int res = Convert.ToInt32(tx00.Text) * Convert.ToInt32(tx11.Text) * Convert.ToInt32(tx22.Text) -
                           Convert.ToInt32(tx00.Text) * Convert.ToInt32(tx12.Text) * Convert.ToInt32(tx21.Text) -
                           Convert.ToInt32(tx10.Text) * Convert.ToInt32(tx01.Text) * Convert.ToInt32(tx22.Text) +
                           Convert.ToInt32(tx01.Text) * Convert.ToInt32(tx12.Text) * Convert.ToInt32(tx20.Text) +
                           Convert.ToInt32(tx02.Text) * Convert.ToInt32(tx10.Text) * Convert.ToInt32(tx21.Text) -
                           Convert.ToInt32(tx02.Text) * Convert.ToInt32(tx11.Text) * Convert.ToInt32(tx20.Text);
                answ.Content = res;
            }
        }

        private void TextBox_TextInput(object sender, TextChangedEventArgs e)
        {
            TextBox tx = (TextBox)sender;
            if (!Regex.IsMatch(tx.Text, @"^(-)?[0-9]*([,]?[0-9]*)$"))
            {
                tx.Text = "";
            }
        }
    }
}
