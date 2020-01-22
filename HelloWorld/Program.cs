using System;


public class Father
{
    public virtual void Print()
    {
        Console.WriteLine("Hello Father. :)");
    }

    public void myName()
    {
        Console.WriteLine("Father Name. :)");
    }
}

public class Son : Father
{
    public override void Print()
    {
        Console.WriteLine("Hello Son. :)");
    }

    public new void myName()
    {
        Console.WriteLine("Son Name. :)");
    }
}

class Program
{
    static void Main()
    {

        Father father = new Son();
        father.Print();
        Console.WriteLine("===================================");
        father.myName();

        Console.ReadKey(false);
 
    }
}


