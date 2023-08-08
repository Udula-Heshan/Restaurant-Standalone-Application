using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1project_food_fantacy_final
{
    class DB_Connect
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        public DB_Connect()
        {
            con = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Food_Fantacy_DB;Integrated Security=True");
        }
        public int login(string a)
        {
            con.Open();
            sda = new SqlDataAdapter(a , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            if (dt.Rows[0][0].ToString() == "1")
            {
                return 1;
            }
            else
                return 0;
        }
        public int getprice(string a)
        {
            con.Open();
            int price;
            price = 0;
            sda = new SqlDataAdapter(a, con);
            cmd.Parameters.AddWithValue("Price",price);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return price;
        }
        public int EmpSignIn(string a , int TP)
        {
            try
            {
                string EmpID;
                int n = 4;
                EmpID = "E00"+n; // needto implement this value
                n++;
                con.Open();
                cmd = new SqlCommand(a, con);
                cmd.Parameters.AddWithValue("EmpID", EmpID);
                cmd.Parameters.AddWithValue("TP", TP);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch(SqlException)
            {
                return 2;
            }
        }
        public int signin(string a, string type)
        {
            try
            {
                con.Open();
                int num = 4;
                string EmpID = type + num.ToString();
                num++;
                cmd = new SqlCommand(a, con);
                cmd.Parameters.AddWithValue("ID", EmpID);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (SqlException)
            {
                return 2;
            }
        }
        public int ReqLeaves_Payment(string a)
        {
            con.Open();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public int Get_Drink(string a)
        {
            con.Open();
            sda = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            int data = sda.Fill(dt);
            return data;
        }

    }
}
