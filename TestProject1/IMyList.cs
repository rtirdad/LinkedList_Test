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
        void InsertAt(int index, T element);
        void RemoveAt(int index);
        void Clear();
        int IndexOf(T element);
        void Add(T element);
        bool Contains(T element);
        void Remove(T element);
    }

}

// 2. You can also use other data structures like Array or List or stack to implement this interface. 

//3.  Advantages of implementing these other Data Structures in this, would be code reusuability, when following the DRY rule,
// you want to write as little copy of the same code if possible so that it in easier to maintain.

// 4. When using generic, I can use various data types, this would be very beneficial because in this code I am
// working with LinkedLists, and thus generics makes it so that i can make the list with Int, String, or more without having to 
// write differnt codes to execute that. 
