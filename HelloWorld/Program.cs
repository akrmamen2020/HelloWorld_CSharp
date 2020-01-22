using System;


public class Employee
{
    public string FirstName = "Ahmed";
    public string LastName = "Mohamady";
    public string Address;

    public virtual void PrintEmpInfo()
    {
        Console.WriteLine(FirstName + "  " + LastName);
    }
}

public class FullTimeEmployee : Employee 
{
    public override void PrintEmpInfo()
    {
        base.PrintEmpInfo();
        Console.WriteLine(" {0} {1}   The Emp From Full Time", base.FirstName, base.LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintEmpInfo()
    {
        Console.WriteLine(" {0} {1}   The Emp From Part Time", base.FirstName, base.LastName);
    }
}

public class TempEmployee : Employee
{
    public override void PrintEmpInfo()
    {
        Console.WriteLine(" {0} {1}   The Emp From Temp", base.FirstName, base.LastName);
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new FullTimeEmployee();
        employees[2] = new PartTimeEmployee();
        employees[3] = new TempEmployee();

        foreach (Employee e in employees)
        {
            e.PrintEmpInfo();
        }

        Console.ReadKey(false);
 
    }
}


