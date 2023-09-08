using TestProject1;

namespace TestProject1
{
    internal class MyList<T> : IMyList<T>

    {
        private int count;
        private LinkedListNode<T> head;
        LinkedList<T> _list = new LinkedList<T>();


        public void LinkedListNode()
        {
            this.head = null;
            this.count = 0;
        }

        public bool Empty { get { return this.count == 0; } }
        //public int Count { get { return this.count; } }

        bool IMyList<T>.Empty => throw new NotImplementedException();

        //int IMyList<T>.Count => throw new NotImplementedException();
        //public bool Empty { get { return this.count == 0; } }

        public int Count()
        { 
            return this.count;
        }

        public object Add(int index, T element)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index > count)
            {
                index = count;
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

        public void Add(T element)
        {
            _list.AddLast(element); // relace
        }

        public object Remove(int index)
        {
            if (index < 0)
            {
                throw (new ArgumentOutOfRangeException("index"));
            }

            if (this.Empty)
            {
                return null;
            }
            if (index >= count)
            {
                index = count - 1;
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


        public void Clear()
        {
            this.count = 0;
            _list.Clear();
        }

        public int IndexOf(T element)
        {
            LinkedListNode<T> current = this.head;

            for (int i = 0; i < this.count; i++)
            {
                if (current.Data.Equals(element))
                    return i;

                current = current.Next;
            }
            return -1;
        }

    }
}