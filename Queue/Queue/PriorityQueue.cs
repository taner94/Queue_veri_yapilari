using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    public class PriorityQueue : IQueue
    {
        private int size = 0;
        private int count = 0; 
        private int front = -1;
        private object[] pq;
        public PriorityQueue(int Size)
        {
            this.size = Size;
            pq = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue is full!");
            if (IsEmpty())
            {
                front = 0;
                pq[front] = o;
            }
            else
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if ((int)o > (int)pq[i])
                        break;
                    else
                        pq[i + 1] = pq[i];
                }
                pq[i + 1] = o;
                front++;
            }
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty!");
            object temp = pq[front];
            pq[front] = null;
            front--;
            count--;
            return temp;
         }

        public object Peek()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty!");
            return pq[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
