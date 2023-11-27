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
using static System.Math;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double a, r1, r2, s;

            int n = int.Parse(BB.Text);
            double x = double.Parse(AA.Text);
            switch (n)
            {
                case 1:
                    a = x;
                    r1 = a * Sqrt(3) / 6;
                    r2 = 2 * r1;
                    s = a * a * Sqrt(3) / 4;
                    Rez.Text += $"Гипотенуза {r1} Высота {r2} Площадь {s}";
                    break;
                case 2:
                    r1 = x;
                    a = r1 * 6 / Sqrt(3);
                    r2 = 2 * r1;
                    s = a * a * Sqrt(3) / 4;
                    Rez.Text += $"Катет {a} Высота {r2} Площадь {s}";
                    break;
                case 3:
                    r2 = x;
                    r1 = r2 / 2;
                    a = r1 * 6 / Sqrt(3);
                    s = a * a * Sqrt(3) / 4;
                    Rez.Text += $"Катет {a} Гипотенуза {r1} Площадь {s}";
                    break;
                case 4:
                    s = x;
                    a = Sqrt(s * 4 / Sqrt(3));
                    r1 = a * Sqrt(3) / 6;
                    r2 = 2 * r1;
                    Rez.Text += $"Катет {a} Гипотенуза {r1} Высота {r2}";
                    break;
            }
        }
    }
}
