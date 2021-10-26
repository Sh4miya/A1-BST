using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_BST
{
    class BST
    {
        public Node root;

        public BST() { root = null; } //makes the BST public to be called from other classes

        public Node insert(Node p) 
        {
            Node temp = root;
            if (temp == null)
            {
                root = p;
                return root; //check if the root is null
            }

            while (true)
            {
                if (p.num < temp.num) //if the root is smaller than the temp number, insert on the left left
                {
                    if (temp.left == null)
                    {
                        temp.left = p;
                        break;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null) //otherwise insert on the right
                    {
                        temp.right = p;
                        break;
                    }
                    temp = temp.right;
                }
            }
            return root;
        }

        public void printByLevel(Node root)
        {
            if (root == null) //checks if the root is null
                return;
            Queue<Node> q = new Queue<Node>(); //create a new queue to push the nodes into the BST
            q.Enqueue(root); //inserts the node first in first out

            while(true)
            {
                int nodeCount = q.Count; //counts the nodes
                if (nodeCount == 0) //if the count is 0 break the loop
                    break;

                while(nodeCount > 0) //while the count is not 0, check the tree and display the nodes if they are left or right
                {
                    Node node = q.Peek();
                    Console.Write(node.num + " ");
                    q.Dequeue();
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                    nodeCount--; //minus the node count once the nodes have been pushed to the left or right of the tree
                }
                Console.WriteLine();
            }
        }
    }
}
