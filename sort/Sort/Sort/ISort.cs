using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public interface ISort<T>
    {
        void Sort(T[] array);
    }
}
