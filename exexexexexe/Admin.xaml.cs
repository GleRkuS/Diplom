using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;


namespace exexexexexe
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            DG1.ItemsSource = DataBase.context.GGG_Users.ToList();
        }




        private void add(object sender, RoutedEventArgs e)
        {
            // Получите значения из TextBox и ComboBox
            string login = Login.Text;
            string password = Password.Text;
            string role = (Role.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Проверьте, что TextBox не пустой
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введите логин");
                return;
            }

            // Проверьте, что пользователь с таким логином не существует
            if (DataBase.context.GGG_Users.Any(u => u.Login == login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }

            // Создайте новый объект User
            GGG_Users newUser = new GGG_Users()
            {
                Login = login,
                Password = password,
                role = role
            };

            // Добавьте нового пользователя в базу данных
            DataBase.context.GGG_Users.Add(newUser);
            DataBase.context.SaveChanges();

            // Обновите DataGrid
            DG1.ItemsSource = DataBase.context.GGG_Users.ToList();
        }

        private void change(object sender, RoutedEventArgs e)
        {
            
        }

        
        public class User
        {
            public string Login { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViborAdmina admin4 = new ViborAdmina();
            admin4.Show();
            this.Close();
        }

        private void Delite(object sender, RoutedEventArgs e)
        {
            // Получите выбранную строку из DataGrid
            GGG_Users selectedUser = DG1.SelectedItem as GGG_Users;

            // Проверьте, что строка была выбрана
            if (selectedUser == null)
            {
                MessageBox.Show("Выберите пользователя для удаления");
                return;
            }
            


            // Удалите выбранного пользователя из базы данных
            DataBase.context.GGG_Users.Remove(selectedUser);
            DataBase.context.SaveChanges();

            // Обновите DataGrid
            DG1.ItemsSource = DataBase.context.GGG_Users.ToList();
        }



        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Включите кнопку "Удалить" только при выборе строки в DataGrid
            if (DG1.SelectedItem != null)
            {
                
            }
            else
            {
                
            }
        }
    }
}
