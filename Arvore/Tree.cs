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
    }
}
