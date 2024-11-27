using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_Number_of_Children
{
    public class Skewed_Binary_Tree
    {
        //A skewed binary tree is a type of binary tree in which all the nodes have only either one child or no child

        //There are 2 special types of skewed tree:

        /* 
          
          Left Skewed Binary Tree:

          These are those skewed binary treed in which all the nodes are having a left child or no child at all. It is
          left side dominated tree. All the right children remain as null.

          Right Skewed Binary Tree:

          These are those binary trees in which all the nodes are having a right child or no child at all. It is a right 
          side dominated tree. All the left children remain as null

        */

        // Left Skewed Implementation

        private Node root;

        public Skewed_Binary_Tree()
        {
            root = null;
        }

        public class Node {

            public int data;
            public Node left;

            public Node(int value)
            {
                 data = value;
                 left = null;
            }
        }

        public void Add(int value) {

            if (root == null)
            { 
                root = new Node(value);
                return;
            }

            Node current = root;

            while (current.left != null)
            {
                current = current.left;
            }

            current.left = new Node(value);
        }
    }
}
