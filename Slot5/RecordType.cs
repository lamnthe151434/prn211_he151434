using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot5
{
    public record Person
    {
        public string Name { get; init; } = "New Customer";
        public int Age { get; init; } = 30;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }


  public class Customer
    {

        public Customer() { }
       
        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; } = "Thanh";
        public int Age { get; set; } = 20;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

   class RecordType
    {

    }
}
