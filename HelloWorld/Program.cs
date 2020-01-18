using System;

class Program
{
    static void Main()
    {


        //int i = 0;

        //method(ref i);

        // int div = 0;
        // int mult = 0;

        //Console.WriteLine(calculate(20, 10, out div, out mult));

        // Console.WriteLine(div);
        // Console.WriteLine(mult);
        //Console.WriteLine(i);

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

        arrMethod("ahmed",1, 2, 3, 4, 5, 6);

        Console.ReadKey(true);
    }

    public static void arrMethod(string a, params int[] args)
    {
        foreach (int i in args)
        {
            Console.WriteLine(i);
        }
    }


    public static int calculate(int num1, int num2, out int div, out int mult)
    {
        div = num1 / num2;
        mult = num1 * num2;
        return num1 + num2;
    }

    public static void method(ref int j)
    {
        j = 200;
    }
}


