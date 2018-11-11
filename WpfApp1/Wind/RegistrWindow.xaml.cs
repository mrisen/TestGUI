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
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
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
        }
        private void MinimizedWin_CLick(object sender, RoutedEventArgs e)//кнопка свернуть окно
        {
            this.WindowState = WindowState.Minimized;
        }


        #region=PopUp=

        private void HelpBut_Click(object sender, RoutedEventArgs e)//кнопка помощь в pop up
        {
          
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
        #endregion

        #region=MainButtons=
        private void Timetable_CLick(object sender, RoutedEventArgs e)//кнопка вызова расписания
        {
        }

        private void Client_Click(object sender, RoutedEventArgs e)//кнопка перехода на клиенты страницу
        {
        }

        private void Service_Click(object sender, RoutedEventArgs e)//кнопка перехода на страницу с услугами
        {
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)//кнопка перехода на главную страницу
        {
        }
        #endregion

        TimeSpan Conver(string durab)
        {
            TimeSpan timedurab = new TimeSpan(0, 0, 0);
            switch (durab)
            {
                case "10 мин":
                    timedurab = new TimeSpan(0, 10, 0);
                    break;
                case "20 мин":
                    timedurab = new TimeSpan(0, 20, 0);
                    break;
                case "30 мин":
                    timedurab = new TimeSpan(0, 30, 0);
                    break;
                case "40 мин":
                    timedurab = new TimeSpan(0, 40, 0);
                    break;
                case "50 мин":
                    timedurab = new TimeSpan(0, 50, 0);
                    break;
                case "60 мин":
                    timedurab = new TimeSpan(1, 0, 0);
                    break;
                case "90 мин":
                    timedurab = new TimeSpan(1, 30, 0);
                    break;
                case "120 мин":
                    timedurab = new TimeSpan(2, 0, 0);
                    break;
                default:
                    timedurab = new TimeSpan(0, 30, 0);
                    break;
            }
            return timedurab;
        }

        private void RegestrPriem_Click(object sender, RoutedEventArgs e)//кнопка регестрации процедуры
        {
        }
    }
}
