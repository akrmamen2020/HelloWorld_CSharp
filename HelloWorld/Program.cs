using System;

class Program
{
    static void Main()
    {


        //int[] numbers = new int[4];

        //numbers[0] = 101;
        //numbers[1] = 102;
        //numbers[2] = 103;
        //numbers[3] = 104;


        //for (int i  = 0; i <= numbers.Length -1; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        //foreach (int i in numbers) {
        //    Console.WriteLine("Foreach {0}", i);
        //}


        for (int i = 0; i <= 20; i++)
        {

            if (i % 2 == 1)
                continue;

            Console.WriteLine(i);

            //if (i == 10)
            //    break;
        }

        Console.WriteLine("After loop");

        Console.ReadKey(true);
    }
}


