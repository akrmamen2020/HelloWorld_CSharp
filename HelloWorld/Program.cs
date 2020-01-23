using System;


abstract class Father
{


}

abstract class Customer : Father, IM 
{

    int ID = 10;


    public abstract void Print();

    public void info()
    {

    }

    public void myMethod()
    {
        throw new NotImplementedException();
    }
}

interface IM 
{
    void myMethod(); 

}

sealed class myClass
{
}

class Program : Customer
{
    static void Main()
    {


        Console.ReadKey(false);
    }

    public override void Print()
    {
        base.info(); 
    }
}


