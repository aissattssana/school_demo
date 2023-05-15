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

namespace school_demo
{
    /// <summary>
    /// Логика взаимодействия для Zapis.xaml
    /// </summary>
    public partial class Zapis : Window
    { public User2Context us = new User2Context();

        public Zapis()
        {
            InitializeComponent();
            ZapisGrid.ItemsSource = us.ClientServices.OrderBy(x=>x.Start).ToList();
        }

        private void ZapisGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }
    }
}
