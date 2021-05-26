using System;

namespace Arvore
{
    public class NoBinNode
    {
        public int value;
        public NoBinNode left = null;
        public NoBinNode right = null;

        public NoBinNode(NoBinNode right, int value ,NoBinNode left)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}
