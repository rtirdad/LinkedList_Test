using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace TestProject1
{
    internal interface ILinkedList<T> : IEnumerable<T>
    {
        object Add(T element);
        object InsertAt(int index, T element);
        object RemoveAt(int index);
        void ClearList();
        int IndexOf(T element);
        bool Contains(T element);
        void Remove(T element);
        T this[int index] { get; set; }
        T AtIndex(int index);
        void SetElement(int index, T element);
    }
}
