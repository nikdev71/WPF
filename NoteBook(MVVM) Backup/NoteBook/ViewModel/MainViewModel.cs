﻿using Newtonsoft.Json;
using NoteBook.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.IO;

namespace NoteBook.ViewModel
{
    class MainViewModel : DependencyObject
    {
        static MainViewModel()
        {
            NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(MainViewModel));
            AdressProperty = DependencyProperty.Register("Adress", typeof(string), typeof(MainViewModel));
            PhoneProperty = DependencyProperty.Register("Phone", typeof(string), typeof(MainViewModel));
            SelectedIndexProperty = DependencyProperty.Register("SelectedIndex", typeof(int), typeof(MainViewModel), new PropertyMetadata(-1));
        }
        #region Add Person
        MyCommand addPerson;
        public ICommand AddPerson
        {
            get
            {
                if (addPerson == null)
                {
                    addPerson = new MyCommand(param => Add_person(), param => Add_person_CanExecuted());
                }
                return addPerson;
            }
        }
        private void Add_person()
        {
            if (Name != null && Adress != null && Phone != null)
            {
                string item = Name + "   " + Adress + "   " + Phone;
                people.Add(item);
                Name = null;
                Adress = null;
                Phone = null;
            }

        }
        private bool Add_person_CanExecuted()
        {
            if (Name != null && Adress != null && Phone != null)
            { return true; }
            else return false;
        }
        #endregion

        #region Delete Person
        MyCommand delPerson;
        public ICommand DelPerson
        {
            get
            {
                if (delPerson == null)
                {
                    delPerson = new MyCommand(param => Delete_person(), param => Delete_person_CanExecuted());
                }
                return delPerson;
            }
        }
        private void Delete_person()
        {
            people.Remove(people[SelectedIndex]);
            Name = null;
            Adress = null;
            Phone = null;
        }
        private bool Delete_person_CanExecuted()
        {

            if (SelectedIndex == -1)
            {
                return false;
            }
            else { return true; }
        }
        #endregion

        #region Save
        MyCommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new MyCommand(param => SaveCommand_Executed(), param => SaveCommand_CanExecute());
                }
                return save;
            }
        }
        private void SaveCommand_Executed()
        {
            string json = JsonConvert.SerializeObject(people);
            File.WriteAllText("people.json", json);
        }
        private bool SaveCommand_CanExecute()
        {
            if (people.Count == 0) return false;
            else return true;
        }
        #endregion

        #region Load
        MyCommand load;
        public ICommand Load
        {
            get
            {
                if (load == null)
                {
                    load = new MyCommand(param => OpenCommand(), param => OpenCommand_CanExecuted());
                }
                return load;
            }
        }
        private void OpenCommand()
        {
            string filePath = "people.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    ObservableCollection<string> peopleList = JsonConvert.DeserializeObject<ObservableCollection<string>>(json);
                    people.Clear();
                    foreach (var item in peopleList)
                    {
                        people.Add(item);
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
        private bool OpenCommand_CanExecuted()
        {
            string path = "people.json";
            if (File.Exists(path))
            {
                return true;
            }
            else return false;
        }
        #endregion

        #region Modify Person
        MyCommand modify;
        public ICommand Modify
        {
            get
            {
                if (modify == null)
                {
                    modify = new MyCommand(param => Modify_person(), param => Modify_person_CanExecuted());
                }
                return modify;
            }
        }
        private void Modify_person()
        {

            if (SelectedIndex != -1)
            {
                Modif window = new Modif();
                if (window.ShowDialog() == true)
                {
                    if (window.person.name != string.Empty && window.person.adress != string.Empty && window.person.phone != string.Empty)
                    {
                        string newItem = window.person.name + "   " + window.person.adress + "   " + window.person.phone;
                        people.RemoveAt(SelectedIndex);
                        people.Add(newItem);
                    }
                    else
                    {
                        MessageBox.Show("Invalid data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a person to modify.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private bool Modify_person_CanExecuted()
        {

            if (SelectedIndex == -1)
            {
                return false;
            }
            else return true; 
        }
        #endregion

        #region Selcetion Changed
        MyCommand selectionChanged;
        public ICommand SelectionChanged
        {
            get
            {
                if (selectionChanged == null)
                {
                    selectionChanged = new MyCommand(param => SelectionChangedl_listbox(), null);
                }
                return selectionChanged;
            }
        }
        private void SelectionChangedl_listbox()
        {
            if (SelectedIndex == -1)
                return;
            string[] arr = people[SelectedIndex].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Name = arr[0];
            Adress = arr[1];
            Phone = arr[2];
        }
        #endregion

        #region Dependency Object
        private static readonly DependencyProperty NameProperty;
        private static readonly DependencyProperty AdressProperty;
        private static readonly DependencyProperty PhoneProperty;
        private static readonly DependencyProperty SelectedIndexProperty;

        public ObservableCollection<string> people { get; set; } = new ObservableCollection<string>();

        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public string Adress
        {
            get { return (string)GetValue(AdressProperty); }
            set { SetValue(AdressProperty, value); }
        }
        public string Phone
        {
            get { return (string)GetValue(PhoneProperty); }
            set { SetValue(PhoneProperty, value); }
        }
        #endregion
    }
}



