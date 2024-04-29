using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Commands.MVVM
{
    internal class ColorItem
    {
        public Color Color { get; set; }
        public SolidColorBrush ColorBrush => new SolidColorBrush(Color);
        public string HexAlpha => $"#{Color.R:X2}{Color.G:X2}{Color.B:X2}{Color.A:X2}";
    }
}