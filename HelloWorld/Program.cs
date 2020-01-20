using System;
using PATA = ProjectA.TeamA;
using PBTB = ProjectA.TeamB;

class Program
{
    static void Main()
    {

        PATA.ClassA.Print();
        PBTB.ClassB.Print();

        Console.ReadKey(true);
    }
}


namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public  static void Print()
            {
                Console.WriteLine("Hello Class A");
       
            }
        }
    }


}

namespace ProjectA
{
    namespace TeamB
    {

        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Hello Class A");

            }
        }

        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("Hello Class B");

            }
        }

    }
}