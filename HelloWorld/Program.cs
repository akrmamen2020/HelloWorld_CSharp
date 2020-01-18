using System;

class Program
{
    static void Main()
    {

        //Program p = new Program();
        //Program.EvenNumbers(40);
        //Console.WriteLine(Program.addNumbers(20, 15));

        Program.EvenNumbers(9);


        Console.ReadKey(true);
    }

    public static int addNumbers(int num1,int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public static void EvenNumbers(int target)
    {
        int Start = 0;

        if (target <= 10)
        {
            Console.WriteLine("Number is < 10");
            return;
        }

        while (Start <= target)
        {
            Console.WriteLine("the number is {0} ", Start);
            Start += 2;
        }

    }

}


