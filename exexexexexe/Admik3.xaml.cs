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
using System.Collections.ObjectModel;

namespace exexexexexe
{
    /// <summary>
    /// Логика взаимодействия для Admik3.xaml
    /// </summary>
    public partial class Admik3 : Window
    {

        
        private ObservableCollection<GGG_Brigadir> dataItems;

        public Admik3()
        {
            InitializeComponent();
            Load();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не все поля запонены");
        }










        private void Load()
        {
            DG1.ItemsSource = DataBase.context.GGG_Brigadir.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void change(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViborAdmina admin4 = new ViborAdmina();
            admin4.Show();
            this.Close();
        }

        private void deltite(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Бригадир не выбран");
        }
    }
}
