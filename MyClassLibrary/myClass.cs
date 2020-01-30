using System;

namespace MyClassLibrary
{
    public class myClass
    {

        public void Print()
        {
            Console.WriteLine("Hello From Public class Lib");
            myInternalClass _myInternalClass = new myInternalClass();
            _myInternalClass.IntPrint();

        }

    }

    internal class myInternalClass
    {

        public void IntPrint()
        { 
            Console.WriteLine("Hello From Internal class Lib");
        }
    }
}
