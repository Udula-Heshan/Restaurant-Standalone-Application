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
    /// Interaction logic for home_menuWindow2.xaml
    /// </summary>
    public partial class home_menuWindow2 : Window
    {
        public home_menuWindow2()
        {
            InitializeComponent();
        }

        private void Button1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            BeveragesWindow2 Drink = new BeveragesWindow2();
            Drink.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            icacream Icecream = new icacream();
            Icecream.Show();
            this.Hide();
        }

        private void Button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            puddings Pudding = new puddings();
            Pudding.Show();
            this.Hide();
        }

        private void Button1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Burger Burger = new Burger();
            Burger.Show();
            this.Hide();
        }

        private void Button1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Pizza Pizza = new Pizza();
            Pizza.Show();
            this.Hide();
        }
    }
}
