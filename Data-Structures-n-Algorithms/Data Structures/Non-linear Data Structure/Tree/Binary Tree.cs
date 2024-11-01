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


        //Properties of Binary Tree

        /*
         
        The maximum number of nodes ar level L of a Binary Tree is 2^L

        The maximum number of nodes in a Binary Tree of height H is 2^H - 1

        Total number of leaf nodes in a Binary Tree = total number of nodes with 2 children + 1

        In a Binary Tree with N nodes, the minimum possible height or the minimum number of levels is log2(N + 1)

        A Binary Tree with L leaves has at least |log2L| + 1 levels

        */


        //Types of Binary Tree

        /*
        
        On the basis of number of children: Full Binary Tree, Degenerate Binary Tree, Skewed Binary Tree

        On the basis of Completion of levels: Complete Binary Tree, Perfect Binary Tree, Balanced Binary Tree

        On the basis of Node values: Binary Search Tree, AVL Tree, Red Black Tree, B Tree, B+ Tree, Segment Tree

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


        // This is a general overview of a binary tree. There is no particular order of nodes

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

        //Delete node from the binary tree
        public void Delete(int value)
        {
            root = Delete(root, value);
        }

        private Node Delete(Node root, int value) {

            if (root == null) return null;

            Queue<Node> queue = new Queue<Node>();

            Node target = null;

            queue.Enqueue(root);

            while (queue.Count > 0) { 
                
                Node currentValue = queue.Dequeue();

                if (currentValue != null && currentValue.data == value) 
                    target = currentValue;

                if (currentValue.left != null) queue.Enqueue(currentValue.left);

                if (currentValue.right != null) queue.Enqueue(currentValue.right);
            }

            if (target == null) return root;

            Node lastParent = null;
            Node lastNode = null;

            Queue<(Node, Node)> NextQueue = new Queue<(Node, Node)>();

            NextQueue.Enqueue((root, null));

            while (NextQueue.Count > 0) {

                (Node currentNode, Node currentParent) = NextQueue.Dequeue();

                lastParent = currentParent;

                lastNode = currentNode;

                if (currentNode.left != null) NextQueue.Enqueue((currentNode.left, currentNode));
                if (currentNode.right != null) NextQueue.Enqueue((currentNode.right, currentNode));
            }

            target.data = lastNode.data;

            if (lastParent != null) {
                if (lastParent.left == lastNode) lastParent.left = null;
                else lastParent.right = null;
            }
            else {
                return null;
            }

            return root;
        }       
    }
}
