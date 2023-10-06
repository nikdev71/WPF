using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Printing;
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

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tx2.PreviewKeyDown += Window_PreviewKeyDown;
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Regex.IsMatch(e.Key.ToString(), @"^D[0-9]$"))
            {
                tx2.Text += (char)('0' + (e.Key - Key.D0));

            }
            if (e.Key == Key.Back)
            {
                if (!string.IsNullOrEmpty(tx2.Text))
                {
                    tx2.Text = tx2.Text.Substring(0, tx2.Text.Length - 1);
                    tx2.CaretIndex = tx2.Text.Length;

                }

            }
            e.Handled = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tx2.Text = "";
            if (tx1.Text.EndsWith("="))
            {
                tx1.Text = string.Empty;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tx2.Text))
            {
                tx2.Text = tx2.Text.Substring(0, tx2.Text.Length - 1);
                tx2.CaretIndex = tx2.Text.Length;

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tx1.Text = "";
            tx2.Text = "";
        }

        private void btn_num(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.Source;
            if (tx1.Text != string.Empty)
            {
                if (tx1.Text.EndsWith("="))
                {
                    tx1.Text = "";
                    tx2.Text = button.Content.ToString();
                    return;
                }
            }
            if (button.Content.ToString() == "0")
            {
                if (tx2.Text.StartsWith("0") && tx2.Text.Length == 1)
                {
                    return;
                }
                else
                {
                    tx2.Text += button.Content.ToString();
                    return;
                }
            }
            if (tx2.Text == "0")
            {
                tx2.Text = button.Content.ToString();
            }
            else
            {
                tx2.Text += button.Content;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tx1.Text != string.Empty && tx1.Text.EndsWith("="))
            {
                return;

            }
            if (!string.IsNullOrEmpty(tx2.Text))
            {
                if (!Regex.IsMatch(tx2.Text, @"\."))
                { tx2.Text += "."; }

            }
        }

        private void Operation(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.Source;
            if (tx1.Text != string.Empty)
            {
                if (tx1.Text.EndsWith("="))
                {
                    if (tx2.Text != String.Empty)
                    {
                        tx1.Text = tx2.Text + " " + button.Content + " ";
                        tx2.Text = "";
                    }
                    return;
                }
                if (tx2.Text == string.Empty)
                {
                    if (tx1.Text.EndsWith("/ "))
                    {
                        tx1.Text = tx1.Text.Replace("/", button.Content.ToString());
                        tx2.Text = "";
                        return;
                    }
                    else if (tx1.Text.EndsWith("- "))
                    {
                        tx1.Text = tx1.Text.Replace("-", button.Content.ToString());
                        tx2.Text = "";
                        return;
                    }
                    else if (tx1.Text.EndsWith("+ "))
                    {
                        tx1.Text = tx1.Text.Replace("+", button.Content.ToString());
                        tx2.Text = "";
                        return;
                    }
                    else if (tx1.Text.EndsWith("* "))
                    {
                        tx1.Text = tx1.Text.Replace("*", button.Content.ToString());
                        tx2.Text = "";
                        return;
                    }
                }
            }
            if (tx2.Text == string.Empty) return;

            tx1.Text += tx2.Text + " " + button.Content + " ";
            tx2.Text = "";


        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (tx1.Text.EndsWith("=")) return;
            if (tx2.Text == string.Empty) return;
            try
            {
                tx1.Text += tx2.Text;
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), tx1.Text);

                DataRow row = table.NewRow();
                table.Rows.Add(row);

                decimal result = decimal.Parse((string)row["expression"]);

                tx2.Text = result.ToString().Replace(",",".");
                tx1.Text += " =";
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
