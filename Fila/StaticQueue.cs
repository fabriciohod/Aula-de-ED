using System;

namespace Fila
{
    public class StaticQueue
    {
        private int first;
        private int lest;
        private int[] queue;

        public StaticQueue(int size)
        {
            queue = new int[size];
            first = 0;
            lest = -1;
        }

        public void Enqueue(int value)
        {
            if (lest == queue.Length - 1)
                return;

            else
            {
                lest++;
                queue[lest] = value;
                return;
            }
        }

        public void Dequeue()
        {
            if (lest == -1)
                return;

            else
            {
                first++;
                if (first > lest)
                {
                    first = 0;
                    lest = -1;
                }
            }
        }

        public int Peek()
        {
            return queue[first];
        }
    }
}
