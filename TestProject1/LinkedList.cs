using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public bool Empty { get { return this.count == 0; } }
        public int Count { get { return this.count; } }

        public object Add(int index, T element) 
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
        
            if(index > count)   
            {
                index = count;
            }

            Node<T> current = this.head;

            if(this.Empty || index == 0)
            {
                this.head = new Node<T> (element, this.head);
            }

            else
            {
                for(int i = 0; i < index - 1; i++)
                
                    current = current.Next;

                current.Next = new Node<T> (element, current.Next);

            }
            count++;
            return element;

        }
        
        public object Add(T element)
        {
            return this.Add(count, element);
        }

        public object Remove(int index)
        {
            if(index < 0)
            {
                throw (new ArgumentOutOfRangeException("index"));
            }

            if (this.Empty)
            {
                return null;
            }
            if (index >= count)
            {
                index = count -1;
            }
            Node<T> current = this.head;
            object result = null;
            
            if(index == 0)
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

        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(T element)
        {
            Node<T> current = this.head;

            for(int i=0; i < this.count; i++)
            {
                if (current.Data.Equals(element))
                    return i;

                current = current.Next;
            }
            return -1;
        }

        public bool Contains(T element)
        {
            return this.IndexOf(element) != -1;
        }
    }

}
