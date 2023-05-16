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
    /// Логика взаимодействия для AdminWin.xaml
    /// </summary>
    public partial class AdminWin : Window
    {
        public User2Context User2Context = new User2Context();
        public AdminWin()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            Type a = cost1.Text.GetType();

            if (User2Context.Services.Any(x => x.Name != name1.Text))
            {
                if (Convert.ToInt32(time1.Text) < 14400)
                {
                    Service usl = new Service { Name = name1.Text, Photo = null, Duration = Convert.ToInt32(time1.Text), Cost =Convert.ToDouble(cost1.Text), Discount = Convert.ToInt16(skidka1.Text) };
                    User2Context.Services.Add(usl);
                    User2Context.SaveChanges();
                    MessageBox.Show("Услуга добавлена");
                       }
                else { MessageBox.Show("Продолжительность не может превышать 4 часов(14400 сек)"); }
            }
            else { MessageBox.Show("Такая услуга уже существует"); }
        }
    

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow(true);
            m.ShowDialog();
        }
    }
}
