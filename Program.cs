using System;
using Arvore;
using Pilha;
using Fila;

namespace Monitoria
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pilha
            Console.WriteLine("Pilha estática");
            StaticStack staticStack = new(5);
            staticStack.Push(1);
            staticStack.Push(2);
            staticStack.Push(3);
            staticStack.Push(4);
            staticStack.Push(5);

            staticStack.Pop();

            Console.WriteLine(staticStack.Peek());

            Console.WriteLine("Pilha dinamica");
            DinamicStack dinamicStack = new();
            dinamicStack.Push(1);
            dinamicStack.Push(2);
            dinamicStack.Push(3);
            dinamicStack.Push(4);
            dinamicStack.Push(5);
            dinamicStack.Push(6);
            dinamicStack.Push(8);

            Console.WriteLine(dinamicStack.Peek());
            #endregion

            #region Fila
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

            #region Arvore
            Tree treeE = new(null, 'E', null);
            Tree treeD = new(null, 'D', null);
            Tree treeG = new(null, 'G', null);
            Tree treeF = new(treeG, 'F', null);
            Tree treeB = new(treeD, 'B', treeE);
            Tree treeC = new(null, 'C', treeF);
            Tree root = new(treeB, 'A', treeC);

            root.SearchTree(root, 'G');

            Console.WriteLine("Pre-Fixado");
            Tree.PercorrerPreFixado(root);
            Console.WriteLine();
            Console.WriteLine("Pos-Fixado");
            Tree.PercorrerPosFixado(root);
            Console.WriteLine();
            Console.WriteLine("In-Fixado");
            Tree.PercorrerInFixado(root);
            #endregion

            #region Arvore nao binaria
            TreeNoBin treeNoBin = new(new NoBinNode(null, 4, null));


            treeNoBin.InsertNoBin(new NoBinNode(null, 1, null));


            treeNoBin.PercorrerPreFixado(treeNoBin.root);
            #endregion
        }
    }
}
