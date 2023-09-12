using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject1
{
    internal class LinkedList<T> : ILinkedList<T>
    {
        private int count;
        private LinkedListNode<T> head;
        public LinkedList() {
        }
        public int Count => count; // O(1)
        public bool Empty { get { return Count == 0; } } //O(1)

        public T this[int index] { get => AtIndex(index); set => SetElement(index, value); }



        // worst case scenario - O(n)
        public object AddLast(T element)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(element, head); // O(1)
            if (head == null) // O(1)
            {
                head = newNode;
            }

            
            else// O(n)
            {
                LinkedListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++; // O(1)
            return element; // O(1)

        }
        //O(1)
        public void ClearList()
        {
            count = 0;
        }

        // worst case scenario - O(n)
        public object RemoveAt(int index)
        {
            if (index < 0)  // O(1)
            {
                throw (new ArgumentOutOfRangeException()); 
            }
            if (this.Empty) // O(1)
            {
                return null;
            }
            if (index >= Count) // O(1)
            {
                index = Count - 1;
            }
            LinkedListNode<T> current = this.head; // O(1)
            object result = null;

            if (index == 0)  // O(1)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else // O(n)
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }
            count--; // O(1)
            return result; // O(1)
        }


        // worst case scenario - O(n)
        public object InsertAt(int index, T element)
        {
            if (index < 0) // O(1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index > Count) // O(1)
            {
                index = Count;
            }
            LinkedListNode<T> current = this.head; // O(1)

            if (this.Empty || index == 0) // O(1)
            {
                this.head = new LinkedListNode<T>(element, head);
            }
            else // O(n)
            {
                for (int i = 0; i < index - 1; i++)

                    current = current.Next;

                current.Next = new LinkedListNode<T>(element, current.Next);
            }
            count++; // O(1)
            return element; // O(1)
        }
      

        // worst case scenario - O(n)
        public int IndexOf(T element)
        {
            LinkedListNode<T> current = this.head;  // O(1)
            for (int i = 0; i < Count; i++) // O(n)
            {
                if (current.Data.Equals(element)) // O(1)
                    return i;

                current = current.Next;// O(1)
            }
            return -1;// O(1)
        }

        // worst case scenario - O(n)
        public bool Contains(T element)
        {
            LinkedListNode<T> current = this.head; ;

            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(element))
                    return true;

                current = current.Next;
            }
            return false;
        }

        // worst case scenario - O(n)
        public void Remove(T element)
        {
            if (head.Data.Equals(element)) // O(1)
            {
                head = head.Next;// O(1)
                return; // O(1)
            }

            LinkedListNode<T> current = head;// O(1)
            while (current.Next != null) // O(n)
            {
                if (current.Next.Data.Equals(element)) // O(1)
                {
                    current.Next = current.Next.Next; // O(1)
                    return;// O(1)
                }
                count--;// O(1)
                current = current.Next;// O(1)
            }
        }


        public T AtIndex(int index)
        {
           if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }

           /*if (this.Empty)
            {
                return null;
            }*/

           if (index  >= Count)
            {
                index = count - 0;
            }

            LinkedListNode<T> current = head;
            
            for (int i = 0;i < index;i++) 
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
