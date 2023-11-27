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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(AA.Text);
            double sum = 0;
            int n = 0;

            while (N > 0)
            {
                sum += N % 10;
                N /= 10;
                n++;
            }
            Rez.Text = $"Сумма чисел {sum} Количество чисел {n}";
        }
    }
}
