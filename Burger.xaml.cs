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
    /// Interaction logic for Burger.xaml
    /// </summary>
    public partial class Burger : Window
    {
        public Burger()
        {
            InitializeComponent();
        }
        Calculate cal = new Calculate();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;
            if (checkBox.IsChecked == true)
            {
                try
                {
                    if (txt_burger.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(800, txt_burger.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Valid Quentity", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (checkBox1.IsChecked == true)
            {
                try
                {
                    if (txt_Rost.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(600, txt_Rost.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Valid Quentity", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (checkBox2.IsSealed == true)
            {
                try
                {
                    if (txt_crisp.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(900, txt_crisp.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Valid Quentity", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (checkBox3.IsSealed == true)
            {
                try
                {
                    if (txt_beef.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(800, txt_beef.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Valid Quentity", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (checkBox4.IsSealed == true)
            {
                try
                {
                    if (txt_pork.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(600, txt_pork.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter Valid Quentity", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            payment pay = new payment(total);
            pay.ShowDialog();
            this.Hide();
        }
    }
}
