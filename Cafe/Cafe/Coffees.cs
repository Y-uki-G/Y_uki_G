using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Coffees : Shop
    {
        public List<string> coffee_name = new List<string> { "Latte", "Espresso", "Americano", "Caffè mocha" };
        public List<int> coffee_count = new List<int> { 16, 10, 20, 7};
        public List<int> coffee_price = new List<int> { 7, 5, 8, 13 };

        public class Coffee : Properties
        {

        }
        public void OrderCoffee()
        {
            Console.WriteLine("Enter Coffee Name, Count, and Price:");
            Coffees.Coffee coffee = new Coffees.Coffee()
            {
                Name = Console.ReadLine(),
                count = Convert.ToInt32(Console.ReadLine()),
                price = Convert.ToInt32(Console.ReadLine())
            };
            
            coffee_name.Add(coffee.Name);
            coffee_count.Add(coffee.count);
            coffee_price.Add(coffee.price);
            //UpdateTotalIncome();
        }
    }
    
}
