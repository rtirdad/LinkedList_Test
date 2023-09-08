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
        public object AddLast(T element)
        {
            if (head == null)
            {
                this.head = new LinkedListNode<T>(element, head);
            }
             else
            {
                LinkedListNode<T> current = this.head;

                for (int i = 0; i < count - 1; i++)

                    current = current.Next;

                current.Next = new LinkedListNode<T>(element, current.Next);
            }

            count++;
            return element;
        }
    }
}
