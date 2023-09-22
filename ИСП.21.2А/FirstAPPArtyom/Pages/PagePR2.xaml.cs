using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для PagePR2.xaml
    /// </summary>
    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ввод исходных данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double q = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);
            double k;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Карпов А.М.");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"Y={q}");
            lstResult.Items.Add($"Z={z}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (Math.Abs(x * q) > 10) k = Math.Log(Math.Abs(Math.Sin(x)) + Math.Abs(q));
                    else if (Math.Abs(x * q) < 10) k = Math.Exp(Math.Sin(x) + q);
                    else  k = Math.Sin(x) + q;
                    lstResult.Items.Add($"Результат k={Math.Round(k, 3)}");
                    break;
                case 1:
                    if (Math.Abs(x * q) > 10) k = Math.Log(Math.Abs(Math.Pow(x, 2)) + Math.Abs(q));
                    else if (Math.Abs(x * q) < 10) k = Math.Exp(Math.Pow(x, 2) + q);
                    else  k = Math.Pow(x, 2) + q;
                    lstResult.Items.Add($"Результат k={Math.Round(k, 3)}");
                    break;
                case 2:
                    if (Math.Abs(x * q) > 10) k = Math.Log(Math.Abs(Math.Exp(x)) + Math.Abs(q));
                    else if (Math.Abs(x * q) < 10) k = Math.Exp(Math.Exp(x) + q);
                    else  k = Math.Exp(x) + q;
                    lstResult.Items.Add($"Результат k={Math.Round(k, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }




        }
        /// <summary>
        /// Очистить поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            lstResult.Items.Clear();
        }

    }
}
