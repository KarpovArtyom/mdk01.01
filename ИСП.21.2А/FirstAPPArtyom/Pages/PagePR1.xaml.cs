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
    /// Логика взаимодействия для PagePR1.xaml
    /// </summary>
    public partial class PagePR1 : Page
    {
        public PagePR1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtX.Text);
            double y = Convert.ToDouble(TxtY.Text);
            double z = Convert.ToDouble(TxtZ.Text);

            double b = Math.Pow(y, Math.Pow(Math.Abs(x), 0.33)) + Math.Cos(y) * Math.Cos(y) * Math.Cos(y) * (Math.Abs(x - y) * (1 + (Math.Sin(z) * Math.Sin(z)) / (Math.Sqrt(x + y)))) / (Math.Exp(Math.Abs(x - y)) + (x / 2));
         LstResult.Items.Add("ПР№1 ИСП.21.2А Горшкова,Ерова");
         LstResult.Items.Add($"x={x}");
         LstResult.Items.Add($"x={y}");
         LstResult.Items.Add($"x={z}");
         LstResult.Items.Add($"Результат b={b}");
        }
    }
}
