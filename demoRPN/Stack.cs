using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoRPN
{
    class Stack<T>:iStack<T>
    {
        private int max, top;
        private T[] stack;
        public int Count;
        public Stack(int n = 0)
        {
            Init(n);
        }
        public void Init(int n)
        {
            max = n;
            stack = new T[max];
            Count = top = 0;
        }
        public void Push(T value)
        {
            stack[top] = value;
            if (Count < max) Count++;
            top = (top + 1) % max;
        }
        public T Pop()
        {
            if (top == 0) top = max - 1;
            else
                --top;
            T value = stack[top];
            Count--;
            return value;
        }
        public T Peek()
        {
            int a = 0;
            if (top == 0) top = max - 1;
            else
                a = top - 1;
            T value = stack[a];
            return value;
        }
    }
}
