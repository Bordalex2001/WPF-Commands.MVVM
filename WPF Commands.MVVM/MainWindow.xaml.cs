using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Commands.MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateColorRectangle()
        {
            string redSliderValue, greenSliderValue, blueSliderValue, alphaSliderValue;
            byte redByteValue, greenByteValue, blueByteValue, alphaByteValue;

            redSliderValue = textBoxRed.Text;
            byte.TryParse((string)redSliderValue, out redByteValue);
            greenSliderValue = textBoxGreen.Text;
            byte.TryParse((string)greenSliderValue, out greenByteValue);
            blueSliderValue = textBoxBlue.Text;
            byte.TryParse((string)blueSliderValue, out blueByteValue);
            byte.TryParse(alphaSliderValue, out alphaByteValue);
            //alphaSliderValue = 
            
            // Update the colour of the rectangle
            Rect.Fill = new SolidColorBrush(Color.FromRgb(redByteValue, greenByteValue, blueByteValue));
        }

        private void redSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
