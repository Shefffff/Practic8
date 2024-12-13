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

namespace Practic8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); Window1 pas = new Window1();
           pas.ShowDialog();
            if (Window1.acsess)
            {
                this.Close();
            }
           
        }
        public void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу выполнил Алексей Алесеевич", "О программе ", MessageBoxButton.OK,MessageBoxImage.Asterisk);
        }


    }

}