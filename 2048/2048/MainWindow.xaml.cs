using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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
using static System.Net.Mime.MediaTypeNames;

namespace _2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Label[,] field;
        string hs;
        public MainWindow()
        {
            InitializeComponent();
            using (StreamReader filestream = new StreamReader("highscore.txt"))
            {
                hs= filestream.ReadToEnd();
                highscore.Text = hs;
            }
            field = new Label[4, 4];
            InitField();
            GenPlate();
        }
        
        private void InitField()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++) 
                {
                    string labelName = "b" + j + i;
                    Label label = FindName(labelName) as Label;
                    field[i, j] = label;
                }
            }
        }
        private Label Label4()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.Orange);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "4";
            return label;
        }
        private Label Label8()
        {
            ControlTemplate plt8 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.DarkOrange);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt8.VisualTree = border;

            Label label = new Label();
            label.Template = plt8;
            label.FontSize = 36;
            label.Content = "8";
            return label;
        }
        private Label Label16()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.Red);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "16";
            return label;
        }
        private Label Label32()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.Green);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "32";
            return label;
        }
        private Label Label64()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.DarkGreen);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "64";
            return label;
        }
        private Label Label128()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.Blue);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "128";
            return label;
        }
        private Label Label256()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.DarkBlue);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "256";
            return label;
        }
        private Label Label512()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.Purple);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "512";
            return label;
        }
        private Label Label1024()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.DarkViolet);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "1024";
            return label;
        }
        private Label Label2048()
        {
            ControlTemplate plt4 = new ControlTemplate(typeof(Label));
            FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
            border.SetValue(Border.BackgroundProperty, Brushes.Gold);
            border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
            FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
            FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
            contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
            grid.AppendChild(contentPresenter);
            border.AppendChild(grid);
            plt4.VisualTree = border;

            Label label = new Label();
            label.Template = plt4;
            label.FontSize = 36;
            label.Content = "2048";
            return label;
        }
        private bool HasNullField()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (field[i, j].Content == null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void GenPlate()
        {
            if (!HasNullField())
            { 
                return;
            }
            Random rnd = new Random();
            int chance = new Random().Next(1, 11);
            if (chance != 10)
            {
                ControlTemplate plt2 = new ControlTemplate(typeof(Label));
                FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
                border.SetValue(Border.BackgroundProperty, Brushes.Lavender);
                border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
                FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
                FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
                contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
                contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
                grid.AppendChild(contentPresenter);
                border.AppendChild(grid);
                plt2.VisualTree = border;

                Label label = new Label();
                label.Template = plt2;
                label.FontSize = 36;
                label.Content = "2";

                while (true)
                {
                    int i = rnd.Next(0, 4);
                    int j = rnd.Next(0, 4);
                    if (field[i, j].Content == null)
                    {
                        field[i, j].Content = label;
                        break;
                    }
                }
            }
            else
            {
                ControlTemplate plt4 = new ControlTemplate(typeof(Label));
                FrameworkElementFactory border = new FrameworkElementFactory(typeof(Border));
                border.SetValue(Border.BackgroundProperty, Brushes.Orange);
                border.SetValue(Border.CornerRadiusProperty, new CornerRadius(10));
                FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));
                FrameworkElementFactory contentPresenter = new FrameworkElementFactory(typeof(ContentPresenter));
                contentPresenter.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
                contentPresenter.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);
                grid.AppendChild(contentPresenter);
                border.AppendChild(grid);
                plt4.VisualTree = border;

                Label label = new Label();
                label.Template = plt4;
                label.FontSize = 36;
                label.Content = "4";

                while (true)
                {
                    int i = rnd.Next(0, 4);
                    int j = rnd.Next(0, 4);
                    if (field[i, j].Content == null)
                    {
                        field[i, j].Content = label;
                        break;
                    }
                }
            }
        }
        private void Movement(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j<4; j++)
                    {
                        if (field[i,j].Content!=null)
                        {
                            if (j+1<4 && field[i,j+1].Content != null)
                            {
                                if (field[i, j + 1].Content.ToString() == field[i,j].Content.ToString())
                                {
                                    string content = (field[i,j].Content as Label)?.Content.ToString();
                                    if (!string.IsNullOrEmpty(content)&& int.TryParse(content,out int value))
                                    {
                                        int newValue = value*2;
                                        int score = Convert.ToInt32(Score.Text);
                                        Score.Text = Convert.ToString(score + newValue);
                                        switch(newValue)
                                        {
                                            case 4:
                                                field[i,j+1].Content = Label4();
                                                break;
                                            case 8:
                                                field[i, j+1].Content = Label8();
                                                break;
                                            case 16:
                                                field[i, j + 1].Content = Label16();
                                                break;
                                            case 32:
                                                field[i, j + 1].Content = Label32();
                                                break;
                                            case 64:
                                                field[i, j + 1].Content = Label64();
                                                break;
                                            case 128:
                                                field[i, j + 1].Content = Label128();
                                                break;
                                            case 256:
                                                field[i, j + 1].Content = Label256();
                                                break;
                                            case 512:
                                                field[i, j + 1].Content = Label512();
                                                break;
                                            case 1024:
                                                field[i, j + 1].Content = Label1024();
                                                break;
                                            case 2048:
                                                field[i, j + 1].Content = Label2048();
                                                break;
                                            default:
                                                break;
                                        }
                                        field[i, j].Content = null;
                                    }
                                    
                                }
                               continue;
                            }
                            if (j + 1 < 4)
                            {
                                field[i, j + 1].Content = field[i, j].Content;
                                field[i, j].Content = null;
                                continue;
                            }
                        } 
                    }
                }
            }
            if (e.Key == Key.S)
            {
                for (int i = 0; i <4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (field[i, j].Content != null)
                        {
                            if (i + 1 < 4 && field[i+1, j].Content != null)
                            {
                                if (field[i+1, j].Content.ToString() == field[i, j].Content.ToString())
                                {
                                    string content = (field[i, j].Content as Label)?.Content.ToString();
                                    if (!string.IsNullOrEmpty(content) && int.TryParse(content, out int value))
                                    {
                                        int newValue = value * 2;
                                        int score = Convert.ToInt32(Score.Text);
                                        Score.Text = Convert.ToString(score + newValue);
                                        switch (newValue)
                                        {
                                            case 4:
                                                field[i+1, j ].Content = Label4();
                                                break;
                                            case 8:
                                                field[i +1, j ].Content = Label8();
                                                break;
                                            case 16:
                                                field[i+1, j ].Content = Label16();
                                                break;
                                            case 32:
                                                field[i+1, j ].Content = Label32();
                                                break;
                                            case 64:
                                                field[i+1, j ].Content = Label64();
                                                break;
                                            case 128:
                                                field[i+1, j ].Content = Label128();
                                                break;
                                            case 256:
                                                field[i+1, j ].Content = Label256();
                                                break;
                                            case 512:
                                                field[i+1, j ].Content = Label512();
                                                break;
                                            case 1024:
                                                field[i+1, j ].Content = Label1024();
                                                break;
                                            case 2048:
                                                field[i+1, j ].Content = Label2048();
                                                break;
                                            default:
                                                break;
                                        }
                                        field[i, j].Content = null;
                                    }

                                }
                                continue;
                            }
                            if (i + 1 < 4)
                            {
                                field[i+1, j ].Content = field[i, j].Content;
                                field[i, j].Content = null;
                                continue;
                            }
                        }
                    }
                }
            }
            if (e.Key == Key.W)
            {
                for (int i = 3; i >=0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (field[i, j].Content != null)
                        {
                            if (i - 1 >=0 && field[i - 1, j].Content != null)
                            {
                                if (field[i - 1, j].Content.ToString() == field[i, j].Content.ToString())
                                {
                                    string content = (field[i, j].Content as Label)?.Content.ToString();
                                    if (!string.IsNullOrEmpty(content) && int.TryParse(content, out int value))
                                    {
                                        int newValue = value * 2;
                                        int score = Convert.ToInt32(Score.Text);
                                        Score.Text = Convert.ToString(score + newValue);
                                        switch (newValue)
                                        {
                                            case 4:
                                                field[i - 1, j].Content = Label4();
                                                break;
                                            case 8:
                                                field[i - 1, j].Content = Label8();
                                                break;
                                            case 16:
                                                field[i - 1, j].Content = Label16();
                                                break;
                                            case 32:
                                                field[i - 1, j].Content = Label32();
                                                break;
                                            case 64:
                                                field[i - 1, j].Content = Label64();
                                                break;
                                            case 128:
                                                field[i - 1, j].Content = Label128();
                                                break;
                                            case 256:
                                                field[i - 1, j].Content = Label256();
                                                break;
                                            case 512:
                                                field[i - 1, j].Content = Label512();
                                                break;
                                            case 1024:
                                                field[i - 1, j].Content = Label1024();
                                                break;
                                            case 2048:
                                                field[i - 1, j].Content = Label2048();
                                                break;
                                            default:
                                                break;
                                        }
                                        field[i, j].Content = null;
                                    }

                                }
                                continue;
                            }
                            if (i - 1 >= 0)
                            {
                                field[i - 1, j].Content = field[i, j].Content;
                                field[i, j].Content = null;
                                continue;
                            }
                        }
                    }
                }
            }
            if (e.Key == Key.A)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 3; j >=0; j--)
                    {
                        if (field[i, j].Content != null)
                        {
                            if (j - 1 >=0 && field[i, j - 1].Content != null)
                            {
                                if (field[i, j - 1].Content.ToString() == field[i, j].Content.ToString())
                                {
                                    string content = (field[i, j].Content as Label)?.Content.ToString();
                                    if (!string.IsNullOrEmpty(content) && int.TryParse(content, out int value))
                                    {
                                        int newValue = value * 2;
                                        int score = Convert.ToInt32(Score.Text);
                                        Score.Text = Convert.ToString(score + newValue);
                                        switch (newValue)
                                        {
                                            case 4:
                                                field[i, j - 1].Content = Label4();
                                                break;
                                            case 8:
                                                field[i, j - 1].Content = Label8();
                                                break;
                                            case 16:
                                                field[i, j - 1].Content = Label16();
                                                break;
                                            case 32:
                                                field[i, j - 1].Content = Label32();
                                                break;
                                            case 64:
                                                field[i, j - 1].Content = Label64();
                                                break;
                                            case 128:
                                                field[i, j - 1].Content = Label128();
                                                break;
                                            case 256:
                                                field[i, j - 1].Content = Label256();
                                                break;
                                            case 512:
                                                field[i, j - 1].Content = Label512();
                                                break;
                                            case 1024:
                                                field[i, j - 1].Content = Label1024();
                                                break;
                                            case 2048:
                                                field[i, j - 1].Content = Label2048();
                                                break;
                                            default:
                                                break;
                                        }
                                        field[i, j].Content = null;
                                    }

                                }
                                continue;
                            }
                            if (j - 1 >=0)
                            {
                                field[i, j - 1].Content = field[i, j].Content;
                                field[i, j].Content = null;
                                continue;
                            }
                        }
                    }
                }
            }
            if(e.Key == Key.A || e.Key == Key.S || e.Key == Key.W || e.Key == Key.D) GenPlate();
            if (Convert.ToInt32(Score.Text) > Convert.ToInt32(highscore.Text))
            {
                highscore.Text = Score.Text;
            }
        }

        private void HS_Check(object sender, EventArgs e)
        {
            if(Convert.ToInt32(highscore.Text)>Convert.ToInt32(hs))
            {
                using (StreamWriter sw = new StreamWriter("highscore.txt", false))
                {
                    hs = highscore.Text;
                    sw.Write(hs);
                }
            }
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    field[i, j].Content = null;
                }
            }
            GenPlate();
            Score.Text = "0";
        }
    }
}
