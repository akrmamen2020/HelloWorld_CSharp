using System;

class Program
{
    static void Main()
    {

        string str = null;

        int? availableTickets = null;

        int numberOfTickets;


        numberOfTickets = availableTickets ?? 0;

        Console.WriteLine(numberOfTickets);

        Console.ReadKey(true);
    }
}

