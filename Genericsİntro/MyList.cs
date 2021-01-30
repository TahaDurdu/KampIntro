using System;
using System.Collections.Generic;
using System.Text;

namespace Genericsİntro
{
    class MyList<T>
    {
        T[] İtems;
        public MyList()
        {
            İtems = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = İtems;
            İtems = new T[İtems.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                İtems[i] = tempArray[i];
            }
            İtems[İtems.Length - 1] = item;
        }
    }
}
