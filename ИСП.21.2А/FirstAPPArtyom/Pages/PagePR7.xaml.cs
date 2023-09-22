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
            int [] D = { };
            int [] E = { };
            int f;
            lstResult.Items.Add("Лаб.раб.№7. Выполнил Карпов А.М.");
            for (int i = 0; i <= 17; i = i + 1) ;
            {
                f(i) = (2 * D(i) + Math.Sin(E(i))) / D(i);
            }

        }
    }
}
