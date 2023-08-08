using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1project_food_fantacy_final
{
    class Calculate
    {
        public int CalculateItem(int price , string Quentity)
        {
            int total = price * Convert.ToInt32(Quentity) ;
            return total;
        }
        public int gettotal(int num1 , int num2, int num3)
        {
            int tot = num1 + num2 + num3;
            return tot;
        }
       
    }
}
