using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersie1
{
    public class IntStack
    {
        private int maxSize = 10;
        private int top = 0;
        private int[] array = new int[10];

        public void Push(int value)
        {
            if (!IsFull())
            {
                array[top++] = value;
            }
            else
            {
                Console.WriteLine("Stack is full. Cannot push more elements.");
            }
        }

        public int Pop()
        {
            if (!IsEmpty())
            {
                return array[--top];
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot pop elements.");
                return -1; 
            }
        }

        public int Peek()
        {
            if (!IsEmpty())
            {
                return array[top - 1];
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot peek elements.");
                return -1;
            }
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == maxSize;
        }
        public int Count()
        {
            return top;
        }
    }
}
