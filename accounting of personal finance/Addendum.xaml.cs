using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace accounting_of_personal_finance
{
    /// <summary>
    /// Логика взаимодействия для Addendum.xaml
    /// </summary>
    public partial class Addendum : Window
    {
        public Addendum()
        {
            InitializeComponent();
        }
        DateTime DateTime;
        Expense Expense;
        Expenditures Expenditures;
        ObservableCollection<Expense> charges = new ObservableCollection<Expense>();
        private void addition_Click(object sender, RoutedEventArgs e)
        {
            DateTime time = Convert.ToDateTime(_date.Text);
            DateTime = new DateTime(time.Year, time.Month, time.Day);
            int shift = Convert.ToInt32(bal_chang.Text);
            string ground = reason.Text;
            Expense = new Expense(time, shift, ground);
            charges.Add(Expense);
            Expenditures = new Expenditures();
            Expenditures.exp_grid.DataContext = charges;
            Close();
        }
    }
}