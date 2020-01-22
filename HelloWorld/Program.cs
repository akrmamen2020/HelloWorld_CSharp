using System;


public class Employee
{
    public string FirstName;
    public string LastName;
    public string Address;

    public void PrintEmpInfo()
    {
        Console.WriteLine(FirstName + "  " + LastName);
    }
}

public class FullTimeEmployee : Employee 
{

}

public class PartTimeEmployee : Employee
{
    public new void PrintEmpInfo()
    {
        base.PrintEmpInfo();
        Console.WriteLine("The Emp From Part Time");
    }
}

class Program
{
    static void Main()
    {
        PartTimeEmployee PREP = new PartTimeEmployee();
        PREP.FirstName = "Ahmed";
        PREP.LastName = "Mohamady";
        PREP.PrintEmpInfo();

        Console.WriteLine("=============================");

        //((Employee)PREP).PrintEmpInfo();
        Employee PREP2 = new PartTimeEmployee();
        PREP2.FirstName = "Mohamed";
        PREP2.LastName = "Salah";
        PREP2.PrintEmpInfo();

        Console.ReadKey(false);
 
    }
}


