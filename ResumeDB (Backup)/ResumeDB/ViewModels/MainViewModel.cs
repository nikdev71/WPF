using Microsoft.Win32;
using Newtonsoft.Json;
using ResumeDB.Model;
using ResumeDB.MyCommand;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ResumeDB.ViewModels
{
    class MainViewModel : DependencyObject
    {
        #region DependencyProperties
        private static readonly DependencyProperty NameProperty;
        private static readonly DependencyProperty SurnameProperty;
        private static readonly DependencyProperty EmailProperty;
        private static readonly DependencyProperty JEProperty;
        private static readonly DependencyProperty PostProperty;
        private static readonly DependencyProperty CPPProperty;
        private static readonly DependencyProperty CSharpProperty;
        private static readonly DependencyProperty UnityProperty;
        private static readonly DependencyProperty SQLProperty;
        private static readonly DependencyProperty WPFProperty;
        private static readonly DependencyProperty ResumesProperty;
        private static readonly DependencyProperty SelectedIndexProperty;

        static MainViewModel()
        {
            NameProperty = DependencyProperty.Register("Name",typeof(string),typeof(MainViewModel));
            SurnameProperty = DependencyProperty.Register("Surname",typeof(string),typeof(MainViewModel));
            EmailProperty = DependencyProperty.Register("Email",typeof(string),typeof(MainViewModel));
            JEProperty = DependencyProperty.Register("JE",typeof(string),typeof(MainViewModel));
            PostProperty = DependencyProperty.Register("Post",typeof(string),typeof(MainViewModel));
            CPPProperty = DependencyProperty.Register("CPP",typeof(bool),typeof(MainViewModel));
            CSharpProperty = DependencyProperty.Register("CSharp",typeof(bool),typeof(MainViewModel));
            UnityProperty = DependencyProperty.Register("Unity",typeof(bool),typeof(MainViewModel));
            SQLProperty = DependencyProperty.Register("SQL",typeof(bool),typeof(MainViewModel));
            WPFProperty = DependencyProperty.Register("WPF", typeof(bool),typeof(MainViewModel));
            ResumesProperty = DependencyProperty.Register("Resumes", typeof(ObservableCollection<Resume>),typeof(MainViewModel));
            SelectedIndexProperty = DependencyProperty.Register("SelectedIndex", typeof(int), typeof(MainViewModel), new PropertyMetadata(-1));
        }
        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }
        public string Surname
        {
            get { return (string)GetValue(SurnameProperty); }
            set { SetValue(SurnameProperty, value); }
        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }

        public string JE
        {
            get { return (string)GetValue(JEProperty); }
            set { SetValue(JEProperty, value); }
        }
        public string Post
        {
            get { return (string)GetValue(PostProperty); }
            set { SetValue(PostProperty, value); }
        }

        public bool CPP
        {
            get { return (bool)GetValue(CPPProperty); }
            set { SetValue(CPPProperty, value); }
        }
        public bool CSharp
        {
            get { return (bool)GetValue(CSharpProperty); }
            set { SetValue(CSharpProperty, value); }
        }
        public bool Unity
        {
            get { return (bool)GetValue(UnityProperty); }
            set { SetValue(UnityProperty, value); }
        }
        public bool SQL
        {
            get { return (bool)GetValue(SQLProperty); }
            set { SetValue(SQLProperty, value); }
        }
        public bool WPF
        {
            get { return (bool)GetValue(WPFProperty); }
            set { SetValue(WPFProperty, value); }
        }

        public ObservableCollection<Resume> Resumes
        {
            get { return (ObservableCollection<Resume>)GetValue(ResumesProperty); }
            set { SetValue(ResumesProperty, value); }
        }
        #endregion
        public MainViewModel()
        {
            Name = "";
            Surname = "";
            Email = "";
            JE = "";
            Post = "";
            CPP = false; CSharp = false; Unity = false; SQL = false; WPF = false;
            Resumes = new ObservableCollection<Resume>();
            Load();
        }
        DelegateCommand addResume;
        public ICommand AddResume
        {
            get
            {
                if (addResume == null)
                {
                    addResume = new DelegateCommand(param =>Add(),param => Add_CanExecute());
                }
                return addResume;
            }
        }
        void Add()
        {
            Resume person = new Resume(Name, Surname, Email, JE, Post,CPP,CSharp,Unity,WPF,SQL);
            Resumes.Add(person);
            Name = string.Empty; Surname = string.Empty; Email = string.Empty; JE = string.Empty; Post = string.Empty;
            CPP = false; CSharp = false; Unity = false; WPF = false; SQL = false;
        }
        bool Add_CanExecute()
        {
            if(Name != string.Empty && Surname != string.Empty && Email != string.Empty && JE != string.Empty && Post != string.Empty)
            {
                return true;
            }
            return false;
        }
        DelegateCommand clear;
        public ICommand Clear
        {
            get {
                if(clear == null)
                {
                    clear = new DelegateCommand(param =>ClearProperties(), null);
                }
                return clear;
            }

        }
        void ClearProperties()
        {
            Name = "";
            Surname = "";
            Email = "";
            JE = "";
            Post = "";
            CPP = false; CSharp = false; Unity = false; SQL = false; WPF = false;
        }

        DelegateCommand reviewResume;
        public ICommand ReviewResume
        {
            get { 
                if(reviewResume==null)
                {
                    reviewResume = new DelegateCommand(param=>GetResume(), param => GetResume_CanExecute());
                }
                return reviewResume; }
        }
        void GetResume()
        {
            if(SelectedIndex != -1)
            {
                Resume temp = Resumes[SelectedIndex];
                ResumeReview window = new ResumeReview(temp);
                window.Show();
            }
        }
        bool GetResume_CanExecute()
        {
            if (SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(Resumes);
            File.WriteAllText("people.json", json);
        }
        void Load()
        {
            string filePath = "people.json";

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    ObservableCollection<Resume> peopleList = JsonConvert.DeserializeObject<ObservableCollection<Resume>>(json);
                    foreach (Resume item in peopleList)
                    {
                        Resumes.Add(item);
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
}
