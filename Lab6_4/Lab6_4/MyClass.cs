
using System;

namespace ConsoleApplication14
{
    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    public class MyType
    {
        public int a;

        public MyType(int a)
        {
            this.a = a;
        }

    }

    public class MyClass
    {
        public int Val { get; set; }
        public MyClass(int i)
        {
            Val = i;
        }
        public MyClass() { }
    }
}