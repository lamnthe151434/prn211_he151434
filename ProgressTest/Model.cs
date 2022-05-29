using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest
{
    interface IPerson
    {
        public void Hello();
    }


    class Person : IPerson, IComparable<Person>
    {
        public Person()
        {
        }

        public Person(int id, string name, int age, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public int CompareTo(Person other)
        {
            throw new NotImplementedException();
        }

        public void Hello()
        {
            Console.WriteLine("Hello!");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Address: {Address}";
        }

    }

   

}
