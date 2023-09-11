using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1;

namespace TestProject1
{
    internal class MyList<T> : IMyList<T>

    {
        private LinkedListNode<T> head;
        LinkedList<T> _list = new LinkedList<T>();


        public void LinkedListNode()
        {
            this.head = null;
        }

        public bool Empty { get { return _list.Count == 0; } }
        //public int Count { get { return this.count; } }

        //bool IMyList<T>.Empty => throw new NotImplementedException();

        //int IMyList<T>.Count => throw new NotImplementedException();
        //public bool Empty { get { return this.count == 0; } }

        public int Count()
        { 
            return _list.Count;
        }

        public void AddAt(int index, T element)
        {
           _list.AddAt(index, element);
        }

        public void Add(T element)
        {
            _list.AddLast(element);
            
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public void Clear()
        {
            _list.ClearList();
        }

        public int IndexOf(T element)
        {
          return _list.IndexOf(element);
        }
    }
}