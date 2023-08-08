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
    /// Interaction logic for Sign_in_Customer.xaml
    /// </summary>
    public partial class Sign_in_Customer : Window
    {
        public Sign_in_Customer()
        {
            InitializeComponent();
        }
        DB_Connect obj = new DB_Connect();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_UsernameC.Text.Length == 0)
                MessageBox.Show("Name Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_UsernameC.Text.Any(char.IsDigit))
                MessageBox.Show("Name Cannot Have Numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBoxC.Password.Length == 0 & passwordBox_Copy.Password.Length == 0)
                MessageBox.Show("Password Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBoxC.Password != passwordBox_Copy.Password)
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                int num = obj.signin("Insert Into Customer (CID , CName , C_Password) values (@ID,'" + txt_UsernameC.Text + "','" + passwordBoxC.Password + "') ", "C00");
                if (num == 0)
                    MessageBox.Show("Sign In Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Hide();
                Sign_in2_Customer cus = new Sign_in2_Customer();
                cus.Show();
            }
            //need validate
        }
    }
}
