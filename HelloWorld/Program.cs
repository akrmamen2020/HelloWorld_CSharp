using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your number :");
        int num = int.Parse(Console.ReadLine());


        //if (num == 1)
        //{
        //    Console.WriteLine("Your number is 1");
        //}
        //else if (num == 2)
        //{
        //    Console.WriteLine("Your number is 2");
        //}
        //else if (num == 3)
        //{
        //    Console.WriteLine("Your number is 3");
        //}
        //else 
        //{
        //    Console.WriteLine("Your number is out of range");
        //}


        int num2 = 20;

        if (num == 1 || num == 2)
        {
            Console.WriteLine("Number is 1 or 2");
        }
        else if(num == 10 && num2 ==20)
        {
            Console.WriteLine("Number is 10 and 20");
        }
        else
        {
            Console.WriteLine("Number is out of range");
        }



        Console.ReadKey(true);
    }
}


