using System.ComponentModel;
using Task3;

// Task 1;



int a=Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1. Press 1 for Sum\n2. Press 2 for Product");
StartPoint:
int q= Convert.ToInt32(Console.ReadLine());
Calculator calculator = new Calculator();
if (q == 1)
{

    Console.WriteLine(calculator.Add(a, b));
}
else if (q == 2)
{
    Console.WriteLine(calculator.Multiply(a, b));
}
else
{
    Console.WriteLine("Enter valid number for calculation");
    goto StartPoint;
}
//Task 2;
Student stu1 = new Student()
{
    name = Console.ReadLine(),
    age= Convert.ToInt32(Console.ReadLine()),
    grade= Convert.ToInt32(Console.ReadLine())
};
Student stu2 = new Student()
{
    name = Console.ReadLine(),
    age = Convert.ToInt32(Console.ReadLine()),
    grade = Convert.ToInt32(Console.ReadLine())
};
Console.WriteLine(stu1.name + " " + stu1.age + " " + stu1.grade);
Console.WriteLine(stu2.name + " " + stu2.age + " " + stu2.grade);

// Task 3;
