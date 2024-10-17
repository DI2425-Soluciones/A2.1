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

namespace A2._1._2_CalculadoraBasica
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

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double operando1 = Double.Parse(operando1TextBox.Text);
                double operando2 = Double.Parse(operando2TextBox.Text);

                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = (operando1 + operando2).ToString();
                        break;
                    case "-":
                        resultadoTextBox.Text = (operando1 - operando2).ToString();
                        break;
                    case "*":
                        resultadoTextBox.Text = (operando1 * operando2).ToString();
                        break;
                    case "/":
                        resultadoTextBox.Text = (operando1 / operando2).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            }

        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            resultadoTextBox.Text = "";
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> operadores = new List<string> { "+", "-", "*", "/" };

            calcularButton.IsEnabled = operadores.Contains(operadorTextBox.Text);
        }
    }
}