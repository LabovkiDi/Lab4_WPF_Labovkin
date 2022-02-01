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

namespace Lab4_WPF_Labovkin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate1Euro = Convert.ToDouble(rate1.Text);
            double sum1Euro = Convert.ToDouble(sum1.Text);
            double res1Double = rate1Euro * sum1Euro;
            resSum1.Text = res1Double.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate2Grivna = Convert.ToDouble(rate2.Text);
            double sum2Grivna = Convert.ToDouble(sum2.Text);
            double res2Double = rate2Grivna * sum2Grivna;
            resSum2.Text = res2Double.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate3AMD = Convert.ToDouble(rate3.Text);
            double sum3AMD = Convert.ToDouble(sum3.Text);
            double res3Double = rate3AMD * sum3AMD;
            resSum3.Text = res3Double.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double lengthInch = Convert.ToDouble(length.Text);
            double resultDouble = 0.0254 * lengthInch;
            result.Text = resultDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            const double foot = 0.3048;
            double length1foot = Convert.ToDouble(length1.Text);
            double result1Double = foot * length1foot;
            result1.Text = result1Double.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            const double miles = 1609.34;
            double length2miles = Convert.ToDouble(length2.Text);
            double result2Double = miles * length2miles;
            result2.Text = result2Double.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            const double layout = 1066.8;
            double length3layout = Convert.ToDouble(length3.Text);
            double result3Double = layout * length3layout;
            result3.Text = result3Double.ToString();
        }
    }
}
