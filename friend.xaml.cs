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
    /// Interaction logic for friend.xaml
    /// </summary>
    public partial class friend : Window
    {
        public friend()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int price = 4250;
            payment pay = new payment(price);
        }
    }
}
