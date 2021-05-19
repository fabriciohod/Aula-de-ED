using System;
using static System.Console;

namespace Fila
{
    public class DinamicQueue
    {
        public Node first;
        public int size;
        public Node lest;


        public DinamicQueue()
        {
            first = null;
            lest = null;
            size = 0;
        }


        public void Enqueue(int value)
        {
            Node newNode = new();
            newNode.value = value;
            newNode.nextNode = null;

            size++;

            if (lest is not null)
                lest.nextNode = newNode;

            if (first is null)
                first = newNode;
        }

        public int? Dequeue()
        {
            if (size == 0)
            {
                WriteLine("fila vazia");
                return null;
            }

            else
            {
                Node temp = first;
                first = first.nextNode;
                size--;

                return temp.value;
            }
        }

        public int Peek()
        {
            return first.value;
        }

        public void ReadQueue()
        {
            Node temp = first;

            if (first is null)
            {
                WriteLine("fila vazia");
                return;
            }

            else
            {
                while (temp is not null)
                {
                    WriteLine(temp.value);
                    temp = temp.nextNode;
                }
            }
        }
    }
}
