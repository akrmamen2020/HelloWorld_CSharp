using System;

class Program
{
    static void Main()
    {

        int x = 0;

        x = 300 + 20; 

        addNumbers(5, 10);

        Console.WriteLine("Add Finish"); 

        Console.ReadKey(true);
    }


    public static void addNumbers(int x1, int x2)
    {
        int x = 0;

        x = x1 + x2;

        Console.WriteLine(" the Sum = {0} ", x);
    }
}




