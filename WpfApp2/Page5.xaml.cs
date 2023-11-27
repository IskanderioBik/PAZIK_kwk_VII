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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }
        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double p = double.Parse(AA.Text);
            int d = 1;
            double km = 10;
            double tk = km;

            while (tk <= 200)
            {
                km += km * p / 100;
                tk += km;
                d++;
            }
            Rez.Text = $"За {d} дней он пробежал 200км, в общем лыжник пробежал {tk:f1} км";
        }
    }
}
