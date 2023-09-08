using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Xml.Linq;
using TestProject1;

namespace TestProject1
{
    internal class MyList<T> : IMyList<T>
    {
        private int count;
        private LinkedListNode<T> head;
        LinkedList<T> _list = new LinkedList<T>();

         public void LinkedList()
        {
            head = null;
            count = 0;
        }

        public T this[int index] { get => AtIndex(index); set => SetElement(index, value); }

      
        public int Count()
        {
            return _list.Count;
        }

        public bool Empty()
        {
            return count == 0;
        }


        public void Add(T element)
        {
            _list.AddLast(element);

        }

        public void Clear()
        {
            _list.Clear();
            count = 0;
        }

        public bool Contains(T element)
        {
            foreach (var item in _list)
            {
                if (item.Equals(element)) return true;
            }
            return false;

        }

        public int IndexOf(T element)
        {
            int count = 0;
            foreach (var item in _list)
            {
                if (item.Equals(element)) return count;
                count++;
            }
            return -1;
        }

        public void Insert(int index, T element)
        {

            if (index < 0 || index > _list.Count)
            {
                return;
            }
            LinkedListNode<T> newNode = new LinkedListNode<T>(element);

            if (index == 0)
            {
                _list.AddFirst(newNode);
            }
            else if (index == _list.Count)
            {
                _list.AddLast(newNode);
            }
            else
            {
                LinkedListNode<T> current = _list.First;
                for (int i = 0; i < index; i++)
                {
                    if (current == null) return;
                    current = current.Next;
                }

                _list.AddAfter(current.Previous, newNode);
            }
        }
        public void Remove(T element)
        {
            RemoveAt(IndexOf(element));
        }
        public void RemoveAt(int index)
        {
            LinkedListNode<T> current = _list.First;
            for (int i = 0; i <= index && current != null; i++)
            {
                if (i != index)
                {
                    current = current.Next;
                    continue;
                }
                _list.Remove(current);
                count--;
            }
        }
        public T AtIndex(int index)
        {
            int count = 0;
            foreach (var item in _list)
            {
                if (index.Equals(count)) return item;
                count++;
            }
            throw new IndexOutOfRangeException();
        }

        public void SetElement(int index, T value)
        {
            if (index < 0 || index >= _list.Count)
            {
                throw new IndexOutOfRangeException();
            }

            LinkedListNode<T> current = _list.First;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Value = value;
        }

        public bool ContainsElement(T element)
        {
            return this.IndexOf(element) != -1;
        }

    }
}