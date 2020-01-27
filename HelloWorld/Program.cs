using System;

class myCalss
{
    public int ID { get; set; }


    private string name; 
    public string Name {
        get {
            return name;
        }  set {
            name = value; 
        } }

    private int[] arr; 

    public int[] Arr
    {
        get { return arr; }
        set { arr = value; }
    }

    public int[] arr2 { get; set; }
}


class Program
{
    static void Main()
    {
        myCalss cls = new myCalss() { ID = 1, Name = "Ahmed"};
        myCalss cls2 = new myCalss() { ID = 2 };

        //cls.ID = 1;
        //cls.Name = "Ahmed";

        Console.WriteLine(cls.ID + "  " + cls.Name);

        Console.ReadKey(true);
    }
}


