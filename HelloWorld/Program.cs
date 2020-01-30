using System;

class Customr
{
    public int ID { get; set; }
    public string Name  { get; set; }
    public Gender _Gender { get; set; }
}

//0 - Unknown 
//1 - Male
//2 - Female

public enum Gender : short
{
    Unknown = 1,
    Male = 50,
    Female = 3
}

public enum alfa :short
{
    a = 1,
    b = 50,
    c = 3
}


class Program
{
    static void Main()
    {


        Customr[] customrs = new Customr[3];

        short[] values = (short[])Enum.GetValues(typeof(Gender));

        foreach (short i in values)
        {
            Console.WriteLine(i); 
        }

        Gender gender = (Gender)3;
        Console.WriteLine(gender);


        Gender g = (Gender) alfa.c;

        customrs[0] = new Customr() { ID = 1, _Gender = Gender.Unknown, Name = "adsasdas" };
        customrs[1] = new Customr() { ID = 2, _Gender = Gender.Male, Name = "Ahmed" };
        customrs[2] = new Customr() { ID = 3, _Gender = Gender.Female, Name = "Mona" };

        foreach (Customr c in customrs)
        {
            Console.WriteLine(" Name: {0}, Gender: {1} ", c.Name, getGender(c._Gender)); 
        
        }

        Console.ReadKey(true);
    }


    public static string getGender(Gender _Gender)
    {
        switch (_Gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid";
        }
    }
}




