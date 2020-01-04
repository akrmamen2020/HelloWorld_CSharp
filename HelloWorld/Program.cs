using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello world");

        string stringVar = "Hello World!!";
        int intVar = 100;
        float floatVar = 10.2f;
        char charVar = 'A';
        bool boolVar = true;

        Console.WriteLine("Max int Value {0}", int.MaxValue);
        Console.WriteLine("Min int Value {0}", int.MinValue);

        int d = 2014512454;

        Console.WriteLine("The double number is {0}", d);

        Console.ReadKey(true);
    }
}

