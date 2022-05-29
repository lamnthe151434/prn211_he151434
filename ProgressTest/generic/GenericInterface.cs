using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest
{
    interface MyInterface<T> where T: struct
    {
        T Add(T a, T b);
    }

    class MyFirstClass : MyInterface<int>
    {
        public int Add(int a, int b) => a + b;

    }

    class MySecondClass : MyInterface<double>
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class MyThirdClass<T>
    {
        // null is assigned to set and 0 is assign to get
        public T Value { get; set; } = default(T);
    }
}
