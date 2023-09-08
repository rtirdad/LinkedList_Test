using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class LinkedListNode<T>
    {
        private T data;
        private LinkedListNode<T> next;

        public LinkedListNode(T data, LinkedListNode<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public T Data
        {
            get { return data; }
            set { this.data = value; }
        }

        public LinkedListNode<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
