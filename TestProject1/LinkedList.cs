using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace TestProject1
{
    internal class LinkedList<T> : ILinkedList<T> , IEnumerable<T>
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
            else
            {
                LinkedListNode<T> current = head;// O(1)
                while (current.Next != null)// O(n)
                {
                    current = current.Next;
                }
                current.Next = newNode;// O(1)
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
            LinkedListNode<T> current = this.head;

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
                    return;
                }
                count--;// O(1)
                current = current.Next;// O(1)
            }
        }

        // O(n)
        public T AtIndex(int index)
        {
           if (index < 0) // O(1)
            {
                throw new ArgumentOutOfRangeException("index");
            }

           if (index  >= Count) // O(1)
            {
                index = count - 0; 
            }

            LinkedListNode<T> current = head; // O(1)
            
            for (int i = 0;i < index;i++) // O(n)
                current = current.Next;
            return current.Data;
                    
        }
        // O(n)
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

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator(this.head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

    /*using System;
    using System.Collections;
    using System.Collections.Generic;

    namespace TestProject1
    {
        internal class LinkedList<T> : ILinkedList<T>, IEnumerable<T>
        {
            // ... Other members of your LinkedList class ...

            public IEnumerator<T> GetEnumerator()
            {
                return new LinkedListEnumerator(this.head);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private class LinkedListEnumerator : IEnumerator<T>
            {
                private LinkedListNode<T> current;
                private LinkedListNode<T> head;
                private bool isFirst = true;

                public LinkedListEnumerator(LinkedListNode<T> head)
                {
                    this.head = head;
                    current = null;
                }

                public T Current
                {
                    get
                    {
                        if (current == null)
                            throw new InvalidOperationException();

                        return current.Data;
                    }
                }

                object IEnumerator.Current => Current;

                public bool MoveNext()
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        current = head;
                    }
                    else
                    {
                        current = current.Next;
                    }

                    return current != null;
                }

                public void Reset()
                {
                    isFirst = true;
                    current = null;
                }

                public void Dispose()
                {
                }
            }
        }
    }*/




