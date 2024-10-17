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

namespace A2._1._4_CaracteresLimitados
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

        private void CaracteresTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int ncharacters = caracteresTextBox.Text.Length;
            numcaractTextBlock.Text = $"{ncharacters}/140";
            if (ncharacters == 140) caracteresTextBox.IsReadOnly = true;
        }
    }
}