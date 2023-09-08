using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal interface ILinkedList<T>
    {
        int AddLast(T element);
        void Clear();

    }
}
