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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double X0 = double.Parse(txtX0.Text);
            double Xk = double.Parse(txtXk.Text);
            double Dx = double.Parse(txtDx.Text);
            double A = double.Parse(txtA.Text);
            lstResult.Items.Add("Лаб.раб.№3. Выполнил Карпов А.М.");
            double y = 0;
            {
                for (double i = X0; i <= Xk; i = i + Dx)
                {
                    y = i * Math.Sin(Math.Sqrt(i + A - 0.0084));
                    lstResult.Items.Add($"Результат x={Math.Round(i, 3)}");
                    lstResult.Items.Add($"Результат y={Math.Round(y, 3)}");
                }
            }
        }
    }
}
