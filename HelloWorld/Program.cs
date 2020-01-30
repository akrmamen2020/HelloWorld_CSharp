using System;
using System.Reflection;


namespace theSystem
{
    class Customer 
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public Customer()
        {
            ID = 0;
            Name = "";
        }

        public Customer(int _ID, string _Name)
        {
            ID = _ID;
            Name = _Name;
        }

        public void PrintID()
        {
            Console.WriteLine("ID IS {0}", ID);
        }

        public string PrintName(string theName)
        {
            Console.WriteLine("Name is {0}", theName);
            return theName;
        }
    }

    class Program
    {
        static void Main()
        {
            Customer c = new Customer();
            //c.PrintName("Ahmed");

            Type t = c.GetType();
            object obj = Activator.CreateInstance(t);

            MethodInfo mi = t.GetMethod("PrintName");

            string[] prams = new string[] { "Ahmed Mohamady" };

            string theFullName = (string)  mi.Invoke(obj, prams);

            Console.WriteLine(" the Cating name is {0}  ", theFullName);

            Console.ReadKey(true);
        }
    }

}