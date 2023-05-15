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
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void katalog_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }

        private void admin_Click(object sender, RoutedEventArgs e)
        {
            if (code.Text == "0000")
            {
                MainWindow m = new MainWindow(true);
                m.ShowDialog();
            }
            else
                MessageBox.Show("Вы не администратор!");
        }
    }
}
