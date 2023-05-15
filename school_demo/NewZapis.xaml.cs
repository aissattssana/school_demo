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
    /// Логика взаимодействия для NewZapis.xaml
    /// </summary>
    public partial class NewZapis : Window
    {public User2Context us = new User2Context();
        Service ser = new Service();
        public NewZapis(Service ser = null)
        {
            InitializeComponent();
            this.ser = ser;
            ser_name.Content = ser.Name;
            ser_during.Content = ser.Duration;
            client.ItemsSource = us.Clients.ToList();
        }

        private void make_zap_Click(object sender, RoutedEventArgs e)
        {
            var clientt = us.Clients.Where(c => c.Name == client.Text).FirstOrDefault();
            ClientService cs = new ClientService { 
                ServiceId = ser.ServiceId, 
                ServiceName = ser.Name, 
                Start = Convert.ToDateTime(data_table.Text),
                ClientName=client.Text, 
                ClientId=((Client)(client.SelectedItem)).ClientId };
            us.ClientServices.Add(cs);
            us.SaveChanges();
            MessageBox.Show("Записано");

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }
    }
}
