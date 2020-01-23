using System;

 interface I1
{
    void theMathod();
}

interface I2
{
    void theMathod();
}

class theClass : I1, I2
{
    void I1.theMathod()
    {
        Console.WriteLine("I1 Method");
    }

    void I2.theMathod()
    {
        Console.WriteLine("I2 Method");
    }
}

class Program
{
    static void Main()
    {
        I1 cls = new theClass();
        cls.theMathod();


        Console.ReadKey(false);
    }
}


