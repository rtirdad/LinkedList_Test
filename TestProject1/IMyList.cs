using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    interface IMyList<T>
    {
        //int Count();
        bool Empty { get; }
        object AddAt(int index, T element);
        object RemoveAt(int index);
        void Clear();
        int IndexOf(T element);

    }
}
