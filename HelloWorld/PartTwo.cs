using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{

    public class Father2
    { 
    
    }

    public  partial class Customer
    {

        public void sayHi()
        {
            string name = _firstName + " " + _lastName;
            theMethodP();
            Console.WriteLine("Hi " + getFullName()); 
        }

        partial void theMethodP()
        {
            Console.WriteLine("Hi P");
        }
    }


}
