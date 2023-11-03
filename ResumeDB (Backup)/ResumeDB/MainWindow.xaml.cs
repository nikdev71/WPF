using ResumeDB.ViewModels;
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

namespace ResumeDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //MainViewModel MVM;
        public MainWindow()
        {
            InitializeComponent();
            //MVM = new MainViewModel();
            //DataContext = MVM;
        }

        //private void Save_Close(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (MVM != null)
        //    {
        //        MVM.Save();
        //    }
        //}
    }
}
