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
    /// Interaction logic for employee.xaml
    /// </summary>
    public partial class employee : Window
    {
        public employee()
        {
            InitializeComponent();
        }

        private void Button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            employee_reg reg = new employee_reg();
            reg.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            updateaccount update = new updateaccount();
            update.Show();
            this.Hide();
        }

        private void Button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            timetable obj = new timetable();
            obj.Show();
            this.Hide();
        }

        private void Button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            leave leave = new leave();
            leave.Show();
            this.Hide();
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            complains obj = new complains();
            obj.Show();
            this.Hide();
        }
    }
}
