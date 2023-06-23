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

namespace accounting_of_personal_finance
{
    /// <summary>
    /// Логика взаимодействия для Edition.xaml
    /// </summary>
    public partial class Edition : Window
    {
        public Edition()
        {
            InitializeComponent();
        }
        Expenditures Expenditures;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Expenditures = new Expenditures();
            Expenditures.exp_grid.SelectedItem = TextBox.Text;
            Close();
        }
    }
}