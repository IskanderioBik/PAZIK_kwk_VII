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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            int K = int.Parse(AA.Text);
            switch (K)
            {
                case 5: Rez.Text = "Ответ: Отлично"; break;
                case 4: Rez.Text = "Ответ: Хорошо"; break;
                case 3: Rez.Text = "Ответ: Удовлетворительно"; break;
                case 2: Rez.Text = "Ответ: Неудовлетворительно"; break;
                case 1: Rez.Text = "Ответ: Плохо"; break;
                default: Rez.Text = "Ответ: Ошибка"; break;
            }
        }
    }
}
