using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
using System.Windows.Threading;

namespace SpeedClick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons;
        List<Label> errors;
        int[] array;
        DispatcherTimer tm;
        int index = 0;
        int seconds = 0;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button>() { bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9, bt10, bt11, bt12, bt13, bt14, bt15, bt16 };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txB.Text == String.Empty)
            {
                MessageBox.Show("Establish game time");
                return;
            }
            newGame();
            Start();
            Buttons();
        }
        private void newGame()
        {
            index = 0;
            seconds = 0;
            listbox.Items.Clear();
            pb1.Value = 0;
            if (buttons != null)
            {
                for (int i = 0; i < buttons.Count; i++)
                {
                    buttons[i].IsEnabled = true;
                    buttons[i].Content = String.Empty;
                }
            }
        }
        private void Start()
        {
            txB.IsEnabled = false;
            pb1.Maximum = Convert.ToInt32(txB.Text);
            tm = new DispatcherTimer();
            tm.Interval = TimeSpan.FromSeconds(1);
            tm.Tick += tm_Tick;
            tm.Start();
        }
        private void Buttons()
        {
            Random rnd = new Random();
            array = new int[buttons.Count];
            errors = new List<Label>() { er1, er2, er3 };
            for (int i = 0; i < errors.Count; i++)
            {
                errors[i].Visibility = Visibility.Hidden;
            }
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Content = rnd.Next(0, 101);
                array[i] = Convert.ToInt32(buttons[i].Content);
            }
            btgame.IsEnabled = false;
            Menugame.IsEnabled = false;
            Array.Sort(array);
        }
        private void tm_Tick(object sender, EventArgs e)
        {
            seconds++;
            pb1.Value += 1;
            if (pb1.Value.ToString() == txB.Text)
            {
                MessageBox.Show("Вы проиграли");
                tm.Stop();
                txB.IsEnabled = true;
                btgame.IsEnabled = true;
                Menugame.IsEnabled = true;
                OffButtons();
            }
            this.Title = $"Прошло секунд {seconds}";
        }
        private void txB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!Regex.IsMatch(txB.Text, @"^\d+$"))
            {
                txB.Text = string.Empty;
            }
        }
        private void CheckRight(object sender, RoutedEventArgs e)
        {
            Button btt = (Button)e.OriginalSource;
            int answer = Convert.ToInt32(btt.Content);
            if (array[index] == answer)
            {
                btt.IsEnabled = false;
                index++;
                listbox.Items.Add(answer);
            }
            else
            {
                errors[0].Visibility = Visibility.Visible;
                errors.Remove(errors[0]);
                if (errors.Count == 0)
                {
                    tm.Stop();
                    txB.IsEnabled = true;
                    btgame.IsEnabled = true;
                    Menugame.IsEnabled = true;
                    OffButtons();
                    MessageBox.Show("game over");
                }

            }
            if (index == 16)
            {
                tm.Stop();
                txB.IsEnabled = true;
                btgame.IsEnabled = true;
                Menugame.IsEnabled = true;
                OffButtons();
                Winner winner = new Winner();
                winner.Show();
            }

        }
        private void OffButtons()
        {
            for(int i=0;i<buttons.Count;i++)
            {
                buttons[i].IsEnabled = false;
            }
        }

        private void game_click(object sender, RoutedEventArgs e)
        {
            if (txB.Text == String.Empty)
            {
                MessageBox.Show("Establish game time");
                return;
            }
            newGame();
            Start();
            Buttons();
        }
    }
}
