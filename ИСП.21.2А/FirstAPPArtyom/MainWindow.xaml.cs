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

namespace FirstAPPPolina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Classes.ClassFrame.frmObj = FrmMain;

            //переход на страницу авторизации
            Classes.ClassFrame.frmObj.Navigate(new Pages.PageAuthorisation());
        }

        private void BtnHello_Click(object sender, RoutedEventArgs e)
        {
            //Диалоговое окно сообщения
            MessageBox.Show("Добро пожаловать!");
        }

        private void BtnPagePR2_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();

            Classes.ClassFrame.frmObj = FrmMain;

            //переход на страницу 2
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR2());
        }

        private void BtnPagePR3_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();

            Classes.ClassFrame.frmObj = FrmMain;

            //переход на страницу 3
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR3());
        }

        private void BtnPagePR7_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();

            Classes.ClassFrame.frmObj = FrmMain;

            //переход на страницу 4
            Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR7());
        }
    }
}
