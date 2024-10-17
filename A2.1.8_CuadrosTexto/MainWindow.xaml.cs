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

namespace A2._1._8_CuadrosTexto
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

        // Mostrar u ocultar la ayuda de los campos de texto.
        private void AyudaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox campo = sender as TextBox;
            
            if (e.Key == Key.F1)
            {
                if (Equals(campo.Tag, "Nombre"))
                    ayudaNombreTextBlock.Visibility = ayudaNombreTextBlock.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
                else
                    ayudaApellidoTextBlock.Visibility = ayudaApellidoTextBlock.Visibility == Visibility.Visible ? Visibility.Hidden : Visibility.Visible;
            }
        }

        // Validar que el campo de texto de la edad sea un número.

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (Int32.TryParse(edadTextBox.Text, out _))
                {
                    mensajeEdadTextBlock.Visibility = Visibility.Hidden;
                }
                else
                {
                    mensajeEdadTextBlock.Visibility = Visibility.Visible;
                }
            }
        }
    }
}