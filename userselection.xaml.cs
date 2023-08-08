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
    /// Interaction logic for userselection.xaml
    /// </summary>
    public partial class userselection : Window
    {
        public userselection()
        {
            InitializeComponent();
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            employee emp = new employee();
            emp.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
