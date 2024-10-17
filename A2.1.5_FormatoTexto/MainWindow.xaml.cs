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

namespace A2._1._5_FormatoTexto
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
        
        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textoFormatoTextBlock != null)
                textoFormatoTextBlock.Text = textoTextBox.Text;
        }

        // Cambiar negrita del texto.
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (textoFormatoTextBlock != null)
                textoFormatoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (textoFormatoTextBlock != null)
                textoFormatoTextBlock.FontWeight = FontWeights.Normal;
        }

        // Cambiar cursiva del texto.
        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (textoFormatoTextBlock != null)
                textoFormatoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (textoFormatoTextBlock != null)
                textoFormatoTextBlock.FontStyle = FontStyles.Normal;
        }

        // Cambiar el color del texto.
        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(textoFormatoTextBlock != null)
                textoFormatoTextBlock.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textoFormatoTextBlock != null) 
                textoFormatoTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textoFormatoTextBlock != null)
                textoFormatoTextBlock.Foreground = Brushes.Green;
        }
    }
}