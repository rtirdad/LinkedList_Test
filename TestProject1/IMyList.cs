using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    interface IMyList<T>
    {
        //int Count();
        void AddAt(int index, T element);
        void RemoveAt(int index);
        void Clear();
        int IndexOf(T element);
        void Add(T element);
        bool Contains(T element);
        void Remove(T element);

    }
}
