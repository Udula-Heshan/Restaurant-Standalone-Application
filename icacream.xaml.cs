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
    /// Interaction logic for icacream.xaml
    /// </summary>
    public partial class icacream : Window
    {
        public icacream()
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
                    if (textBox.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(800, textBox.Text);
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
                    if (textBox2.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(600, textBox2.Text);
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
                    if (textBox1.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(900, textBox1.Text);
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
                    if (textBox3.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(800, textBox3.Text);
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
                    if (textBox4.Text.Any(char.IsLetter))
                        MessageBox.Show("Quentity Cannot Be Word / Letter", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    total = total + cal.CalculateItem(600, textBox4.Text);
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
