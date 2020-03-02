using System;
using System.Text; 

namespace HelloWorld
{

    public class Father
    { 
    
    }


    public  partial  class Customer : Father
    {

        private string _firstName;
        private string _lastName; 

        public string LastName
        { 
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string getFullName()
        { 
          return FirstName + " " + LastName;
        }
    }


    class Program
    {
        static void Main()
        {
            //Customer c = new Customer();
            //c.sayHi();
            //c.newMethod();

            
 
            Console.ReadKey(true); 
        }
    }
}