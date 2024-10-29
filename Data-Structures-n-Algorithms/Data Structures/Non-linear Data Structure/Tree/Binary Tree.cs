using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree
{
    public class Binary_Tree
    {
        public class Node {

            public int data;

            public  Node left, right;

            public Node(int item) {

                data = item;
                left = right = null;
            }

        }

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
        
        // In-order DFS: Left, Root, Right
        public static void InOrderDFS(Node node) {
            if (node == null) return;
            InOrderDFS(node.left);         
            Console.WriteLine(node.data + " ");  // Do anything with data e.g Display
            InOrderDFS(node.right);
        }

        // Pre-order DFS: Root, Left, Right
        public static void PreOrderDFS(Node node) {
            if (node == null) return;
            Console.WriteLine(node.data + " ");
            PreOrderDFS(node.left);
            PreOrderDFS(node.right);            
        }

        // Post-order DFS: Left, Right, Root
        public static void PostOrderDFS(Node node) {
            if (node == null) return;
            PostOrderDFS(node.left);
            PostOrderDFS(node.right);
            Console.WriteLine(node.data + " ");
        }

        // BFS Level Order Traversal
        public static void LevelOrderTraversalBFS(Node root) {
            if (root == null) return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0) {
                Node node = queue.Dequeue();

                Console.WriteLine(node.data + " ");

                if(node.left != null) 
                    queue.Enqueue(node.left);

                if(node.right!=null)
                    queue.Enqueue(node.right);
            }
        } 
    }
}
