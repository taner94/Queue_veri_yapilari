using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    public class SimpleArrayTyepdQueue : IQueue
    {
        private int count = 0;
        private int size = 0;
        private int front = -1;
        private int rear = -1;
        private object[] q;
        public SimpleArrayTyepdQueue(int size)
        {
            this.size = size;
            q = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("q is full!");

            if (front == -1)
                front = 0;

            q[++rear] = o;
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("q is empty!");

            object temp = q[front];
            q[front] = null;
            front++;
            count--;
            return temp;
        }

        public object Peek()
        {
            if (IsEmpty())
                throw new Exception("q is empty!");

            return q[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}