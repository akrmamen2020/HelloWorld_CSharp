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

            Console.WriteLine("Hi " + getFullName()); 
        }

    }


}
