using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cafe
{
    public class Shop
    {
        private int total_income;
        public int Total_Income
        {
            get
            {
                return total_income;
            }
            set
            {
                total_income = value;
            }
        }

        public class Properties : Shop
        {
            public string Name;
            public int count;
            public int price;
        }

        //public Teas addtea = new Teas();
        //public Coffees addcoffee = new Coffees();

        //public void UpdateTotalIncome()
        //{
        //    int total_income = 0;
        //    for (int i = 0; i < addtea.tea_name.Count; i++)
        //    {
        //        total_income += addtea.tea_price[i] * addtea.tea_count[i];
        //    }
        //    for (int i = 0; i < addcoffee.coffee_name.Count; i++)
        //    {
        //        total_income += addcoffee.coffee_price[i] * addcoffee.coffee_count[i];
        //    }
        //    Console.WriteLine("Total Income: " + total_income);
        //}
    }
    
}
