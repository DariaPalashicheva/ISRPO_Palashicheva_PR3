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

namespace ISRPO_Palashicheva_PR3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            A.Text = "5,5";
            B.Text = "4,3";
            C.Text = "2,8";
            Itog.Text = "Ст. гр. ИСП 402 Палашичева";
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 3";
            //Считывание значения Х
            double a = double.Parse(A.Text);
            //Вывод значения Х в окно
            Itog.Text += Environment.NewLine + "A = " + a.ToString();
            //Считывание значения Y
            double b = double.Parse(B.Text);
            //Вывод значения Y в окно
            Itog.Text += Environment.NewLine + "B = " + b.ToString();
            //Считывание значения Z
            double c = double.Parse(C.Text);
            //Вывод значения Z в окно
            Itog.Text += Environment.NewLine + "C = " + c.ToString();

            //Вычисляем арифметическое выражение
            double m = 0.5 * (Math.Sqrt((2 * (Math.Pow(b, 2)) * (2 * (Math.Pow(c, 2))) - (Math.Pow(a, 2)))));
            
            //Выводим результат в окно
            Itog.Text += Environment.NewLine + "Результат m = " + m.ToString();
        }
    }
}
