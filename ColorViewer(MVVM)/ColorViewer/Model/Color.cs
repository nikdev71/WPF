using ColorViewer.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace ColorViewer.Model
{
    internal class MyColor
    {
        public string Name {  get; set; }
        public MyColor(System.Drawing.Color c)
        {
            Name = "#" + c.A.ToString("X2") + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

    }
}
