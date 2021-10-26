using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_BST
{
    class Node
    {
        public int num;
        public Node left, right; //create node and num variables

        public Node(int num) //set the node as int
        {
            this.num = num;
            left = null;
            right = null;
        }
    }
}
