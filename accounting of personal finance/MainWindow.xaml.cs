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
using Newtonsoft.Json;

namespace accounting_of_personal_finance
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Expenditures Expenditures;
        Infograph Infograph;
        private void inc_and_exp_Click(object sender, RoutedEventArgs e)
        {
            Expenditures = new Expenditures();
            Expenditures.Show();
        }

        private void infographics_Click(object sender, RoutedEventArgs e)
        {
            Infograph = new Infograph();
            Infograph.Show();
        }

        private void exit_Click(object sender, RoutedEventArgs e) { Close(); }
    }
}