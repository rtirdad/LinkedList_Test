using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    interface IMyList<T>
    {
        int Count();
        bool Empty();
        void Clear();
        void Add(T element);
        int IndexOf(T element);
        bool Contains(T element);
        void Insert(int index, T element);
        void Remove(T element);
        void RemoveAt(int index);
        T this[int index] { get; set; }
        bool ContainsElement(T element);
        //int Count();
    }
}
