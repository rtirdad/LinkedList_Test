﻿using System;
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

// 2. Welke methods worden door alle objecten in .NET geïmplementeerd?
// all Objects implement, Equals, Finalize, GetHashCode, and ToString. 

//3.Kijk naar andere collecties in .NET( Dictionary<Tkey, TValue>, List<T>, HashSet<T>)
//Implementeren deze collecties allemaal IEnumerable?
// Dictionary<TKey, TValue> and List<T> and HashSet<T> all implement IEnumerable. This makes iteration possible.  
