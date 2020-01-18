using System;

class Program
{
    static void Main()
    {


    
        int Start = 0;
        string rst = "";

        do
        {
            Console.WriteLine("Please Set your target");
            int theTarget = int.Parse(Console.ReadLine());
            while (Start <= theTarget)
            {
                Console.WriteLine(" your number is {0} ", Start);
                Start++;
            }
            Console.WriteLine("Do you want to play again ( y-Yes, n- No)");
            rst = Console.ReadLine();
            Start = 0;
        } while (rst == "y");

        Console.WriteLine("Game over");

        Console.ReadKey(true);
    }
}


