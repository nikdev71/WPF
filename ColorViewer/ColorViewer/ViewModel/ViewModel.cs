using ColorViewer.Command;
using ColorViewer.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ColorViewer.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private int sliderValue1;
        public int SliderValue1
        {
            get
            {
                return sliderValue1;
            }
            set
            {
                sliderValue1 = value; UpdateColor();
                OnPropertyChanged(nameof(SliderValue1));
            }
        }
        private int sliderValue2;
        public int SliderValue2
        {
            get
            {
                return sliderValue2;
            }
            set
            {
                sliderValue2 = value; UpdateColor();
                OnPropertyChanged(nameof(SliderValue2));
            }
        }
        private int sliderValue3;
        public int SliderValue3
        {
            get
            {
                return sliderValue3;
            }
            set
            {
                sliderValue3 = value; UpdateColor();
                OnPropertyChanged(nameof(SliderValue3));
            }
        }
        private int sliderValue4;
        public int SliderValue4
        {
            get
            {
                return sliderValue4;
            }
            set
            {
                sliderValue4 = value; UpdateColor();
                OnPropertyChanged(nameof(SliderValue4));
            }
        }

        private Color tempcolor ;
        public string TempColor
        {
            get
            {
                return "#" + tempcolor.A.ToString("X2") + tempcolor.R.ToString("X2") + tempcolor.G.ToString("X2") + tempcolor.B.ToString("X2");
            }
            
        }
        public Color TempColorSet
        {
           
            set
            {
                if (tempcolor != value)
                {
                    tempcolor = value;
                    OnPropertyChanged(nameof(TempColor));
                }
            }
        }
        private void UpdateColor()
        {
            TempColorSet = Color.FromArgb(sliderValue1, sliderValue2, sliderValue3, sliderValue4);
        }
        ObservableCollection<MyColor> colors = new ObservableCollection<MyColor>();
        public ObservableCollection<MyColor> Colors
        {
            get
            {
                return colors;
            }
            set
            {
                colors = value;
                OnPropertyChanged(nameof(Colors));
            }
        }
        private int index_selected_listbox = -1;

        public int Index_selected_listbox
        {
            get { return index_selected_listbox; }
            set
            {
                index_selected_listbox = value;
                OnPropertyChanged(nameof(Index_selected_listbox));
            }
        }
        private MyCommand delColor;
        public ICommand DeleteColor
        {
            get
             {
                if (delColor == null)
                {
                    delColor = new MyCommand(param => delcolorfromlist(),param => delcolorfromlist_CanExecute());
                }
                return delColor;
            }

        }
        public void delcolorfromlist()
        {
            if (Index_selected_listbox != -1)
            {
                colors.RemoveAt(Index_selected_listbox);
            }
        }
        public bool delcolorfromlist_CanExecute()
        {
            if (Index_selected_listbox != -1)
            {
                return true;
            }
            return false;
        }
        private MyCommand addColor;
        public ICommand AddColor
        {
            get
            {
                if(addColor == null)
                {
                    addColor = new MyCommand(param => addcolortolist() , param => addcolortolist_CanExecute());
                }
                return addColor;
            }
           
        }
        public void addcolortolist()
        {
            Color color = Color.FromArgb(sliderValue1,sliderValue2,sliderValue3,sliderValue4);
            MyColor myColor = new MyColor(color);
            colors.Add(myColor);
        }
        public bool addcolortolist_CanExecute()
        {
            Color color = Color.FromArgb(sliderValue1, sliderValue2, sliderValue3, sliderValue4);
            MyColor myColor = new MyColor(color);

            return !colors.Any(c => c.Name == myColor.Name);
           
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(e));
        }
    }
}
