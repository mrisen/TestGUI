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

namespace WpfApp1.Wind
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

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (txt_user.Text=="1")
            {
                AdminWindow admin = new AdminWindow();
                admin.Show();
                this.Close();
            }
            if (txt_user.Text == "2")
            {
                RegistrWindow registr = new RegistrWindow();
                registr.Show();
                this.Close();
            }
            if (txt_user.Text == "3")
            {
                DoctorWindow doctor = new DoctorWindow();
                doctor.Show();
                this.Close();
            }
        }

        private void BorderDrag_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)//для передвижения окна за статусбар
        {
            DragMove();
        }

        private void CloseLog_Click(object sender, RoutedEventArgs e)//закрыть
        {
            Application.Current.Shutdown();
        }

        private void txt_user_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
