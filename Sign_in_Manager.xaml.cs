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
    /// Interaction logic for Sign_in_Manager.xaml
    /// </summary>
    public partial class Sign_in_Manager : Window
    {
        public Sign_in_Manager()
        {
            InitializeComponent();
        }
        DB_Connect obj = new DB_Connect();

        private void ButtonSM_Click(object sender, RoutedEventArgs e)
        {
            if (txt_UsernameM.Text.Length == 0)
                MessageBox.Show("Name Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_UsernameM.Text.Any(char.IsDigit))
                MessageBox.Show("Name Cannot Have Numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBoxM.Password.Length == 0 & passwordBox_Copy.Password.Length == 0)
                MessageBox.Show("Password Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBoxM.Password != passwordBox_Copy.Password)
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                int num = obj.signin("Insert Into Manager (MID , MName ,M_Password) values (@ID , '" + txt_UsernameM.Text + "','" + passwordBoxM.Password + "'", "M00");
                if (num == 0)
                    MessageBox.Show("Sign In Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
