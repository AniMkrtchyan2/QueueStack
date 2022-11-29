using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStack
{
    public class MyQueue<T> 
    {

        public Stack<T> inbox;
        public Stack<T> outbox;
        private int size;

        public MyQueue()
        {
            inbox = new Stack<T>();
            outbox = new Stack<T>();
            
        }

        public void Enqueue(T item)
        {
            inbox.Push(item);
            size++;
        }

        public T Dequeue()
        {
            if (outbox.Count == 0)
            {
                while (inbox.Count != 0)
                {
                    outbox.Push(inbox.Pop());

                }
            }
            return outbox.Pop();
        }
        public int Size()
        {
            return size;
        }
        public bool isEmpty()
        {
            return size == 0;
        }

    }


}
