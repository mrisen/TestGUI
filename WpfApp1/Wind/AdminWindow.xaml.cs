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
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }
        #region =Menu=
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

        private void MinimizedWin_Click(object sender, RoutedEventArgs e)//свернуть
        {
            this.WindowState = WindowState.Minimized;
        }
        #endregion

        #region=PopUp=
        private void HelpBut_Click(object sender, RoutedEventArgs e)
        {
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
        }
        #endregion

        #region =Кнопки работы c DataBase=
        private void Insert_Click(object sender, RoutedEventArgs e)//подтвердить
        {
        }

        public void Display_Data() //показ DataBase [USER]
        {
           
        }

        private void Refuse_Click(object sender, RoutedEventArgs e)//обновить DB
        {
           
        }

        private void Delete_CLick(object sender, RoutedEventArgs e)//удалить запись
        {
        }

        private void Update_Click(object sender, RoutedEventArgs e)//изменить запись
        {
           
        }

        private void SearchLog_Click(object sender, RoutedEventArgs e)//поиск по логину
        {
           
        }


        #endregion

        #region =Doctor=
        private void InsertDoctor_Click(object sender, RoutedEventArgs e)//добавление доктора
        {
          
        }
        #endregion
    }
}
