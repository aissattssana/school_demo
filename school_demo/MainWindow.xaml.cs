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

namespace school_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User2Context us = new User2Context();
        private bool admin_p;
        Service current_serv = new Service();
        public MainWindow( bool Admin = false)
        {
            InitializeComponent();
            ServiceList.ItemsSource = us.Services.ToList();
            admin_p = Admin;
            count.Content = "Найдено:" + ServiceList.Items.Count.ToString();
            if(admin_p == true) { zapis.Visibility = Visibility.Visible; }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            if( admin_p == false) { MessageBox.Show("Вы не являеетесь администратором!");
                return;
            }
            else
            {
                AdminWin newservice = new AdminWin();
                newservice.ShowDialog();
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (admin_p == false)
            {
                MessageBox.Show("Вы не являеетесь администратором!");
                return;
            }
            else
            { var del = (Service)ServiceList.SelectedItem;
                us.Services.Remove(del);
                us.SaveChanges();
                ServiceList.ItemsSource = us.Services.ToList();
                MessageBox.Show("Услуга была успешно удалена!");
            }
        }

        private void redact_Click(object sender, RoutedEventArgs e)
        {
            AdminWin redact_ver = new AdminWin();
            redact_ver.ShowDialog();

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.OrderBy(x => x.Cost).ToList();
            count.Content = "Найдено:" + us.Services.OrderBy(x => x.Cost).Count().ToString();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.OrderByDescending(x => x.Cost).ToList();
            count.Content = "Найдено:" + us.Services.OrderBy(x => x.Cost).Count().ToString();
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.ToList();
            count.Content = "Найдено:" + us.Services.OrderBy(x => x.Cost).Count().ToString();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            ServiceList.ItemsSource = us.Services.Where(x => x.Discount >= 0 && x.Discount < 5).ToList();
            count.Content = "Найдено" + us.Services.Where(x => x.Discount >= 0 && x.Discount < 5).Count().ToString();

        }

        private void ComboBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.Where(x => x.Discount >= 5 && x.Discount < 15).ToList();
            count.Content = "Найдено" + us.Services.Where(x => x.Discount >= 5 && x.Discount < 15).Count().ToString();
        }

        private void ComboBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.Where(x => x.Discount >= 15 && x.Discount < 30).ToList();
            count.Content = "Найдено" + us.Services.Where(x => x.Discount >= 15 && x.Discount < 30).Count().ToString();
        }

        private void ComboBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.Where(x => x.Discount >= 30 && x.Discount < 70).ToList();
            count.Content = "Найдено" + us.Services.Where(x => x.Discount >= 30 && x.Discount < 70).Count().ToString();
        }

        private void ComboBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {

            ServiceList.ItemsSource = us.Services.Where(x => x.Discount >= 70 && x.Discount < 100).ToList();
            count.Content = "Найдено" + us.Services.Where(x => x.Discount >= 70 && x.Discount < 100).Count().ToString();
        }

        private void create_zapis_Click(object sender, RoutedEventArgs e)
        {
            var zapis = (Service)ServiceList.SelectedItem;
            NewZapis nz = new NewZapis(zapis);
            nz.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Enter en = new Enter();
            en.ShowDialog();
        }

        private void exit_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
