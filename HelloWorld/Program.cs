using System;


interface IA
{
    void AMethod();
}

class A : IA
{
    public void AMethod()
    {

    }
}

interface IB
{
    void BMethod();
}

class B : IB
{
    public void BMethod()
    {

    }
}

class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void AMethod()
    {
        a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();
    }
}

class Program
{
    static void Main()
    {
        IA ai = new AB();
        ai.AMethod();

    }
}


