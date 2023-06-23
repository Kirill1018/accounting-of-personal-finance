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
    /// Логика взаимодействия для Infograph.xaml
    /// </summary>
    public partial class Infograph : Window
    {
        ObservableCollection<Summ_table> tables = new ObservableCollection<Summ_table>();
        public Infograph()
        {
            InitializeComponent();
            Summ_table_1 = new Summ_table("янв", 23000, 11500, 0);
            Summ_table_2 = new Summ_table("фев", 20000, 11800, 0);
            Summ_table_3 = new Summ_table("мар", 19000, 10500, 0);
            Summ_table_4 = new Summ_table("апр", 24500, 9500, 0);
            Summ_table_5 = new Summ_table("май", 22600, 8200, 0);
            Summ_table_6 = new Summ_table("июн", 18000, 11600, 0);
            Summ_table_7 = new Summ_table("июл", 0, 0, 0);
            Summ_table_8 = new Summ_table("авг", 14000, 9800, 0);
            Summ_table_9 = new Summ_table("сен", 15600, 4500, 0);
            Summ_table_10 = new Summ_table("окт", 17200, -3000, 0);
            Summ_table_11 = new Summ_table("ноя", 13000, -3500, 0);
            Summ_table_12 = new Summ_table("дек", 11000, 6700, 0);
            //Summ_table = new Summ_table("всего", Summ_table.sum, Summ_table.amount, 0);
            tables.Add(Summ_table_1);
            tables.Add(Summ_table_2);
            tables.Add(Summ_table_3);
            tables.Add(Summ_table_4);
            tables.Add(Summ_table_5);
            tables.Add(Summ_table_6);
            tables.Add(Summ_table_7);
            tables.Add(Summ_table_8);
            tables.Add(Summ_table_9);
            tables.Add(Summ_table_10);
            tables.Add(Summ_table_11);
            tables.Add(Summ_table_12);
            //tables.Add(Summ_table);
            DataGrid.DataContext = tables;
        }
        Summ_table Summ_table_1, Summ_table_2, Summ_table_3, Summ_table_4, Summ_table_5, Summ_table_6, Summ_table_7, Summ_table_8, Summ_table_9, Summ_table_10, Summ_table_11, Summ_table_12;//сводные таблицы
        private void Button_Click(object sender, RoutedEventArgs e) { Close(); }
    }
}