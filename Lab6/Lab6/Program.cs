using System;
namespace Lab6_1;

class Program
{
    static void Main(string[] args)
    {
        MyList<int> mylist = new MyList<int>(5);
        mylist[0] = 1;
        Console.WriteLine("Ємкість числа: {0} ємкість елемента-ів", mylist.Capacity);
        Console.WriteLine("Список фактично дорівнює: {0} єлемента-ів", mylist.Count);
        mylist.Add(15);
        Console.WriteLine("Ємкість списка: {0} єлемента-ів", mylist.Capacity);

        Console.ReadKey();
    }
}
}