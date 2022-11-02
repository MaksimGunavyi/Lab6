using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        var instance = MyFactory<MyType>.FacrotyMethod();

        Console.WriteLine(instance.GetType());
        Console.ReadKey();
    }
}