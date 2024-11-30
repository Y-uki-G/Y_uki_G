using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using Task1;


internal class Program
{
    private static void Main(string[] args)
    {
        
       
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());
        Calculartor calculator = new Calculartor();
        double result;
        switch (c)
        {
            case '+':
                result= (int)calculator.sum(a, b);
                Console.WriteLine(result);
                break;
            case '-':
                result = (int)calculator.difference(a, b);
                Console.WriteLine(result);
                break;
            case '*':
                result = (int)calculator.multi(a, b);
                Console.WriteLine(result);
                break;
            case '/':
                result = calculator.dived(a, b);
                Console.WriteLine(result);
                break;
            default:
                Console.WriteLine("bdchsdjmbcdm");
                break;
        }
    }
}