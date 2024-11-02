using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Dynamic_Data_Structure.Linked_List
{
    public class Doubly_Linked_List
    {

        private Node head = null;
        private class Node {
            public int Data { get; set; }
            public Node previousNode { get; set; }
            public Node nextNode { get; set; }
        }

        public Doubly_Linked_List()
        {
            head = null;
        }

        public void InsertAtBeginning(int data) {

            Node newNode = new Node();
            newNode.Data = data;

            if (head != null) {
                newNode.nextNode = head;
                newNode.Data = data;
                head.previousNode = newNode;
            }

            head = newNode;
        }

        public void InsertAtEnd(int data) {

            Node NewNode = new Node() { 
                nextNode = null,
                previousNode = null,
                Data = data 
            }; 

            if (head == null) {
                head = NewNode;
                return;
            }

            Node currentNode = head;

            while (currentNode.nextNode != null) {
                currentNode = currentNode.nextNode;
            }

            currentNode.nextNode = NewNode;

            NewNode.previousNode = currentNode;
        }

        public void InsertAtIndex(int index, int data) {

            if (head == null)
            {
                if (index == 0) {
                    InsertAtBeginning(data);
                }else {
                    return;
                }
                return;
            }

            if (index < 0) return;

            if (index == 0) {
                InsertAtBeginning(data);
                return;
            }

            Node currentNode = head;

            int counter = 0;

            while (currentNode.nextNode != null && counter < index - 1) {
                currentNode = currentNode.nextNode;
                counter++;
            }

            if (currentNode == null) return;


            Node node = new Node()
            {
                previousNode = currentNode,
                nextNode = currentNode.nextNode,
                Data = data
            };

            if (currentNode.nextNode != null) {
                currentNode.nextNode.previousNode = node;
            }

            currentNode.nextNode = node;
        }
    }
}
