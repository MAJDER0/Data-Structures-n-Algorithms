using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_Completion_of_Levels
{
    public class Complete_Binary_Tree
    {
        //A complete binary tree is a special type of binary tree where all the levels of the tree are
        //filled completely except the lowest level nodes which are filled from as left as possible

        /* 
          
        Terminology of Complete Binary Tree:
        

        Root - Node in which no edge is coming from the parent

        Child - Node having some incoming edge is called child

        Sibling - Nodes having the same parent are sibling

        Degree of a node - Number of children of a particular parent

        Internal/External nodes - Leaf nodes are external nodes and non leaf nodes are internal nodes

        Level - Count nodes in a path to reach a destination node.

        Height - Number of edges to reach the destination node, Root is at height 0

        */

        /*
         
        Properties of Complete Binary Tree:


        A complete binary tree is said to be a proper binary tree where all leaves have the same depth

        In a complete binary tree number of nodes at depth d is 2^d

        In a complete binary tree with n nodes height of the tree is log(n+1)

        All the levels except the last level are completly full
          
        */

        private Node root;

        public class Node {

            public int data;
            public Node left;
            public Node right;

            public Node(int item) {
                this.data = item;
                left = null;
                right = null;
            }
        }

        public Complete_Binary_Tree()
        {
            root = null;
        }

        public void Add(int data)
        {

            if (root == null) {
                root = new Node(data);
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0) {

                Node currentNode = queue.Dequeue();

                if (currentNode.left == null)
                {
                    currentNode.left = new Node(data);
                    return;
                }
                else if (currentNode.right == null)
                {
                    currentNode.right = new Node(data);
                    return;
                }
                else {

                    queue.Enqueue(currentNode.left);
                    queue.Enqueue(currentNode.right);
                }
            }
        }

        public void Delete(int data) {

            if (root == null)
                return;
            
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node nodeToDelete = null;
            Node currentNode = null;

            while (queue.Count > 0) {

                 currentNode = queue.Dequeue();

                if (currentNode.data == data)
                    nodeToDelete = currentNode;

                if(currentNode.left != null)
                    queue.Enqueue(currentNode.left);

                if(currentNode.right != null)
                    queue.Enqueue(currentNode.right);
            }

            if (nodeToDelete != null) {
                int deepestNode = currentNode.data;
                DeleteDeepestnode(currentNode);
                nodeToDelete.data = deepestNode;
            }
        }

        private void DeleteDeepestnode(Node deepestNode) {

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0) {
                
                Node currentNode = queue.Dequeue();

                if (currentNode.left != null) {

                    if (currentNode.left == deepestNode)
                    {
                        currentNode.left = null;
                        return;
                    }else {                       
                        queue.Enqueue(currentNode.left);
                     }
                }

                if (currentNode.right != null) {

                    if (currentNode.right == deepestNode)
                    {
                        currentNode.right = null;
                        return;
                    }else {
                        queue.Enqueue(currentNode.right);
                     }              
                }
            }
        }
    }
}
