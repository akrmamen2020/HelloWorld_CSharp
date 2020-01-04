using System;

class Program
{
    //the main function
    static void Main()
    {

        string str = "Ahmed Moahamdy 2020";

        Console.WriteLine(str[0]);

        /*int[] numbers = new int[3];

        numbers[0] = 100;
        numbers[1] = 200;
        numbers[2] = 300;

        Console.WriteLine(numbers[2]);*/

        myClass cls = new myClass();

        string[] strArr = new string[] { "Mohamed", "Mahomud", "Salah" } ;

        Console.WriteLine(strArr[1][0]);

        Console.ReadKey(true);
    }
}


/// <summary>
/// Ahmed Mohamady Class For bla bla bla 
/// </summary>
class myClass { 


}

