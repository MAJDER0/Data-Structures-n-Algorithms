using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_node_value
{
    public class Binary_Search_Tree
    {
        //Binary Search Tree is a data structure used in computer science for organizing and storing data in a sorted manner. Binary search tree follows all properties
        //of binary tree and for every nodes, its left subtree contains values less than the node and the right subtree contains values greater than the node.
        //This hierarchical structure allows for efficient Searching, Insertion, and Deletion operations on the data stored in the tree.


        /*
         
           Properties of Binary Search Tree:    
        
           1. The left subtree of a node contains only nodes with keys less than the node's key.
           2. The right subtree of a node contains only nodes with keys greater than the node's key
           3. The left and right subtree each must also be a binary search tree
           4. There must be no duplicate nodes (BST may have duplicate values with different handling approaches) 

        */

        private Node root;

        public Binary_Search_Tree()
        {
             root = null;
        }

        public class Node {

            public Node left;
            public Node right;
            public int data;

            public Node(int data)
            {
                this.data = data;
            }

        }

        public void Add(int value) {

            if (root is null)
            { 
                root = new Node(value);
                return;
            }

            Node currentNode = root;

            while (currentNode != null) {

                if (currentNode.data > value)
                {
                    if (currentNode.left != null)
                    {
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        currentNode.left = new Node(value);
                        return;
                    }
                }
                else
                {
                    if (currentNode.right != null)
                    {
                        currentNode = currentNode.right;
                    }
                    else
                    {
                        currentNode.right = new Node(value);
                        return;
                    }
                }
            }       
        }
    }
}
