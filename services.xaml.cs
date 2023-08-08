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
    /// Interaction logic for services.xaml
    /// </summary>
    public partial class services : Window
    {
        public services()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bday obj = new Bday();
            obj.Show();
        }

        private void Button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            friend friend = new friend();
            friend.Show();
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            family fam = new family();
            fam.Show();
        }
    }
}
