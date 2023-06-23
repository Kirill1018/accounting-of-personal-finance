using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
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

namespace accounting_of_personal_finance
{
    /// <summary>
    /// Логика взаимодействия для Expenditures.xaml
    /// </summary>
    public partial class Expenditures : Window
    {
        Expense Expense_1, Expense_2, Expense_3, Expense_4, Expense_5;//расходы
        Addendum Addendum;
        Edition Edition;
        FileStream FileStream;
        StreamWriter StreamWriter;
        private void delete_Click(object sender, RoutedEventArgs e) { exp_grid.SelectedItems.Clear(); }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Edition = new Edition();
            Edition.Show();
            Edition.TextBox.Text = exp_grid.SelectedItem.ToString();
        }

        private async void ok_Click(object sender, RoutedEventArgs e)
        {
            DateTime_1 = new DateTime(2023, 1, 1);
            DateTime_2 = new DateTime(2023, 1, 1);
            DateTime_3 = new DateTime(2023, 1, 1);
            DateTime_4 = new DateTime(2023, 1, 9);
            DateTime_5 = new DateTime(2023, 1, 10);
            Expense_1 = new Expense(DateTime_1, -1700, "метро");
            Expense_2 = new Expense(DateTime_2, -5400, "ресторан");
            Expense_3 = new Expense(DateTime_3, -11300, "водка");
            Expense_4 = new Expense(DateTime_4, -2800, "ремонт автомобиля");
            Expense_5 = new Expense(DateTime_5, +15000, "зарплата");
            using (StreamWriter StreamWriter = File.CreateText(@"мои расходы.json"))
            {
                await StreamWriter.WriteAsync(Expense_1.Date.ToString());
                await StreamWriter.WriteAsync(Expense_1.Changing.ToString());
                await StreamWriter.WriteLineAsync(Expense_1.Cause);
                await StreamWriter.WriteAsync(Expense_2.Date.ToString());
                await StreamWriter.WriteAsync(Expense_2.Changing.ToString());
                await StreamWriter.WriteLineAsync(Expense_2.Cause);
                await StreamWriter.WriteAsync(Expense_3.Date.ToString());
                await StreamWriter.WriteAsync(Expense_3.Changing.ToString());
                await StreamWriter.WriteLineAsync(Expense_3.Cause);
                await StreamWriter.WriteAsync(Expense_4.Date.ToString());
                await StreamWriter.WriteAsync(Expense_4.Changing.ToString());
                await StreamWriter.WriteLineAsync(Expense_4.Cause);
                await StreamWriter.WriteAsync(Expense_5.Date.ToString());
                await StreamWriter.WriteAsync(Expense_5.Changing.ToString());
                await StreamWriter.WriteLineAsync(Expense_5.Cause);
            }
            Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Addendum = new Addendum();
            Addendum.Show();
        }

        DateTime DateTime_1, DateTime_2, DateTime_3, DateTime_4, DateTime_5;//время
        ObservableCollection<Expense> expenses = new ObservableCollection<Expense>();
        public Expenditures()
        {
            InitializeComponent();
            DateTime_1 = new DateTime(2023, 1, 1);
            DateTime_2 = new DateTime(2023, 1, 1);
            DateTime_3 = new DateTime(2023, 1, 1);
            DateTime_4 = new DateTime(2023, 1, 9);
            DateTime_5 = new DateTime(2023, 1, 10);
            Expense_1 = new Expense(DateTime_1, -1700, "метро");
            Expense_2 = new Expense(DateTime_2, -5400, "ресторан");
            Expense_3 = new Expense(DateTime_3, -11300, "водка");
            Expense_4 = new Expense(DateTime_4, -2800, "ремонт автомобиля");
            Expense_5 = new Expense(DateTime_5, +15000, "зарплата");
            expenses.Add(Expense_1);
            expenses.Add(Expense_2);
            expenses.Add(Expense_3);
            expenses.Add(Expense_4);
            expenses.Add(Expense_5);
            exp_grid.DataContext = expenses;
        }
    }
}