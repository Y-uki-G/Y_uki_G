using TaskInt;
Again:
Console.WriteLine("Enter Username, Email, Password");
User user1 = new User
{
    FullName = Console.ReadLine(),
    Email = Console.ReadLine(),
    Password = Console.ReadLine()
};
//user1.Passwordchecker(user1.Password);
if (user1.Passwordchecker(user1.Password) == false)
{
    goto Again;
}
user1.ShowInfo();