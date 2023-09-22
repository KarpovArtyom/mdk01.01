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

namespace FirstAPPPolina.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAuthorisation.xaml
    /// </summary>
    public partial class PageAuthorisation : Page
    {
        public PageAuthorisation()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            string login = TxtLogin.Text;
            string password = PsbPassword.Password;
            if (login.ToLower() == "student")
            {
                if (password == "1")
                {
                    MessageBox.Show("Выполнен вход");
                    Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR1());
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Не выполнен вход");
            }
        }
    }
}
