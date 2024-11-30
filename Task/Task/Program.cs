using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Name: ");
        string person_name = Console.ReadLine();
        Console.Write("Surname: ");
        string person_surname = Console.ReadLine();
        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Task.Person person = new Task.Person(person_name, person_surname, age);

        Console.WriteLine("Name: " + person.Name +"\nSurname: "+ person.Surname + "\nAge: " + person.Age + "\nIs Given Person adult?  "+ person.IsAdult);
    }
}