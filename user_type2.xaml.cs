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
    /// Interaction logic for user_type2.xaml
    /// </summary>
    public partial class user_type2 : Window
    {
        public user_type2()
        {
            InitializeComponent();
        }
        DB_Connect DBObj = new DB_Connect();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Name.Text.Length == 0)
                MessageBox.Show("Name Cannot Be Blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_Name.Text.Any(char.IsDigit))
                MessageBox.Show("Name Cannot Have Numbers", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_Address.Text.Length == 0)
                MessageBox.Show("Address Cannot Be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (DOBPicker.Text.Length == 0)
                MessageBox.Show("Date Of Birth Cannot Be Empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_NIC.Text.Length == 0)
                MessageBox.Show("NIC cannot Be Blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_NIC.Text.Length >= 12)
                MessageBox.Show("Maximum Length Is 12 Cheak ID Number Again", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (txt_Job.Text.Length == 0)
                MessageBox.Show("Job Type Cannot Be Blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_tp.Text.Length == 0)
                MessageBox.Show("Tele Phone Number Cannot Be Blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (txt_tp.Text.Any(char.IsLetter))
                MessageBox.Show("Tele Phone Number Cannot Have Letters", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                int value = DBObj.EmpSignIn("Insert Into Employee (EmpID , EName , EAddress , DOB , Emp_NIC	, Job , Emp_TP) values (@EmpID'" + txt_Name.Text + "','" + txt_Address.Text + "','" + DOBPicker.Text + "','" + txt_NIC.Text + "','" + txt_Job.Text + "', @TP)", Convert.ToInt32(txt_tp.Text));
                if (value == 1)
                    MessageBox.Show("Successfully Registered", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                else if (value == 2)
                    MessageBox.Show("Database Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                    MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
