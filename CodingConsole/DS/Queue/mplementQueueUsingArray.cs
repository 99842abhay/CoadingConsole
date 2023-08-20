using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.DS.Queue
{
    public class Queue<T>
    {
        private T[] items;
        private int front;
        private int rear;
        private int capacity;
        private int count;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            items = new T[capacity];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(T item)
        {
            if (count == capacity)
            {
                throw new InvalidOperationException("Queue is Full");
            }
            rear = (rear + 1) % capacity;
            items[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = items[front];
            front = (front + 1) % capacity;
            count--;
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return items[front];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Count()
        {
            return count;
        }
    }
}
