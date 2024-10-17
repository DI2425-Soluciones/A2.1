using System.Security.Cryptography.X509Certificates;
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

namespace A2._1._1_AdivinaNumero
{
    public partial class MainWindow : Window
    {
        private int numeroAleatorio;
        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = GeneraAleatorio(100);
        }

        public static int GeneraAleatorio(int maximo)
        {
            Random rnd = new Random();
            return rnd.Next(0, maximo);
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse(numeroTextBox.Text) < numeroAleatorio)
                resultadoTextBlock.Text = "Escribe un número mayor";
            else if (Int32.Parse(numeroTextBox.Text) > numeroAleatorio)
                resultadoTextBlock.Text = "Escribe un número menor";
            else
                resultadoTextBlock.Text = "¡Has acertado!";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = GeneraAleatorio(100);
            resultadoTextBlock.Text = "";
            resultadoTextBlock.Text = "¡Vuelve a intentarlo!";

        }
    }
}