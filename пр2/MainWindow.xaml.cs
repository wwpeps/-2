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

namespace пр2
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
        public static double a1;
        public static double b1;
        public static double c1;
        public static double a2;
        public static double b2;
        public static double c2;
        public static double x1;
        public static double r1;


        private void tx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            if ((taa.Text == "") || (taw.Text == "") || (tbb.Text == "") || (tbw.Text == "") || (tcc.Text == "") || (tcw.Text == ""))
            {
                trr.Text = "заполни данные балбес";
            }
            else
            {
                a1 = Convert.ToDouble(taa.Text);
                b1 = Convert.ToDouble(tbb.Text);
                c1 = Convert.ToDouble(tcc.Text);
                a2 = Convert.ToDouble(taw.Text);
                b2 = Convert.ToDouble(tbw.Text);
                c2 = Convert.ToDouble(tcw.Text);
                if ((a1 == 0) || (a2 == 0))
                {
                    trr.Text = "на ноль делить нельзя!";

                }
                else
                {
                    r1 = ((c1 * b1) - (c2 * b2)) / ((a1 * b1) - (a2 * b2));
                    trr.Text = r1.ToString();
                }
            }
            
            
        }
    }
}
