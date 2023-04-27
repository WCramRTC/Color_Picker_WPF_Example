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

namespace WPF_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Brush> _brushes;
            InitializeComponent();
            Color mainText = Colors.Wheat;
            Color background = Colors.DarkKhaki;
            //From here we have A Color
            // From Brush To Color
            //Brush brush = new Brush();
            SolidColorBrush solidBrush = new SolidColorBrush(Colors.Lavender);
            Color myColor = Color.FromArgb(255,122,255,44);
            canvas.Background = solidBrush;
        }

        private void btnShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sldR.Value.ToString());
        }

        private void changeColors(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            txtR.Text = sldR.Value.ToString();
            txtG.Text = sldG.Value.ToString();
            txtB.Text = sldB.Value.ToString();

            byte R = (byte)sldR.Value;
            byte G = (byte)sldG.Value;
            byte B = (byte)sldB.Value;

            Color newColor = Color.FromRgb(R, G, B);

            canvas.Background = new SolidColorBrush(newColor);


        }

        private void btnDisplayColor_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
