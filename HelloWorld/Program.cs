using System;


class Program
{
    static void Main()
    {

        Animal dog = new Animal("black", 1, "german");
        dog.PrintFullInfo();
        dog.Run();

        Console.ReadKey(true);
    }
}

class Animal
{
    string _color;
    int _length;
    string _name;

    public Animal(string color, int len, string name)
    {
        _color = color;
        _length = len;
        _name = name;
    }

    public void PrintFullInfo()
    {
        Console.WriteLine(" color = {0} , len = {1}, name = {2} ", _color, _length, _name);
    }

    public void Run()
    {
        Console.WriteLine(" the {0} is running ", _name);
    }

    ~Animal()
    {
        //Clean The Code
        _color = null;
        _name = null;
    }
}


class Customer
{


}