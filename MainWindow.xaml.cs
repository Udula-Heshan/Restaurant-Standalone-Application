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


namespace WpfApp1project_food_fantacy_final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_Connect DB_obj = new DB_Connect();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender , RoutedEventArgs e)
        {
            DragMove();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            home_menuWindow2 foodmenu = new home_menuWindow2();
            foodmenu.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            this.Show();
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            services Ser = new services();
            Ser.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_4(object sender, RoutedEventArgs e)
        {
            PromoPacks promo = new PromoPacks();
            promo.Show();
            this.Hide();
        }

        private void ListViewItem_Selected_5(object sender, RoutedEventArgs e)
        {
            user_type2 User = new user_type2(); //need to change
            User.Show();
            this.Hide();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0)
                MessageBox.Show("User ID Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (passwordBox.Password.Length == 0)
                MessageBox.Show("Password Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            if (radioButton.IsChecked == true)
            {
                int value = DB_obj.login("Select Count(*) From Employee Where EmpID = '" + textBox.Text + "' and EPassword = '" + passwordBox.Password + "'");
                if (value == 1)
                {
                    employee user = new employee();
                    user.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Cheak Username And Password Again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (radioButton1.IsChecked == true)
            {
                int value = DB_obj.login("Select Count(*) From Customer Where CID = '" + textBox.Text + "' and C_Password = '" + passwordBox.Password + "'");
                if (value == 1)
                {
                    Sign_in_Customer user = new Sign_in_Customer();
                    user.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Cheak Username And Password Again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (radioButton2.IsChecked == true)
            {
                int value = DB_obj.login("Select Count(*) From Manager Where MID = '" + textBox.Text + "' and M_Password = '" + passwordBox.Password + "'");
                if (value == 1)
                {
                    ManagementView user = new ManagementView();
                    user.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Cheak Username And Password Again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
                MessageBox.Show("Select One Of The Option", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
