using ResumeDB.Model;
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
using System.Windows.Shapes;

namespace ResumeDB
{
    /// <summary>
    /// Логика взаимодействия для ResumeReview.xaml
    /// </summary>
    public partial class ResumeReview : Window
    {
        Resume temp;
        public ResumeReview(Resume obj)
        {
            InitializeComponent();
            temp = new Resume();
            temp.Name = obj.Name;
            temp.Surname = obj.Surname;
            temp.Email = obj.Email;
            temp.Post = obj.Post;
            temp.CPP = obj.CPP;
            temp.JobExperience = obj.JobExperience;
            temp.CSharp = obj.CSharp;
            temp.WPF = obj.WPF;
            temp.SQL = obj.SQL;
            temp.Unity = obj.Unity;
            DataContext = temp;

        }
    }
}
