using System;


class Program
{
    static void Main()
    {


        Circle circle = new Circle(5);
        float Area = circle.CalculateArea();
        Console.WriteLine(Area);

        Circle circle2 = new Circle(6);
        float Area2 = circle2.CalculateArea();
        Console.WriteLine(Area2);

        Circle circle3 = new Circle(61);
        float Area3 = circle3.CalculateArea();
        Console.WriteLine(Area2);

        Circle circle4 = new Circle(50);
        float Area4 = circle2.CalculateArea();
        Console.WriteLine(Area2);

        Console.ReadKey(true);
    }
}

 class Circle
{
   public static  float _PI ;
    int _Radius;

    static Circle()
    {
        Console.WriteLine("static Circle");
        _PI = 3.141F;
    }


    public Circle(int Radius)
    {
        Console.WriteLine(" public Circle {0} " , Radius);
        _Radius = Radius;
    }


    public static void Print()
    {
        Console.WriteLine("Circle");
    }

    public float CalculateArea()
    {
        return this._Radius * Circle._PI;
    }
}
