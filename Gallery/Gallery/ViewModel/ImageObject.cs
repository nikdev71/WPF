using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gallery.ViewModel
{
    public class ImageObject : DependencyObject
    {
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(ImageObject));
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(ImageObject));
        public static readonly DependencyProperty DateProperty = DependencyProperty.Register("Date", typeof(string), typeof(ImageObject));
        public static readonly DependencyProperty AuthorProperty = DependencyProperty.Register("Author", typeof(string), typeof(ImageObject));
        public static readonly DependencyProperty RatingProperty = DependencyProperty.Register("Rating", typeof(int), typeof(ImageObject));
        public string Name
        {
            get { return (string)GetValue(NameProperty);}
            set { SetValue(NameProperty, value); }
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string Date
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        public string Author
        {
            get { return (string)GetValue(AuthorProperty); }
            set { SetValue(AuthorProperty, value); }
        }

        public int Rating
        {
            get { return (int)GetValue(RatingProperty); }
            set { SetValue(RatingProperty, value); }
        }
    }

}
