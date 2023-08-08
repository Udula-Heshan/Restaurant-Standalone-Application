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
    /// Interaction logic for BeveragesWindow2.xaml
    /// </summary>
    public partial class BeveragesWindow2 : Window
    {
        public string[] Lime { get; set; }
        public string[] Fruit { get; set; }
        public string[] Cool { get; set; }
        public BeveragesWindow2()
        {
            InitializeComponent();
            Cool = new string[] { "Pepsi", "7up", "Coca Cola", "Cool Water" };
            DataContext = this;
            Fruit = new string[] { "Mix Fruit Juice","Mango Juice","Apple Juice","Grape Juice","BlueBerry" };
            DataContext = this;
            Lime = new string[] { "Lime Blaster", "Lime Shake", "Ginger Lime", "Lime Juice" };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculate Cal = new Calculate();
            DB_Connect DB = new DB_Connect();
            int totLime;
            int totFruit;
            int totCool;
            if (cmb_lime.SelectedIndex == 0)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D003");
                String Quentity = txt_limeQ.Text;
                totLime = Cal.CalculateItem(Price, Quentity);
            }
            else if(cmb_lime.SelectedIndex==1)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D004");
                String Quentity = txt_limeQ.Text;
                totLime = Cal.CalculateItem(Price, Quentity);
            }
            else if (cmb_lime.SelectedIndex == 2)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D005");
                String Quentity = txt_limeQ.Text;
                totLime = Cal.CalculateItem(Price, Quentity);
            }
            else
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D006");
                String Quentity = txt_limeQ.Text;
                totLime = Cal.CalculateItem(Price, Quentity);
            }
            if (cmb_Fruit.SelectedIndex==0)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D007");
                String Quentity = txt_fruitQ.Text;
                totFruit = Cal.CalculateItem(Price, Quentity);
            }
            else if (cmb_Fruit.SelectedIndex == 1)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D008");
                String Quentity = txt_fruitQ.Text;
                totFruit = Cal.CalculateItem(Price, Quentity);
            }
            else if (cmb_Fruit.SelectedIndex == 2)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D009");
                String Quentity = txt_fruitQ.Text;
                totFruit = Cal.CalculateItem(Price, Quentity);
            }
            else if (cmb_Fruit.SelectedIndex == 3)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D010");
                String Quentity = txt_fruitQ.Text;
                totFruit = Cal.CalculateItem(Price, Quentity);
            }
            else
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D011");
                String Quentity = txt_fruitQ.Text;
                totFruit = Cal.CalculateItem(Price, Quentity);
            }
            if(cmb_cool.SelectedIndex==0)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D012");
                String Quentity = txt_fruitQ.Text;
                totCool = Cal.CalculateItem(Price, Quentity);
            }
            else if (cmb_cool.SelectedIndex == 1)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D013");
                String Quentity = txt_fruitQ.Text;
                totCool = Cal.CalculateItem(Price, Quentity);
            }
            else if (cmb_cool.SelectedIndex == 2)
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D014");
                String Quentity = txt_fruitQ.Text;
                totCool = Cal.CalculateItem(Price, Quentity);
            }
            else
            {
                int Price = DB.Get_Drink("Select Drink_Price From Drink Where DrinkCode=D015");
                String Quentity = txt_fruitQ.Text;
                totCool = Cal.CalculateItem(Price, Quentity);
            }
            int nettot = Cal.gettotal(totLime, totFruit, totCool);

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
