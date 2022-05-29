using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest
{
    class MyCollectionClass<T> : IEnumerable where T : class, new()
    {
        private List<T> myList = new();

        public void AddItem(params T[] item) => myList.AddRange(item);
       
        IEnumerator IEnumerable.GetEnumerator() => myList.GetEnumerator();
    }
}
