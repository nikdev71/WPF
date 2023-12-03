using Gallery.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Gallery.ViewModel
{
    public class GalleryViewModel : DependencyObject
    {
        public static readonly DependencyProperty ImagesProperty =
            DependencyProperty.Register("Images", typeof(ObservableCollection<ImageObject>), typeof(GalleryViewModel), new PropertyMetadata(null));

        public static readonly DependencyProperty CurrentImageIndexProperty =
            DependencyProperty.Register("CurrentImageIndex", typeof(int), typeof(GalleryViewModel), new PropertyMetadata(0, OnCurrentImageIndexChanged));

        public static readonly DependencyProperty CurrentImagePathProperty =
            DependencyProperty.Register("CurrentImagePath", typeof(string), typeof(GalleryViewModel));

        public static readonly DependencyProperty CurrentImageNameProperty =
            DependencyProperty.Register("CurrentImageName", typeof(string), typeof(GalleryViewModel));

        public static readonly DependencyProperty CurrentImageDateProperty =
            DependencyProperty.Register("CurrentImageDate", typeof(string), typeof(GalleryViewModel));

        public static readonly DependencyProperty CurrentImageRateProperty =
           DependencyProperty.Register("CurrentImageRate", typeof(int), typeof(GalleryViewModel), new PropertyMetadata(0));

        public static readonly DependencyProperty CurrentImageAuthorProperty =
           DependencyProperty.Register("CurrentImageAuthor", typeof(string), typeof(GalleryViewModel));

        public static readonly DependencyProperty MaxSliderValueProperty =
           DependencyProperty.Register("MaxSliderValue", typeof(int), typeof(GalleryViewModel), new PropertyMetadata(0));

        private string AuthorInSession;
        public ObservableCollection<ImageObject> Images
        {
            get { return (ObservableCollection<ImageObject>)GetValue(ImagesProperty); }
            set { SetValue(ImagesProperty, value); }
        }

        public int CurrentImageIndex
        {
            get { return (int)GetValue(CurrentImageIndexProperty); }
            set { SetValue(CurrentImageIndexProperty, value); }
        }
        public string CurrentImagePath
        {
            get { return (string)GetValue(CurrentImagePathProperty); }
            set { SetValue(CurrentImagePathProperty, value); }
        }
        public string CurrentImageName
        {
            get { return (string)GetValue(CurrentImageNameProperty);}
            set { SetValue(CurrentImageNameProperty, value); }
        }
        public string CurrentImageDate
        {
            get { return (string)GetValue(CurrentImageDateProperty); }
            set { SetValue(CurrentImageDateProperty, value); }
        }
        public int CurrentImageRate
        {
            get { return (int)GetValue(CurrentImageRateProperty); }
            set { SetValue(CurrentImageRateProperty, value); }
        }
        public string CurrentImageAuthor
        {
            get { return (string)GetValue(CurrentImageAuthorProperty); }
            set { SetValue(CurrentImageAuthorProperty, value); } 
        }
        public int MaxSliderValue
        {
            get { return (int)GetValue(MaxSliderValueProperty); }
            set { SetValue(MaxSliderValueProperty, value); }
        }
        public GalleryViewModel()
        {
            Images = new ObservableCollection<ImageObject>();
            LoadImagesFromSavedData();
            if (Images != null)
            {
                CurrentImageIndex = Images.Count - 1;
                MaxSliderValue = Images.Count -1;
            }
        }

        #region LoadImages
        private RelayCommand _loadimages;
        public ICommand LoadIMG
        {
            get
            {
                if (_loadimages == null)
                {
                    _loadimages = new RelayCommand(param => LoadImages(), null);
                }
                return _loadimages;
            }
        }
        private void LoadImages()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
                AuthorInSession = LoginViewModel.SuccesAuthor;
                foreach (string filePath in openFileDialog.FileNames)
                {
                    var fileInfo = new FileInfo(filePath);
                    var fileName = System.IO.Path.GetFileName(filePath);
                    var image = new ImageObject
                    {
                        Name = Path.GetFileNameWithoutExtension(fileName),
                        Title = filePath,
                        Date = fileInfo.CreationTime.ToString("yyyy-MM-dd"),
                        Author = AuthorInSession,
                        Rating = 0
                    };

                    Images.Add(image);
                }
                MaxSliderValue = Images.Count-1;
                CurrentImageIndex = Images.Count-1;
            }
        }
        #endregion

        #region SaveImages
        private RelayCommand _saveimages;
        public ICommand SaveIMG
        {
            get
            {
                if(_saveimages == null)
                {
                    _saveimages = new RelayCommand(param=> SaveImagesToData(),null);
                }
                return _saveimages;
            }
        }
        public void SaveImagesToData()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(Images);
            File.WriteAllText("galleryData.json", json);
            MessageBox.Show("Images was saved", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        #endregion

        private void LoadImagesFromSavedData()
        {
            try
            {
                if (File.Exists("galleryData.json"))
                {
                    string json = File.ReadAllText("galleryData.json");
                    Images = JsonConvert.DeserializeObject<ObservableCollection<ImageObject>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading gallery data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region MoveIndex
        #region Move To Next
        private RelayCommand _movenextimage;
        public ICommand MoveNI
        {
            get
            {
                if (_movenextimage == null)
                {
                    _movenextimage = new RelayCommand(param => MoveToNextImage(),null);
                }
                return _movenextimage;
            }
        }
        public void MoveToNextImage()
        {
            if (CurrentImageIndex < Images.Count - 1)
            {
                Images[CurrentImageIndex].Rating = CurrentImageRate;
                CurrentImageIndex++;
            }
        }
        #endregion
        #region Move To Previous
        private RelayCommand _movepreviousimage;
        public ICommand MovePI
        {
            get
            {
                if(_movepreviousimage == null)
                {
                    _movepreviousimage = new RelayCommand(param=> MoveToPreviousImage(),null);
                }
                return _movepreviousimage;
            }
        }
        public void MoveToPreviousImage()
        {
            if (CurrentImageIndex > 0)
            {
                if(CurrentImageIndex < Images.Count )
                Images[CurrentImageIndex].Rating = CurrentImageRate;
                CurrentImageIndex--;
            }
        }
        #endregion
        #region Move To First
        private RelayCommand _movetofirstimage;
        public ICommand MoveFI
        {
            get
            {
                if(_movetofirstimage == null)
                {
                    _movetofirstimage = new RelayCommand(param=> MoveToFirstImage(),null);
                }
                return _movetofirstimage;
            }
        }
        public void MoveToFirstImage()
        {
            if(CurrentImageIndex >=0 && CurrentImageIndex<=Images.Count-1)
            Images[CurrentImageIndex].Rating = CurrentImageRate;
            CurrentImageIndex = 0;
        }
        #endregion
        #region Move To Last
        private RelayCommand _movetolastimage;
        public ICommand MoveLI
        {
            get
            {
                if (_movetolastimage == null)
                {
                    _movetolastimage = new RelayCommand(param => MoveToLastImage(), null);
                }
                return _movetolastimage;
            }
        }
        public void MoveToLastImage()
        {
            if (CurrentImageIndex >= 0 && CurrentImageIndex <= Images.Count - 1)
                Images[CurrentImageIndex].Rating = CurrentImageRate;
            CurrentImageIndex = Images.Count - 1;
            //CurrentImagePath = GetCurrentImagePath();
        }
        #endregion
        #endregion

        #region backupcode
        //public void ShowImageInfo()
        //{
        //    if (CurrentImageIndex >= 0 && CurrentImageIndex < Images.Count)
        //    {
        //        CurrentImageDate = Images[CurrentImageIndex].Date;
        //        CurrentImageName = Images[CurrentImageIndex].Name;
        //        CurrentImageRate = Images[CurrentImageIndex].Rating;
        //    }
        //}
        //private string GetCurrentImagePath()
        //{
        //    if (CurrentImageIndex >= 0 && CurrentImageIndex < Images.Count)
        //    {
        //        ShowImageInfo();
        //        return Images[CurrentImageIndex].Title;
        //    }

        //    return string.Empty;
        //}
        #endregion
        private void UpdateImageProperties()
        {
            if (CurrentImageIndex >= 0 && CurrentImageIndex < Images.Count)
            {
                CurrentImagePath = Images[CurrentImageIndex].Title;
                CurrentImageName = Images[CurrentImageIndex].Name;
                CurrentImageDate = Images[CurrentImageIndex].Date;
                CurrentImageRate = Images[CurrentImageIndex].Rating;
                CurrentImageAuthor = Images[CurrentImageIndex].Author;
            }
        }
        private static void OnCurrentImageIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var viewModel = (GalleryViewModel)d;
            viewModel.UpdateImageProperties();
        }
    }
}
