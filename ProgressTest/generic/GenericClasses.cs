using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest
{

    // Contraint one paramter
    class PersonList<T> where T: Person, IPerson, System.IComparable<T>, new()
    {
        private List<T> list;

        public PersonList()
        {
            list = new();
        }

        public void Insert(T obj)
        {
            list.Add(obj);
        }

        public void Display()
        {
            foreach (var item in list)
            {
                item.ToString();
            }
        }

    }

    // Contraint Multiple paramater
    class Base
    {

    }
    class Exam<T, B> where T: struct where B: Base
    {

    }

    class MyClass<T>
    {
        public T Value { get; set; }

        public override string ToString() => $"Value: {Value}";

        public void Display<M, V> (M message, V value)
        {
            Console.WriteLine($"{message}: {value}");
        }

    }
}
