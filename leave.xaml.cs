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
    /// Interaction logic for leave.xaml
    /// </summary>
    public partial class leave : Window
    {
        public leave()
        {
            InitializeComponent();
        }
        DB_Connect DB = new DB_Connect();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DB.ReqLeaves_Payment("Insert Into Leave Values ('"+txt_eno.Text+"','"+txt_ename.Text+"','"+txt_reason.Text+"')"); // 
        }
    }
}
