using System;

class Program
{
    static void Main()
    {

        int total = 0;


        Start:

        Console.WriteLine("select your sandwich : 1- Large , 2- x-Large, 3 xx-Large");
        int item = int.Parse(Console.ReadLine());


        switch (item)
        {
            case 1:
                total += 10;
                break;
            case 2:
                total += 20;
                break;
            case 3:
                total += 30;
                goto case 1;
            default:
                Console.WriteLine("Your choice {0} is invalid");
                break;
        }

        Console.WriteLine("Your choice is : {0} $", item);

        Console.WriteLine("Do you want another sandwich ? y-Yes , n-No");
        string rst = Console.ReadLine();

        if (rst == "y")
        {
            goto Start;
        }
        else
        {

        }

        Console.WriteLine("Total Check is : {0} $", total);

        Console.ReadKey(true);
    }
}


