using Microsoft.Win32;
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
    /// Interaction logic for Sign_in2_Manager.xaml
    /// </summary>
    public partial class Sign_in2_Manager : Window
    {
        public Sign_in2_Manager()
        {
            InitializeComponent();
        }

        private void ButtonM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    Uri fileUri = new Uri(openFileDialog.FileName);
                    image.Source = new BitmapImage(fileUri);
                }
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("Please select an Image only", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing Went Wrong", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
