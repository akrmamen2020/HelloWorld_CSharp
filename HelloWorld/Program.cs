using System;

public struct Customer
{
    private int _id;
    private string _name;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public Customer(int _ID, string _NAME)
    {
        _id = _ID;
        _name = _NAME;
    }

    public void Print()
    {
        Console.WriteLine(" Name : {0}, ID : {1} ",_name , _id);
    }
}

class Program
{
    static void Main()
    {
        Customer customer = new Customer(1, "Ahmed");

        customer.Print();

        Console.ReadKey(false);
    }
}


