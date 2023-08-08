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
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Window
    {
        public Sign_in()
        {
            InitializeComponent();
        }
        DB_Connect obj = new DB_Connect();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Username.Text.Length == 0)
                MessageBox.Show("Name Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_Username.Text.Any(char.IsDigit))
                MessageBox.Show("Name Cannot Have Numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBox.Password.Length == 0 & passwordBox_Copy.Password.Length == 0)
                MessageBox.Show("Password Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBox.Password != passwordBox_Copy.Password)
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                int value = obj.signin("Insert Into Employee (EmpID,EName,EPassword) Values (@ID,'" + txt_Username.Text + "','" + passwordBox.Password + "')", "E00");
                if (value == 0)
                    MessageBox.Show("Sign In Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Hide();
                sign_in2 emp = new sign_in2();
                emp.Show();
            }
            //need validate
        }
    }
}
