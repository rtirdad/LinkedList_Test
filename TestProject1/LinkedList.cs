using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TestProject1
{
    public class LinkedList<T> : ILinkedList<T>, IEnumerable<T>, IEnumerable
    {
        private int count;
        private LinkedListNode<T> head;

        public int Count => count;

        public bool Empty => Count == 0;

        public T this[int index] { get => AtIndex(index); set => SetElement(index, value); }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GiveEnumerator();
        }

        public IEnumerator<T> GiveEnumerator()
        {
            return GetEnumerator();
        }

        public object AddLast(T element)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(element, head);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
            return element;
        }

        public void ClearList()
        {
            head = null;
            count = 0;
        }

        public object RemoveAt(int index)
        {
            if (index < 0)
            {
                throw (new ArgumentOutOfRangeException());
            }
            if (this.Empty)
            {
                return null;
            }
            if (index >= Count)
            {
                index = Count - 1;
            }
            LinkedListNode<T> current = this.head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }

        public object InsertAt(int index, T element)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index > Count)
            {
                index = Count;
            }
            LinkedListNode<T> current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new LinkedListNode<T>(element, head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)

                    current = current.Next;

                current.Next = new LinkedListNode<T>(element, current.Next);
            }
            count++;
            return element;
        }


        /*public int IndexOf(T element)
        {
            LinkedListNode<T> current = this.head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(element))
                    return i;

                current = current.Next;
            }
            return -1;
        }*/

        public int IndexOf(T element)
        {
            int index = 0;
            foreach (T item in this)
            {
                if (item.Equals(element))
                    return index;
                index++;
            }
            return -1;
        }


        public bool Contains(T element)
        {
            foreach(T item in this)
            {
                if(item.Equals(element))
                    return true;
            }
            return false;
        }

        public void Remove(T element)
        {
            if (head.Data.Equals(element))
            {
                head = head.Next;
                return;
            }

            LinkedListNode<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(element))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                count--;
                current = current.Next;
            }
        }

        public T AtIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }

            if (index >= Count)
            {
                index = count - 0;
            }

            LinkedListNode<T> current = head;

            for (int i = 0; i < index; i++)
                current = current.Next;
            return current.Data;

        }

        public void SetElement(int index, T element)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            LinkedListNode<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = element;
        }

    }
}