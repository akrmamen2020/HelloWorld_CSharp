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

        public string PrintName()
        {
            Console.WriteLine("Name is {0}", Name);
            return Name;
        }
    }

    class Program
    {
        static void Main()
        {
            Type t = Type.GetType("theSystem.Customer");

            t = typeof(Customer);

            Customer c = new Customer();
            t = c.GetType();


            Console.WriteLine( t.Name  + " /// " +   t.FullName);
            
            Console.WriteLine("=========================================");
            Console.WriteLine("The Properties");
            PropertyInfo[] propertyInfos = t.GetProperties();

            foreach (PropertyInfo pi in propertyInfos)
            {
                Console.WriteLine(pi.PropertyType.Name + "  " + pi.Name);
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("The Methodes");
            MethodInfo[] methodInfos = t.GetMethods();

            foreach (MethodInfo mi in methodInfos)
            {
                Console.WriteLine(mi.ReturnType.Name + "  " + mi.Name);
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("The Cons");
            ConstructorInfo[] consInfos = t.GetConstructors();

            foreach (ConstructorInfo ci in consInfos)
            {
                Console.WriteLine(ci.ToString());
            }

            Console.ReadKey(true);
        }
    }

}