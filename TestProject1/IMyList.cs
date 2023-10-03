using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    interface IMyList<T>
    {
        int Count();
        void InsertAt(int index, T element);
        void RemoveAt(int index);
        void Clear();
        int IndexOf(T element);
        void Add(T element);
        bool Contains(T element);
        void Remove(T element);
    }

}

// 2. Zou je nog andere data structuren kunnen noemen die deze interface ook zouden kunnen implementeren?
// You can also use other data structures like array, list or stack to implement this interface. 

//3. Waarom zou je dit willen?
//Advantages of implementing these other Data Structures in this, would be code reusuability,
// you want to write as little copy of the same code if possible so that it in easier to maintain. 

// 4.Wat zijn de voordelen van generics in dit voorbeeld?
// When using generic, I can use various data types, this would be very beneficial because in this code I am
// working with LinkedLists, and when generics is used, it makes it so that I can make the list with Int, String, or more without having to 
// write differnt codes to execute that. 
