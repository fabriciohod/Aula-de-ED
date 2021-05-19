using System;
using static System.Console;

namespace Pilha
{
    public class DinamicStack
    {
        public Node top;

        public DinamicStack()
        {
            top = null;
        }

        public void Push(int value)
        {
            Node newNode = new();

            newNode.value = value;
            newNode.nextNode = top;
            top = newNode;
        }

        public int? Pop()
        {
            Node temp;

            if (top is null)
            {
                WriteLine("Pilha vazia");
                return null;
            }

            else
            {
                temp = top;
                top = temp.nextNode;
                return temp.value;
            }
        }

        public int? Peek()
        {
            if (top is null)
            {
                WriteLine("pilha vazia");
                return null;
            }

            else
                return top.value;
        }


    }
}
