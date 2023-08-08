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
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1project_food_fantacy_final
{
    /// <summary>
    /// Interaction logic for ManagementView.xaml
    /// </summary>
    public partial class ManagementView : Window
    {
        public ManagementView()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection();
        private void Btn_payDetails_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            sda = new SqlDataAdapter("Select * From Payment", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            Grid.ItemsSource = dt.DefaultView;
        }

        private void Btn_cusDetails_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            sda = new SqlDataAdapter("Select * From Customer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            Grid.ItemsSource = dt.DefaultView;
        }

        private void Btn_empDetails_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            sda = new SqlDataAdapter("Select * From Employee", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            Grid.ItemsSource = dt.DefaultView;
        }
    }
}
