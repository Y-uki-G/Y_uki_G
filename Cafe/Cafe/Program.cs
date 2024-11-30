using Cafe;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static Cafe.Shop;
using static Cafe.Teas;
Cafe.Teas addtea = new Cafe.Teas();
Cafe.Coffees addcoffee = new Cafe.Coffees();
Cafe.Shop shop = new Cafe.Shop();
Console.WriteLine("1. Product elave edin.\n2. Product satin.\n3. Umumu gelir");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        
        Console.WriteLine("Product type: \nt --> Tea\nc --> Coffee");
        string productType = Console.ReadLine().Trim();
        if (productType == "t")
        {
            addtea.OrderTea();
        }
        else if (productType == "c")
        {
            addcoffee.OrderCoffee();
        }
        break;
    case 2:
        Console.WriteLine("List of Tea:\n");

        int tea_lenght = addtea.tea_name.Count();
        for (int i = 0; i < tea_lenght; i++)
        {
            Console.WriteLine(i + 1 + ". " + addtea.tea_name[i] + "     Price  ---> " + addtea.tea_price[i] + "      Avaliabe count --->" + addtea.tea_count[i] +  "\n");
        }
        Console.WriteLine("List of Coffee:\n");
        int coffee_lenght = addcoffee.coffee_name.Count();
        for (int i = 0; i < coffee_lenght; i++)
        {
            Console.WriteLine(i + 1 + tea_lenght + ". " + addcoffee.coffee_name[i] + "      Price  ---> " + addcoffee.coffee_price[i] + "       Avaliabe count  ---> " + addcoffee.coffee_count[i] + "\n");
        }
        Console.WriteLine("Your order and count");
        int ordername=Convert.ToInt32(Console.ReadLine());
        int ordercount=Convert.ToInt32(Console.ReadLine());
        if (ordername <= tea_lenght)
        {

        }
        else if (ordername > tea_lenght && ordername<= tea_lenght+coffee_lenght)
        {

        }
        break;

        //case 3:
        //shop.UpdateTotalIncome(); 
        //Console.WriteLine("Total Income: " + shop.Total_Income);
        //break;

}
