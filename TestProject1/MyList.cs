/*using NUnit.Framework;
using System;
//using System.Collections.Generic;
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

        public int Count()
        { 
            return _list.Count;
        }

        public void InsertAt(int index, T element)
        {
           _list.InsertAt(index, element);
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

       public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        public void Remove(T element)
        {
            _list.Remove(element);
        }

        public T this[int index] { get => _list.AtIndex(index); set => _list.SetElement(index, value); }
    }
}*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1;

namespace TestProject1
{
    internal class MyList<T> : IMyList<T> , IEnumerable<T>
    {
        private LinkedListNode<T> head;
        LinkedList<T> _list = new LinkedList<T>();

        public void LinkedListNode()
        {
            this.head = null;
        }

        public int Count()
        {
            return _list.Count;
        }

        public void InsertAt(int index, T element)
        {
            _list.InsertAt(index, element);
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

        public bool Contains(T element)
        {
            return _list.Contains(element);
        }

        public void Remove(T element)
        {
            _list.Remove(element);
        }

        public T this[int index] { get => _list.AtIndex(index); set => _list.SetElement(index, value); }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}