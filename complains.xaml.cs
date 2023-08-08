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
    /// Interaction logic for complains.xaml
    /// </summary>
    public partial class complains : Window
    {
        public complains()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DB_Connect DB = new DB_Connect();
            DB.ReqLeaves_Payment("insert Into Complaints Values('" + txt_comp.Text + "')");
        }
    }
}
