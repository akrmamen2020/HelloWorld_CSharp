using System;
using System.IO;


class Program
{
    static void Main()
    {

        bool userInSystem = true;

        try
        {

            if (userInSystem)
            {
                throw new UserInSystemException("the Error Msg");

            }
        }
        catch (UserInSystemException ex)
        {
            Console.WriteLine("Error :" + ex.Message);

        }

        try
        {
            Console.WriteLine("Enter the First Number :");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Secound Number :");
            int x2 = int.Parse(Console.ReadLine());

            int result = x1 / x2;

            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            try
            {
                StreamWriter st = new StreamWriter(@"D:\TEMP\Test1\Log.txt");
                st.WriteLine(ex.Message);
                st.Close();
                Console.WriteLine("There is an exception");
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.ReadKey(true);
    }


}

public class UserInSystemException : Exception
{
    public UserInSystemException(string msg) : base(msg)
    { 
    
    }

}




