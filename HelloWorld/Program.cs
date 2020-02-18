using System;
using System.Text; 

namespace theSystem
{
    class Program
    {
        static void Main()
        {

            //Console.WriteLine(Calculator.addNumbers("49", 9)); 

            MyNumbers m1 = new MyNumbers() { myNumber = 10 };
            MyNumbers m2 = new MyNumbers() { myNumber = 10 };


            Console.WriteLine(Calculator<MyNumbers>.equals(m1, m2));

            Console.WriteLine(Calculator<int>.equals(10, 20));

            Console.WriteLine(Calculator<string>.equals("10", "10"));

            Console.ReadKey(true); 
        }
    }


    public class Calculator<T>
    {
        public static int addNumbers(object num1, object num2)
        { 
            return Convert.ToInt16(num1) + Convert.ToInt16(num2);

            

        }

        public static bool equals(T obj1, T obj2)
        {
            return obj1.Equals(obj2);
        }

    }


    public class MyNumbers
    {

        public int myNumber { get; set; }

        public override bool Equals(object obj)
        {
            return this.myNumber == ((MyNumbers)obj).myNumber;
        }
    }
}