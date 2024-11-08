using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_Number_of_Children
{
    public class Degenerate_Binary_Tree
    {
        //Every non-leaf node has just one child in a binary tree known as a Degenerate Binary Tree
        //The tree effectively transforms into a linked list as a result, with each node linking to its single child


        //Degenerate binary trees are less effective than balanced binary trees at searching, inserting, and deleting data, though.
        //This is due to the fact that degenerate binary trees may become unbalanced, resulting in performance that is comparable to
        //a liked list in the worst case.


        //Degenerate binary trees are rarely employed by themselves as a data structure in general.
        //Rather, they are frequently utilized as a component of ther data structures like linked lists, stacks, and queues.
        //Degenerate binary trees can also be utilized as a particular instance to take into account in algorithms that traverse
        //or search over binary trees.

        /*
                 
         Degenerate Binary tree is of two types:

         Left-skewed Tree: If all the nodes in the degenerate tree have only a left child
         Right-skewed Tree: If all the nodes in the degenerate tree have only a right child

        */

        //Implementation for Right-skewed Tree

        private Node root;

        class Node {

            public int data;
            public Node left;
            public Node right;

            public Node(int item) {

                data = item;
                left = null;
                right = null;               
            }   
        }

        public Degenerate_Binary_Tree() {
            root = null;
        }

        public void Insert(int item) {

            if (root == null)
            {
                root = new Node(item);
                return;
            }

            Node currentNode = root;

            while (currentNode.right != null)
            {
                currentNode = currentNode.right;
            }

            currentNode.right = new Node(item);     
        }
    }
}
