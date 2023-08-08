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
using System.Windows.Shapes;

namespace WpfApp1project_food_fantacy_final
{
    /// <summary>
    /// Interaction logic for PromoPacks.xaml
    /// </summary>
    public partial class PromoPacks : Window
    {
        public PromoPacks()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int p1 = 300;
            payment pay = new payment(p1);
            this.Hide();
        }

        private void Button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            int p2 = 500;
            payment pay = new payment(p2);
            this.Hide();
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            int p3 = 800;
            payment pay = new payment(p3);
            this.Hide();
        }

        private void Button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int p4 = 2300;
            payment pay = new payment(p4);
            this.Hide();
        }

        private void Button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int p5 = 500;
            payment pay = new payment(p5);
        }
    }
}
