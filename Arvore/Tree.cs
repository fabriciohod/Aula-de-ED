using System;

namespace Arvore
{
    public class Tree
    {
        public Tree Right;
        public char Info;
        public Tree Left;

        public Tree(Tree right, char info, Tree left)
        {
            Right = right;
            Info = info;
            Left = left;
        }

        public Tree SearchTree(Tree root, char element)
        {
            Tree result;

            if (root is null)
                return null;

            else
            {
                if (root.Info == element)
                    return root;

                else
                {
                    result = SearchTree(root.Right, element);

                    if (result is null)
                    {
                        result = SearchTree(root.Left, element);
                    }
                }
            }

            return result;
        }

        public static void PercorrerPreFixado(Tree _tree)
        {
            if(_tree is null)
                return;

            Console.Write($"{_tree.Info} | ");
            PercorrerPreFixado(_tree.Right);
            PercorrerPreFixado(_tree.Left);
        }

        public static void PercorrerInFixado(Tree _tree)
        {
            if(_tree is null)
                return;

            PercorrerInFixado(_tree.Right);
            Console.Write($"{_tree.Info} | ");
            PercorrerInFixado(_tree.Left);
        }
        public static void PercorrerPosFixado(Tree _tree)
        {
            if(_tree is null)
                return;
            
            PercorrerInFixado(_tree.Right);
            PercorrerInFixado(_tree.Left);
            Console.Write($"{_tree.Info} | ");
        }
    }
}
