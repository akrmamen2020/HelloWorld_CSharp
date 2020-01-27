using System;

public delegate int MyDelegate(out int x);

class Program
{
    static void Main()
    {
        MyDelegate myDelegate = new MyDelegate(myMethod);

        myDelegate += myMethod2;
        myDelegate += myMethod3;
        myDelegate -= myMethod2;

        int x = 0; 
        Console.WriteLine(myDelegate(out x));
        Console.WriteLine(x);



        Console.ReadKey(true);
    }

    public static int myMethod(out int x)
    {
        x = 1;
        Console.WriteLine("Hello wrold {0}" , x);
        return 1;
    }

    public static int myMethod2(out int x)
    {
        x = 2;
        Console.WriteLine("Hello wrold {0}", x);
        return 2; 
    }

    public static int myMethod3(out int x)
    {
        x = 3;
        Console.WriteLine("Hello wrold {0}", x);
        return 3;
    }
}




