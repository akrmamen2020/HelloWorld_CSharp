using System;


public class Employee
{
    public string FirstName;
    public string LastName;
    public string Address;


    public Employee()
    {
        Console.WriteLine("Emp Cons");
    }

    public Employee(string key)
    {
        Console.WriteLine("Emp Cons : key is {0} " , key);
    }

    public void PrintEmpInfo()
    {
        Console.WriteLine(FirstName + "  " + LastName);
    }
}


public class FullTimeEmployee : Employee 
{

    public FullTimeEmployee() : base("Ahmed")
    {
        Console.WriteLine("Full Emp Cons");
    }

    public float theSalary; 
}

public class PartTimeEmployee : FullTimeEmployee
{
    public float thePartSalary;

}


class Program
{
    static void Main()
    {
        FullTimeEmployee emp1 = new FullTimeEmployee();
        emp1.FirstName = "ahmed";
        emp1.LastName = "mohamady";
        emp1.Address = "asdasdasda";
        emp1.theSalary = 100.0F;
        emp1.PrintEmpInfo();


        PartTimeEmployee emp2 = new PartTimeEmployee();
     



        Console.ReadKey(false);
 
    }
}


