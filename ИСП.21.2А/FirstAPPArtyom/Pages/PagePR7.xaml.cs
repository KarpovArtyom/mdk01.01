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
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
        }
        
        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            lstD.Items.Clear();
            lstE.Items.Clear();
            lstResult.Items.Add("Лаб.раб.№7. Выполнил Карпов А.М.");
            double[] D = { 1.2, 3.4, 5.6, 7.8, 9.0, 2.1, 4.3, 6.5, 8.7, 0.9, 2.3, 4.5, 6.7, 8.9, 1.0, 3.2 };
            double[] E = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };


            for (int i = 0; i < D.Length; i++)
            {
                double f = (2 * D[i] + Math.Sin(E[i])) / D[i];

                if (f > 1 && f < 3)
                {
                    lstResult.Items.Add($"Результат f={Math.Round(f, 3)}");
                }
                lstD.Items.Add($"D(i)={D[i]}");
                lstE.Items.Add($"E(i)={E[i]}");
            }
        }
    }
}
