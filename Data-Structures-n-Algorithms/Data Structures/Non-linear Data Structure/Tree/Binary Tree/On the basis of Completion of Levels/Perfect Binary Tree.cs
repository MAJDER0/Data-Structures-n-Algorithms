using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_Completion_of_Levels
{
    public class Perfect_Binary_Tree
    {
        //A perfect binary tree is a special type of binary tree in which all the leaf nodes are at the same depth
        //and all non-leaf nodes have two children. In simple terms, this means that all leaf nodes at the maximum depth of the tree
        //and the tree is completly filled with no gaps

        //The maximium of nodes in a perfect binary tree is given by the formula 2^(d+1)-1 where d is the depth of the tree
        //This means that a perfect binary tree with a depth of n has 2^n leaf nodes and a total of 2^(n+1)-1 nodes.

        //Perfect binary trees have a number of useful properties that make them useful in various applications. 
        //For example, they are often used in the implementation of heap sort data structures, as well as in the construction of
        //threaded binary trees. They are also used in the implementation of algorithms such as heap sort or merge sort.
        //In other words, it can be said that each level of the tree is completely filled by the nodes.

        /*
        
        Degree: The degree of a node of a tree is defined as the number of children of that node. All the internal nodes have a degree of 2.
        The leaf nodes of a perfect binary tree have degree of 0.

        Number of leaf nodes: If the height of the perfect binary tree is h, then the number of leaf nodes will be 2^h because the last level is 
        completely filled.

        Depth of a node: Average depth of a node in a perfect in binary tree is O(ln(n))

        Relation between leaf nodes and non-leaf nodes: Number of leaf nodes = number of non-leaf nodes + 1.

        Total number of nodes: A tree of height h has total nodes = 2^(h+1) - 1. Each node of the tree is filled.
        So total number of nodes can be calculated as 2^0 + 2^1 + 2^2 + ... + 2^h = 2^(h+1) - 1.
        
        Height of the tree: The height of a perfect binary tree with N number of nodes = log(N+1) - 1 = O(ln(n))
        This can be calculated using the relation shown while calculating the total number of nodes in a perfect binary tree. 

        */

        /*
          
        Summary

        All leaf nodes are at the same depth. In a perfect binary tree, all the leaf nodes are at the maximum depth of the tree.
        This means that the tree is compeletly filled with no gaps.

        All non-leaf nodes have two children. In a perfect binary tree, all non-leaf nodes have excatly two children.
        This means that the tree has a regular structure, with all nodes having either two children or no children.

        The maximum number of nodes is given by formula: The maximum number of nodes in a perfect binary tree is given by 
        the formula 2^(d+1) - 1 where d is the depth of the tree

        They have a symmetrical structure. This is because all non-leaf nodes have two children, perfect binary trees have
        a symmetrical structure

        They can be represented using an array. Perfect binary trees can be represented using an array, where the left
        child of a node at index i is stored at index 2i + 1 and the right child is stored at index 2i+2. This makes
        it easy to access the children of a node and to traverse the tree.

        */

        private Node root;
        public class Node {

            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public Perfect_Binary_Tree()
        {
            root = null; 
        }
    }
}
