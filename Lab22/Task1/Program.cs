using System;
using Task1;

class Program
{
    static void Main()
    {
        Singleton singleton = Singleton.GetInstance();
        singleton.ShowMessage();
    }
}
