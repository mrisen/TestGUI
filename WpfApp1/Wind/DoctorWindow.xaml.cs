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

namespace WpfApp1.Wind
{
    /// <summary>
    /// Логика взаимодействия для DoctorWindow.xaml
    /// </summary>
    public partial class DoctorWindow : Window
    {
        public DoctorWindow()
        {
            InitializeComponent();
        }
        private void DragAdminWin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)//для перемещения окна
        {
            DragMove();
        }

        private void AdminClose_Click(object sender, RoutedEventArgs e)//закрыть окно
        {
            this.Close();
        }

        private void ChangeAcc_Click(object sender, RoutedEventArgs e)//поменять акк
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
        private void MinimizedWin_CLick(object sender, RoutedEventArgs e)//кнопка свернуть окно
        {
            this.WindowState = WindowState.Minimized;
        }



        private void HelpBut_Click(object sender, RoutedEventArgs e)//кнопка помощь в pop up
        {

        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Timetable_CLick(object sender, RoutedEventArgs e)//кнопка вызова расписания
        {
        }

        private void Service_Click(object sender, RoutedEventArgs e)//кнопка перехода на страницу с услугами
        {
        }
        private void HomePage_Click(object sender, RoutedEventArgs e)//кнопка перехода на главную страницу
        {
           
        }
    }
}
