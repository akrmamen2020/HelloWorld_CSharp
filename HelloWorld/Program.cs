using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello world");

        Console.WriteLine("Enter Your First Name :");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Your Last Name :");
        string lastName = Console.ReadLine();


        Console.WriteLine("Welcome Back " + firstName + " " + lastName);
        Console.WriteLine("Your Acount is Active Mr.{0} {1}", firstName, lastName);




        Console.ReadKey(true);
    }
}

