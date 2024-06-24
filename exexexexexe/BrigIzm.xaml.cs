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
    /// Логика взаимодействия для BrigIzm.xaml
    /// </summary>
    public partial class BrigIzm : Window
    {
        public BrigIzm()
        {
            InitializeComponent();
            
        }
        public void SetTextBoxValues(string nazvanie, string status, DateTime dataNaznacheniya)
        {
            // Установите значения TextBox на форме BrigIzm 
            Nazv.Text = nazvanie;
            nStat.Text = status;
            dKonca.Text = dataNaznacheniya.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получите выбранный статус из ComboBox
            string selectedStatus = (StatusComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Обновите значение статуса в DataGrid
            if (selectedStatus != null)
            {
                // Получите ссылку на предыдущую форму Brigadir
                var brigadirForm = Application.Current.Windows.OfType<Brigadir>().FirstOrDefault();

                // Проверьте, что ссылка не равна null
                if (brigadirForm != null)
                {
                    // Получите выбранную строку из DataGrid на форме Brigadir
                    var selectedRow = brigadirForm.DG1.SelectedItem as GGG_Zadanie_Rabochi;

                    // Измените значение статуса выбранной строки
                    selectedRow.Status = selectedStatus;

                    // Обновите DataGrid на форме Brigadir
                    brigadirForm.DG1.Items.Refresh();
                }
            }

            // Закройте текущую форму BrigIzm
            this.Close();
        }
    }
}
