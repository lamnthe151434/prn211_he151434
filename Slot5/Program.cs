using System;

namespace Slot5
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Record type
            Person p1 = new Person { Name = "Jack", Age = 25 };
            Person p2 = p1 with { Name = "John" };
            Person p3 = new();

            p1.Print();
            p2.Print();
            p3.Print();

            Console.WriteLine();

            Customer c1 = new Customer { Name = "Lam", Age = 10 };
            Customer c2 = new();
            c1.Print();
            c2.Print();
            Console.WriteLine();

            // 2. Interface
            MyClass mc = new MyClass();
            mc.Display();

            MyInterface mi = mc;
            mi.First();
            mi.Second();
            mi.Third();
            
        }
    }
}
