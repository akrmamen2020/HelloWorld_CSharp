using System;

namespace theSystem
{
    class Program
    {
        static void Main()
        {
            int Number = 10;

            Number.ToString();

            Console.WriteLine(Number.ToString());
            Console.WriteLine(Convert.ToString(Number));

            Console.WriteLine("================================");
            Customer c = new Customer();
            c.FirstName = "Ahmed";
            c.LastName = "Mohamady";

            Console.WriteLine(Convert.ToString(c));
            Console.WriteLine(c.ToString());

            int Number2 = 10;

            Console.WriteLine("================================");

            //Console.WriteLine(Number.Equals(Number2));

            Customer c2 = new Customer();
            c2.FirstName = "Ahmed";
            c2.LastName = "Mohamady";


            Console.WriteLine(c2.Equals(c)); 

            Console.ReadKey(true);
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is Customer)) return false;

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }
    }

}