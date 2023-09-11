using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class LinkedList<T> : ILinkedList<T>
    {
        private int count;
        private LinkedListNode<T> head;
        public LinkedList() {
        
        }

        public int Count => count;
        public bool Empty { get { return Count == 0; } }
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
            count = 0;
        }

        public object RemoveAt(int index)
        {
            if (index < 0)
            {
                throw (new ArgumentOutOfRangeException("index"));
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
            return result;
        }

        public object AddAt(int index, T element)
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

        public int IndexOf(T element)
        {
            LinkedListNode<T> current = this.head;

            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(element))
                    return i;

                current = current.Next;
            }
            return -1;
        }
    }
}
