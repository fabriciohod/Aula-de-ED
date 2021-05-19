using System;
using static System.Console;

namespace Pilha
{
    class StaticStack
    {
        private int[] stack;

        private int index;
        public StaticStack(int size)
        {
            stack = new int[size];
            index = 0;
        }

        public void Push(int value)
        {
            if (index > stack.Length - 1)
            {
                WriteLine("A sua pilha esta cheia");
                return;
            }

            stack[index] = value;
            index++;
        }

        public int? Pop()
        {
            if (index - 1 < 0)
            {
                WriteLine("A sua pilha esta vazia");
                return null;
            }
            int temp = stack[index - 1];

            index -= 1;

            return temp;
        }

        public int Peek() 
        {
            return stack[index -1];
        }
    }
}