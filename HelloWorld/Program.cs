using System;


class Program
{
    static void Main()
    {

        add(5, 6, 1,1,1,1,1);

        int[] arr = new int[4];  

        add(5, 0, false, arr);

        Console.ReadKey(false);
    }

    private static int add(int n2, int n1, params int[] arr)
    {
        Console.WriteLine("Sum = {0} ", n1 + n2);
        return n1 + n2; 
    }

    public static void add(int n2, int n1, int[] arr)
    {
        n1 = 20;
        Console.WriteLine("Sum = {0} ", n1 + n2);
    }
}


