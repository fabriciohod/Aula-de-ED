using System;

namespace Arvore
{
    public class TreeNoBin
    {
        public NoBinNode root;

        public TreeNoBin(NoBinNode root)
        {
            this.root = root;
        }

        public void InsertNoBin(NoBinNode leaf)
        {
            root = Insert(root, leaf);
        }

        private static NoBinNode Insert(NoBinNode current, NoBinNode leaf)
        {
            if (current is null)
            {
                return leaf;
            }

            else if (leaf.value.CompareTo(current.value) > 0)
            {
                current.right = Insert(current.right, leaf);
            }

            else
            {
                current.left = Insert(current.left, leaf);
            }

            return current;
        }

        public void PercorrerPreFixado(NoBinNode root)
        {
            if (root is null)
                return;

            Console.Write($"{root.value} | ");
            PercorrerPreFixado(root.left);
            PercorrerPreFixado(root.right);
        }
    }
}
