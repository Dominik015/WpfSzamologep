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

namespace WpfApp1
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

        private void btnOsszead_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtEredmeny.Content = Convert.ToDouble(txtA.Text) + Convert.ToDouble(txtB.Text);
            }
            catch (FormatException FormEx)
            {
                MessageBox.Show(FormEx.Message);

            }
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtEredmeny.Content = Convert.ToDouble(txtA.Text) - Convert.ToDouble(txtB.Text);
            }
            catch (FormatException FormEx)
            {
                MessageBox.Show(FormEx.Message);
            }
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtEredmeny.Content = Convert.ToDouble(txtA.Text) * Convert.ToDouble(txtB.Text);
            }
            catch (FormatException FormEx)
            {
                MessageBox.Show(FormEx.Message);
            }
        }

        private void btnOsztas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtEredmeny.Content = Convert.ToDouble(txtA.Text) / Convert.ToDouble(txtB.Text);
            }
            catch (FormatException FormEx)
            {
                MessageBox.Show(FormEx.Message);
            }
        }
    }
}