using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace NoteBook
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

        private void Add_person(object sender, RoutedEventArgs e)
        {
            if (fio.Text != String.Empty && adress.Text != String.Empty && phone.Text != String.Empty) 
            {
                Person person = Resources["lstperson"] as Person;
                string item = person.Name + "   " + person.Adress + "   " + person.Phone;
                person.people.Add(item);
            }
            else
            {
                MessageBox.Show("Invalid data","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Delete_person(object sender, RoutedEventArgs e)
        {
            Person person = Resources["lstperson"] as Person;
            string item = person.Name + "   " + person.Adress + "   " + person.Phone;
            person.people.Remove(item);
        }

        private void Modify_person(object sender, RoutedEventArgs e)
        {
            Person person = Resources["lstperson"] as Person;

            if (person.Index_selected_listbox != -1)
            {
                if (fio.Text != String.Empty && adress.Text != String.Empty && phone.Text != String.Empty)
                {
                    // Получить выбранный элемент
                    Modif window = new Modif();
                    if (window.ShowDialog() == true)
                    {
                        if (window.person.name != string.Empty && window.person.adress != string.Empty && window.person.phone != string.Empty)
                        {
                            string newItem = window.person.name + "   " + window.person.adress + "   " + window.person.phone;
                            person.people.RemoveAt(person.Index_selected_listbox);
                            person.people.Add(newItem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Select a person to modify.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Person person = Resources["lstperson"] as Person;
                if (person.Index_selected_listbox == -1)
                    return;
                string[] arr = person.people[person.Index_selected_listbox].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                person.Name = arr[0];
                person.Adress = arr[1];
                person.Phone = arr[2];
            }
            catch { }
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Person lstperson = Resources["lstperson"] as Person;
            string json = JsonConvert.SerializeObject(lstperson.people);
            File.WriteAllText("people.json", json);
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            string filePath = "people.json";

            if (File.Exists(filePath))  
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    ObservableCollection<string> peopleList = JsonConvert.DeserializeObject<ObservableCollection<string>>(json);
                    Person person = Resources["lstperson"] as Person;
                    person.people.Clear();
                    foreach (var item in peopleList)
                    {
                        person.people.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при чтении или десериализации JSON: " + ex.Message);
                }
            }
            else
            {
            }
        }
    }
    public class Person : INotifyPropertyChanged
    {
       private string name;
       private string adress;
       private string phone; 

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<string> people { get; set; } = new ObservableCollection<string>();

        public int index_selected_listbox = -1;
        public int Index_selected_listbox
        {   get
            {
                return index_selected_listbox;
            }
            set
            {
                index_selected_listbox = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Index_selected_listbox)));
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Adress)));
            }
        }
        public string Phone    
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Phone)));
            }
        }

        public void OnPropertyChanged( PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

    }
    
}
