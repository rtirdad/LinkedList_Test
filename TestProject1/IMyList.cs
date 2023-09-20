using System;
using System.Collections.Generic;
using System.Collections;


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

// 2. Welke methods worden door alle objecten in .NET geïmplementeerd?
//  

//3.Kijk naar andere collecties in .NET( Dictionary<Tkey, TValue>, List<T>, HashSet<T>)
//Implementeren deze collecties allemaal IEnumerable?
// Dictionary<TKey, TValue> and List<T> do implement IEnumerable,  but HashSet<T> does not. 
