using System;

class Program
{
    static void Main()
    {

        float f = 15431654645646.55f;

        string str = "100";

        int result = 0;

        bool isTrue = int.TryParse(str, out result);

        int i = result;

        if (isTrue == true)
        {
            Console.WriteLine(i);
        }
        else
        {
            Console.WriteLine("The input is not correct");
        }

        Console.ReadKey(true);
    }
}

