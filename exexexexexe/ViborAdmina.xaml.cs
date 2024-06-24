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

namespace exexexexexe
{
    /// <summary>
    /// Логика взаимодействия для ViborAdmina.xaml
    /// </summary>
    public partial class ViborAdmina : Window
    {
        public ViborAdmina()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admik2 admin2 = new Admik2();
            admin2.Show();
            this.Close();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Admin admin1 = new Admin();
            admin1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Admik3 admik3 = new Admik3();
            admik3.Show();
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
