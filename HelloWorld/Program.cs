using System;

class Customer
{
    protected int father;

}

class MyCustomer : Customer
{

    #region Fields
    private int ID;
    private int code;
    #endregion

    #region Properties
    public string name { get; set; }
    #endregion

    #region Methodes
    public void Print()
    {
        base.father = 1;
        getInformation(); 
    }
    private void getInformation()
    {
        ID = 1;
        code = 1;
        name = "ahmed";
        Console.WriteLine(ID + "  " + name); 
    }
    #endregion
}


class Program
{
    static void Main()
    {
        Customer c = new Customer(); 
        

        MyCustomer myCustomer = new MyCustomer();

        myCustomer.name = "";
        myCustomer.Print();
        

        Console.ReadKey(true);
    }
}




