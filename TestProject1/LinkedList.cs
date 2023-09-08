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
        public int AddLast(T element)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            
        }
    }
}
