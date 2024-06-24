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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;


namespace exexexexexe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int CaptchaWidth = 200;
        private const int CaptchaHeight = 80;
        private const int CaptchaFontSize = 40;


        DataBase dataBase = new DataBase();
        Susem_dbEntities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Susem_dbEntities();
            GenerateCaptcha();

        }
        private const int CaptchaLength = 6;
        private void GenerateCaptcha()
        {
            // Генерация случайного текста для капчи
            string captchaText = GenerateRandomText();

            // Отображение капчи в TextBlock элементе
            CaptchaTextBlock.Text = captchaText;
        }

        private string GenerateRandomText()
        {
            // Генерация случайного текста для капчи
            Random rnd = new Random();
            int capcha = rnd.Next(1000, 9999);
            CaptchaTextBlock.Text = Convert.ToString(capcha);
            StringBuilder captchaBuilder = new StringBuilder();
            for (int i = 0; i < CaptchaLength; i++)
            {
                captchaBuilder.ToString();
            }
            return captchaBuilder.ToString();
        }



        private void log_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void voiti(object sender, RoutedEventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryRab = $"select * from GGG_Users where login = '" + log.Text + "' and password = '" + pass.Password + "' and role = 'Работник'";
            string queryAdm = $"select * from GGG_Users where login = '" + log.Text + "' and password = '" + pass.Password + "' and role = 'Админ'";
            string queryBri = $"select * from GGG_Users where login = '" + log.Text + "' and password = '" + pass.Password + "' and role = 'Бригадир'";

            var user = db.GGG_Users.FirstOrDefault(item => item.Login == log.Text &&  item.Password == pass.Password);
            if (log.Text != "")
            {
                if (pass.Password != "")
                {
                    if (CaptchaTextBlock.Text != "")
                    {
                        if (Capch.Text == CaptchaTextBlock.Text)
                        { 
                            if (user != null)
                            {
                                if (user.role == "Работник") 
                                {
                                    MessageBox.Show("Вы вошли как Рабочий");
                                    Client Client = new Client();
                                    Client.Show();
                                    this.Hide();
                                }
                                else if (user.role == "Админ") 
                                {
                                    MessageBox.Show("Вы вошли как Админ");
                                    ViborAdmina ViborAdmina = new ViborAdmina();
                                    ViborAdmina.Show();
                                    this.Hide();
                                }
                                else if (user.role == "Бригадир") 
                                {
                                    MessageBox.Show("Вы вошли как Бригадир");
                                    Brigadir Brigadir = new Brigadir();
                                    Brigadir.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Такого пользователя не существует");
                                }
                            }
                        }
                        else MessageBox.Show("Ошибка! Капча введена с ошибкой"); return;
                    }
                    else MessageBox.Show("Ошибка! Капча не введена"); return;

                }
                else MessageBox.Show("Ошибка! Не введён пароль"); return;
            }
            else MessageBox.Show("Ошибка! Не введён логин"); return;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int capcha = rnd.Next(1000, 9999);
            CaptchaTextBlock.Text = Convert.ToString(capcha);
        }
    }
}