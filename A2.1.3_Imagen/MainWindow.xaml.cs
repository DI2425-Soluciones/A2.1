using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A2._1._3_Imagen
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

        // PARA CAMBIAR LA OPACIDAD DE LA IMAGEN.
        private void AltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Opacity = 1;
        }

        private void MediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Opacity = 0.6;
        }

        private void BajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Opacity = 0.3;
        }


        // PARA RELLENAR LA IMAGEN.
        private void FillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Stretch = Stretch.Fill;
        }

        private void UniformRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Stretch = Stretch.Uniform;
        }

        private void UniformToFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Stretch = Stretch.UniformToFill;
        }

        private void NoneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cartelImage.Stretch = Stretch.None;
        }
    }
}