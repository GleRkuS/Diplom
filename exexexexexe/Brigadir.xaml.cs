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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace exexexexexe
{
    public partial class Brigadir : System.Windows.Window //Эта может паламать
    {
        public Brigadir()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            DG1.ItemsSource = DataBase.context.GGG_Zadanie_Rabochi.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Получите выбранную строку из DataGrid
            var selectedRow = DG1.SelectedItem as GGG_Zadanie_Rabochi;

            // Создайте экземпляр формы BrigIzm
            BrigIzm brigIzm = new BrigIzm();

            // Проверьте, что значение Data_Naznacheniya не равно null
            DateTime dataNaznacheniya = selectedRow.Data_naznacheniya ?? DateTime.MinValue;

            // Передайте выбранные данные в TextBox на форме BrigIzm
            brigIzm.SetTextBoxValues(selectedRow.Nazvanie, selectedRow.Status, dataNaznacheniya);

            // Отобразите форму BrigIzm
            brigIzm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Impart(object sender, RoutedEventArgs e)
        {
            // Создайте новый экземпляр приложения Excel
            Excel.Application excelApp = new Excel.Application();

            // Добавьте новую рабочую книгу
            Excel.Workbook workbook = excelApp.Workbooks.Add();

            // Получите активный лист
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // Получите количество строк и столбцов в DataGrid
            int rowsCount = DG1.Items.Count;
            int columnsCount = DG1.Columns.Count;

            // Запишите заголовки столбцов в Excel
            for (int columnIndex = 0; columnIndex < columnsCount; columnIndex++)
            {
                DataGridColumn column = DG1.Columns[columnIndex];
                worksheet.Cells[1, columnIndex + 1] = column.Header;
            }

            // Запишите данные из DataGrid в Excel
            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < columnsCount; columnIndex++)
                {
                    DataGridColumn column = DG1.Columns[columnIndex];
                    object cellValue = null;

                    // Проверьте, является ли содержимое ячейки TextBlock
                    if (column.GetCellContent(DG1.Items[rowIndex]) is TextBlock textBlock)
                    {
                        cellValue = textBlock.Text;
                    }
                    else
                    {
                        cellValue = column.GetCellContent(DG1.Items[rowIndex])?.ToString();
                    }

                    worksheet.Cells[rowIndex + 2, columnIndex + 1] = cellValue;
                }
            }

            // Сохраните рабочую книгу
            string filePath = @"Отчёт по Заданиям.xlsx";
            workbook.SaveAs(filePath);
           

            // Закройте приложение Excel
            excelApp.Quit();
        }
    }
}
