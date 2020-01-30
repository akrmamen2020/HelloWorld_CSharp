using System;


class Program
{
    static void Main()
    {
        Calculator.add(1, 2);


        Console.ReadKey(true);
    }
}

class Calculator
{
    [Obsolete("This Method is old use the new one", true)]
    public static int add(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int add(int n1, int n2 , bool x, params int[] numbers)
    {
        int sum = n1 + n2;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;
    }
}


