using System;
using System.Text; 

namespace theSystem
{
    class Program
    {
        static void Main()
        {
            String sql = " Select * From Table ";
            sql += " where Col1 = 'asdsa' ";
            sql += " and Col2 = 10000  ";

            //Console.WriteLine(sql);

            StringBuilder sb = new StringBuilder("Select * From Table");
            sb.Append(" where Col1 = 'asdsa' ");
            sb.Append(" and Col2 = 10000  ");

            

            Console.WriteLine(sb +  sql); 

            Console.ReadKey(true); 
        }
    }
}