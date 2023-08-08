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
    /// Interaction logic for payment.xaml
    /// </summary>
    public partial class payment : Window
    {
        public payment(int netvalue)
        {
            InitializeComponent();
            textBlock_net.Text = Convert.ToString(netvalue);
        }
        DB_Connect obj = new DB_Connect();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton_yes.IsChecked == true)
            {
                    textBlock_net.Text = Convert.ToString(Convert.ToDouble(textBlock_net.Text) * 0.1);
                    obj.ReqLeaves_Payment("Insert Into Payment values('"+txt_EID.Text+"','"+txt_CID.Text+"','"+textBlock_net.Text+"')");
            }
            else if (radioButton_no.IsChecked == true)
            {
                MessageBox.Show("No Special Offers", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                obj.ReqLeaves_Payment("Insert Into Payment values('" + txt_EID.Text + "','" + txt_CID.Text + "','" + textBlock_net.Text + "')");
            }
            else
                MessageBox.Show("Pleace Select Fallowing options Yes or No", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
