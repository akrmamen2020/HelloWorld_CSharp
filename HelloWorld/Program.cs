using System;

public class Student
{
    int ID;
    string Name;
    int PassMark = 50;

    public int _ID
    {
        get
        {
            return ID;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Cann't Accept this");
            }
            else
            {
                this.ID = value;
            }
        }
    }

    public string _Name
    {
        get
        {
            return Name;
        }
        set
        {
            if (value == null)
            {
                Console.WriteLine("Cann't Accept this");
            }
            else
            {
                Name = value;
            }
        }
    }

    public int PassMark1
    {
        get
        {
            return PassMark;
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student._ID = -101;
        student._Name = "Ahmed Moahamdy";
        Console.WriteLine(student.PassMark1);

        Console.ReadKey(false);
    }
}


