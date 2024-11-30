using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Teas : Shop
    {
        public List<string> tea_name = new List<string> { "Black tea", "Green tea", "Mint tea", "Matcha" };
        public List<int> tea_count = new List<int> { 27, 21, 16, 12};
        public List<int> tea_price = new List<int> { 1, 2, 2, 3 };

        public class Tea : Properties
        {
            //internal static readonly IEnumerable<object> tea_price;
        }
        public void OrderTea()
        {
            Console.WriteLine("Enter Tea Name, Count, and Price:");
            Teas.Tea tea = new Teas.Tea()
            {
                Name = Console.ReadLine(),
                count = Convert.ToInt32(Console.ReadLine()),
                price = Convert.ToInt32(Console.ReadLine()),

            };

            tea_name.Add(tea.Name);
            tea_count.Add(tea.count);
            tea_price.Add(tea.price);
            //UpdateTotalIncome();
        }

        //switch (ordername)
        //{
        //    for(int i =1; i<= tea_lenght+coffee_lenght; i++){
        //    case i:
        //        addtea.tea_count
        //        break;
        //    }
    }
}
