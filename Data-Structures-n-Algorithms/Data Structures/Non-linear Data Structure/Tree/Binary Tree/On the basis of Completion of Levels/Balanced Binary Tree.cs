using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Non_linear_Data_Structure.Tree.Binary_Tree.On_the_basis_of_Completion_of_Levels
{
    public class Balanced_Binary_Tree
    {
        /* 
         
        A binary tree is balanced if the height of the tree i O(log n) where n is the number of nodes.
        For Example, the AVL tree maintains O(log n) height by making sure that the difference between
        the height of the left and right subtrees is at most 1. Red-Black trees maintain O(log n) height
        by making sure that the number of Black nodes on every root-to-leaf path is the same and that there 
        are no adjacent red nodes. Balanced Binary Search trees are performance-wise good as they provide
        O(log n) time for search, insert and delete.

        A single node is always balanced. It is also referred to as height-balanced binary tree.

        An empty tree (Root = null) is also always considered as balanced

        */

        /* 
        
        How to check if a Binary Tree is balanced?


        To check if a Binary tree is balanced we need to check three conditions:

        1. The absolute difference between height of left and right subtrees at any node should be less than 1.

        2. For each node, its left subtree should be a balanced binary tree.

        3. For each node, its right subtree should be a balanced binary tree.
         
        */

    }
}
