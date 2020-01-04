using System;

class Program
{
    static void Main()
    {

        string str = "Ahmed";
        int i = 10;
        bool b = true;

        i = 20;


        int num1 = 11;
        int num2 = 2;
        int num3 = 10;

        int result = num1 % num2;

        bool isTrue = ((num1 != num2) && (num1 == num3)) ;

        bool isNumber10 = num1 <= 10 ? true : false;

        Console.WriteLine("the result = " + isNumber10);

        Console.ReadKey(true);
    }
}

