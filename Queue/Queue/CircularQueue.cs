using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    public class CircularQueue : IQueue
    {
        private int size = 0;
        private int count = 0;
        private int front = -1;
        private int rear = -1;
        private object[] cq;
        public CircularQueue(int Size)
        {
            this.size = Size;
            cq = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue is full!");
            if (IsEmpty())
            {
                front = 0;
                rear = 0;
            }
            if (rear == size - 1)
                rear = 0;
            else
                rear++;
            
            cq[rear] = o;
            count++;
        }
        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            object temp = cq[front];
            cq[front] = null;

            if (front == size - 1)
                front = 0;
            else
                front++;

            count--;
            return temp;
        }
        public object Peek()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty");

            return cq[front];
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
