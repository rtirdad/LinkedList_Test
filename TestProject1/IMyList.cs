using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace TestProject1
{
    interface IMyList<T> : IEnumerable<T>
    {
        void InsertAt(int index, T element);
        void RemoveAt(int index);
        void Clear();
        int IndexOf(T element);
        void Add(T element);
        bool Contains(T element);
        void Remove(T element);
    }

}

