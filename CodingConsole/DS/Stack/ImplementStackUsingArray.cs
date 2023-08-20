using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.DS.Stack
{
    public class Stack<T>
    {
        private T[] items;
        private int top;
        public Stack(int capacity)
        {
            items = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if(top == items.Length-1)
            {
                throw new InvalidOperationException("Stack in Full");
            }
            items[++top] = item;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top--];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public int Count()
        {
            return top + 1;
        }
    }
}
