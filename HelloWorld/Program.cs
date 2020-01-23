using System;


interface ICustomer
{
    void Print();
    int add(int x1, int x2);
}

interface I2 : ICustomer
{
    void I2Method();
}

public class Customer : I2
{
    public int add(int x1, int x2)
    {
        return x1 + x2;
    }

    public void I2Method()
    {

    }

    public void Print()
    {
        Console.WriteLine("The Customer Class");
    }
}

public class Student : ICustomer
{
    public int add(int x1, int x2)
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        Console.WriteLine("The Student Class");
    }
}

class Program
{
    static void Main()
    {
        //ICustomer customer = new ICustomer();

        I2 customer = new Customer();
        customer.Print();
        customer.I2Method();

        Console.ReadKey(false);
    }
}


