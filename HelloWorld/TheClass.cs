using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TheClass
    {
        MyCustomer customer = new MyCustomer();

        public void  setCustomerInfo()
        {
            customer.name = "Ahmed";
            customer.Print();
        

        }

    }
}
