using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot5
{
   public interface MyInterface: IFirst, ISecond
    {

        void Third();
    }

    public interface IFirst
    {
        void First();
    }

    public interface ISecond {
        void Second()
        {
            Console.WriteLine("This is method of second interface!");
        }

    }

    public interface IFifth : ISecond
    {
        void ISecond.Second()
        {
            Console.WriteLine("This is method of fifth interface!");

        }
    }

    public class MyClass : MyInterface
    {

        public void Display()
        {
            Console.WriteLine("Display menu");
        }

        public void First()
        {
            Console.WriteLine("First Interface");
        }

        public void Second()
        {
            Console.WriteLine("Second Interface");
        }

        public void Third()
        {
            Console.WriteLine("Third Interface");
        }
    }

}
