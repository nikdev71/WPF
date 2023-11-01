using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace NoteBook
{
    /// <summary>
    /// Логика взаимодействия для Modif.xaml
    /// </summary>
    public partial class Modif : Window
    {
        public Persontemp person;
        public Modif()
        {
            InitializeComponent();
            person = new Persontemp();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Persontemp persontemp = Resources["temp"] as Persontemp;
            person.name = fiomod.Text;
            person.adress = adressmod.Text;
            person.phone = phonemod.Text;
            //BindingExpression binding1, binding2, binding3;
            //binding1 = fiomod.GetBindingExpression(TextBox.TextProperty);
            //binding2 = adressmod.GetBindingExpression(TextBox.TextProperty);
            //binding3 = phonemod.GetBindingExpression(TextBox.TextProperty);
            //binding1.UpdateTarget();
            //binding2.UpdateTarget();
            //binding3.UpdateTarget();
            DialogResult = true;
            Close();
        }
    }
    public class Persontemp
    {
        public string name {  get; set; }
        public string adress {  get; set; }
        public string phone { get; set; } 
        
    }
}
