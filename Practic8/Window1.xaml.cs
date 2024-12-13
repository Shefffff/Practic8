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
using System.Windows.Shapes;

namespace Practic8
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
      public static  bool acsess { get; set; }
        public Window1()
        {
            InitializeComponent();
            acsess = false;
        }
        private void Window_Activated (object sender, EventArgs e)
        {
            txtPas.Focus();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txtPas.Password == "7535") Close();
            else
            {
                MessageBox.Show("Неверный пароль","Ошибка");
                txtPas.Focus();
            }
        }

        private void btnEsc_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
        }

    }
}
