using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree
{
    public class Binary_Tree
    {

        //Terminology

        /*
          
        Nodes - The fundamental part of a binary tree, where each node contains data
        and link to two child nodes

        Root - The topmost node in a tree is known as the root node. It has no parent
        and serves as the starting point for all nodes in the tree

        Parent Node - A node that has one or more child nodes. In a binary tree, each
        node can have at most two children

        Child Node - A node that is a descendant of another node (its parent)

        Leaf Node - A node that does not have any children or both children are null

        Internal Node - A node that has at least one child. This includes all nodes 
        except the root and the leaf nodes

        Depth of a Node - The number of edges from a specific node to the root node. 
        The depth of the root node is zero

        Height of a Binary Tree - The number of nodes from the deepest leaf node to 
        the root node

        */


        //Traversals


        /* 
         
        Depth-First Search (DFS) algorithms:
       
        DFS explores as far down a branch as possible before backtracking.
        It is implemented using recursion. The main traversal methods in DFS for 
        binary trees are: Preorder Traversal, Inorder Traversal, Postorder Traversal

        Depth-First Search (BFS) algorithms:

        BFS explores all nodes at present depth before moving on to nodes at the next depth level. 
        It is typically implemented using a queue. BFS in a binary search tree is commonly referred
        to as Level Order Traversal

        */

        private Node root;
        public class Node {

            public int data;

            public  Node left, right;

            public Node(int item) {

                data = item;
                left = right = null;
            }

        }

        public Binary_Tree()
        {
            root = null;
        }

        // In-order DFS: Left, Root, Right
        public void InOrderDFS() {
            InOrderDFS(root);
        }
        private void InOrderDFS(Node node) {
            if (node == null) return;
            InOrderDFS(node.left);         
            Console.Write(node.data + " ");  // Do anything with data e.g Display
            InOrderDFS(node.right);
        }

        // Pre-order DFS: Root, Left, Right
        public void PreOrderDFS() {
            PreOrderDFS(root);
        }
        private void PreOrderDFS(Node node) {
            if (node == null) return;
            Console.Write(node.data + " ");
            PreOrderDFS(node.left);
            PreOrderDFS(node.right);            
        }

        // Post-order DFS: Left, Right, Root
        public void PostOrderDFS() { 
            PostOrderDFS(root);
        }
        private void PostOrderDFS(Node node) {
            if (node == null) return;
            PostOrderDFS(node.left);
            PostOrderDFS(node.right);
            Console.Write(node.data + " ");
        }

        // BFS Level Order Traversal
        public void LevelOrderTraversalBFS() {
            LevelOrderTraversalBFS(root);
        }
        private void LevelOrderTraversalBFS(Node root) {
            if (root == null) return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0) {
                Node node = queue.Dequeue();

                Console.Write(node.data + " ");

                if(node.left != null) 
                    queue.Enqueue(node.left);

                if(node.right!=null)
                    queue.Enqueue(node.right);
            }
        }

        public void Add(int data) {

            if (root == null) {
                root = new Node(data);
                return;
            }

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root);

            while (queue.Count > 0) {

                Node currentNode = queue.Dequeue();

                if (currentNode.left == null) {
                    currentNode.left = new Node(data);
                    return;
                } else {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right == null) {
                    currentNode.right = new Node(data);
                    return;
                } else {
                    queue.Enqueue(currentNode.right);
                }
            }
        }

        //Search for the value in Binary Tree using DFS
        public bool SearchDFS(int value) {
           return SearchDFS(root, value);
        }
        private bool SearchDFS(Node root, int value) {

            if (root == null) return false;    

            if(root.data == value) return true;

            bool leftSubTree = SearchDFS(root.left, value);
            bool rightSubTree = SearchDFS(root.right, value);

            return leftSubTree || rightSubTree;
        }
    }
}
