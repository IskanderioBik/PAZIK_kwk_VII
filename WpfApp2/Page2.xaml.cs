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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(AA.Text);
            Rez.Text = "Возвраст: ";
            switch (A / 10)
            {
                case 2: Rez.Text += "двадцать "; break;
                case 3: Rez.Text += "тридцать "; break;
                case 4: Rez.Text += "сорок "; break;
                case 5: Rez.Text += "пятдесят "; break;
                case 6: Rez.Text += "шестьдесят "; break;
            }
            switch (A % 10)
            {
                case 1: Rez.Text += "один "; break;
                case 2: Rez.Text += "два "; break;
                case 3: Rez.Text += "три "; break;
                case 4: Rez.Text += "четыре "; break;
                case 5: Rez.Text += "пять "; break;
                case 6: Rez.Text += "шесть "; break;
                case 7: Rez.Text += "семь "; break;
                case 8: Rez.Text += "восемь "; break;
                case 9: Rez.Text += "девять "; break;
            }
            switch (A % 10)
            {
                case int t when t >= 5 && t <= 9 || t == 0: Rez.Text += "лет."; break;
                case 1: Rez.Text += "год."; break;
                default: Rez.Text += "года."; break;
            }
        }
    }
}
