using System.Collections.Generic;
using Pilha;
using Fila;
using System;

namespace Monitoria
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ED
            Console.WriteLine("Lista estática");
            StaticStack staticStack = new(5);
            staticStack.Push(1);
            staticStack.Push(2);
            staticStack.Push(3);
            staticStack.Push(4);
            staticStack.Push(5);

            staticStack.Pop();

            Console.WriteLine(staticStack.Peek());

            Console.WriteLine("Lista dinamica");
            DinamicStack dinamicStack = new();
            dinamicStack.Push(1);
            dinamicStack.Push(2);
            dinamicStack.Push(3);
            dinamicStack.Push(4);
            dinamicStack.Push(5);
            dinamicStack.Push(6);
            dinamicStack.Push(8);

            Console.WriteLine(dinamicStack.Peek());


            Console.WriteLine("Fila estática");
            StaticQueue staticQueue = new(5);

            staticQueue.Enqueue(5);
            staticQueue.Enqueue(4);
            staticQueue.Enqueue(3);
            staticQueue.Enqueue(2);
            staticQueue.Enqueue(1);

            staticQueue.Dequeue();
            Console.WriteLine(staticQueue.Peek());

            Console.WriteLine("Fila dinamica");
            DinamicQueue dinamicQueue = new();
            dinamicQueue.Enqueue(5);
            dinamicQueue.Enqueue(4);
            dinamicQueue.Enqueue(3);
            dinamicQueue.Enqueue(2);
            dinamicQueue.Enqueue(1);
            dinamicQueue.Enqueue(0);

            Console.WriteLine(dinamicQueue.size);
            Console.WriteLine(dinamicQueue.Peek() + "\n");
            #endregion
        }
    }
}
