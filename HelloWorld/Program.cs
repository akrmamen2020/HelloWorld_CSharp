using System;

class Employee
{
    public int ID { get; set; }
    public String Name { get; set; }
    public Double Salary { get; set; }
    public int Experience { get; set; }

    public static void UpdateSalary(Employee[] emps , needUpdated NeedUpdated)
    {
        foreach (Employee emp in emps)
        {
            if (NeedUpdated(emp))
            {
                Console.WriteLine(" The Employee {0} is Updated ", emp.Name);
            }
        }
    }
}

delegate bool needUpdated(Employee emp);

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];
        employees[0] = new Employee() { ID = 1, Name = "Ahmed", Experience = 6, Salary = 50000 };
        employees[1] = new Employee() { ID = 2, Name = "Mohmaed", Experience = 2, Salary = 20000 };
        employees[2] = new Employee() { ID = 3, Name = "Salah", Experience = 4, Salary = 10000 };
        employees[3] = new Employee() { ID = 4, Name = "Ali", Experience = 5, Salary = 30000 };

        needUpdated nu = new needUpdated(isNeedUpdate);

        Employee.UpdateSalary(employees, nu);
        
        Console.ReadKey(true);
    }


    public static bool isNeedUpdate(Employee emp)
    {
        if (emp.Experience >= 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


