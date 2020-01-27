using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader streamReader = null;
        try
        {

            streamReader = new StreamReader(@"D:\TEMP\Test2\Welcome.txt");
            Console.WriteLine(streamReader.ReadToEnd());

        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("===========================");
            Console.WriteLine(ex.FileName);
            Console.WriteLine("===========================");
            Console.WriteLine(ex.StackTrace);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("===========================");
            Console.WriteLine(ex.StackTrace);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("===========================");
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            if (streamReader != null)
                streamReader.Close();
        }

        Console.WriteLine("New Task");

            Console.ReadKey(true);
    }


}




