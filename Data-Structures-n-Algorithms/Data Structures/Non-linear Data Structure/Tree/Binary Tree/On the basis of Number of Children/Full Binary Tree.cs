using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_Number_of_Children
{
    public class Full_Binary_Tree
    {
        //A full binary tree is a binary tree with either zero or two child nodes for each node. 
        //A full binary tree, does not have any nodes that have only one child node.

        private Node root;

        public class Node {
            public Node left;
            public  Node right;
            public int data;

            public Node(int item)
            {
                this.data = item;
                left = null;
                right = null;
            }
        }

        public Full_Binary_Tree() {
            root = null;
        }

        //Add method that adds nodes in pairs to maintain the full binary tree property
        public void Add(int FirstData, int SecondData) {

            if (root == null) { 
                root = new Node(FirstData);
                root.left = new Node(SecondData);
                root.right = new Node(SecondData);
                return;
            }

            //Find the first Node with 0 Children

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0) {
                
                Node currentNode = queue.Dequeue();

                if (currentNode.left == null && currentNode.right == null) {
                    currentNode.left = new Node(FirstData);
                    currentNode.right = new Node(SecondData);
                    return;
                } else {
                    if (currentNode.left != null) 
                        queue.Enqueue(currentNode.left);

                    if(currentNode.right != null)
                        queue.Enqueue(currentNode.right);                   
                }
            }
        }

        //Deletes a leaf node and ensures the parent doesn't end up with only one child
        public void Delete(int value) {
            if (root == null) return;

            if (root.left == null && root.right == null) {
                if (root.data == value)
                    root = null;
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            Node nodeToDelete = null;
            Node parent = null;

            while (queue.Count > 0) {

                Node currentNode = queue.Dequeue();

                if (currentNode.left != null) {

                    if (currentNode.left.data == value && currentNode.left.left == null && currentNode.left.right == null)
                    {
                        nodeToDelete = currentNode.left;
                        parent = currentNode;
                        break;
                    }
                    else { 
                        queue.Enqueue(currentNode.left);                 
                    }
                }

                if (currentNode.right != null)
                {

                    if (currentNode.right.data == value && currentNode.right.left == null && currentNode.right.right == null)
                    {

                        nodeToDelete = currentNode.right;
                        parent = currentNode;
                        break;

                    }
                    else
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
            }

            if (nodeToDelete != null && parent != null) {

                if (parent.left == nodeToDelete)
                    parent.left = null;

                else if (parent.right == nodeToDelete)
                    parent.right = null;

                //Check if parent has only one child left, which violates the full binary tree property
                if ((parent.left == null && parent.right != null) || (parent.left != null && parent.right == null)) {

                    if (parent.left != null)
                        parent.left = null;
                    if(parent.right != null)
                        parent.right = null;

                }
            }
        }
    }
}
