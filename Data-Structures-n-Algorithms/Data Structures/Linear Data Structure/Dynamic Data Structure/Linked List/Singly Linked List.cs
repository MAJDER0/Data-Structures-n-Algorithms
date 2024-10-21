using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Dynamic_Data_Structure.Linked_List
{
    public unsafe class Singly_Linked_List : IDisposable
    {

        private Node* head;
        private bool _disposed = false;

        private struct Node {

            public int Data;
            public Node* Next;

        }

        //Constructor 
        public Singly_Linked_List() {
            head = null;
        }

        //Insert at the head of list
        public void InsertAtHead(int data) {

            Node* newNode = (Node*)Marshal.AllocHGlobal(sizeof(Node));

            newNode->Data = data;
            newNode->Next = head;

            head = newNode;
        }

        public void Append(int data) {

            Node* newNode = (Node*)Marshal.AllocHGlobal(sizeof(Node));
            newNode->Data = data;
            newNode->Next = null;

            if (head == null) {

                head = newNode;
                return;

            }

            Node* current = head;

            while (current->Next != null) {

                current = current->Next;

            }

            current->Next = newNode;
        }

        public bool Remove(int data) {

            if (head == null)
                return false;

            Node* current = head;
            Node* previous = null;

            while (current != null) {

                if (current->Data == data) {

                    if (previous == null)
                    {

                        head = current->Next;

                    }
                    else {

                        previous->Next = current->Next;

                    }

                    Marshal.FreeHGlobal((IntPtr)current);
                    return true;
                }

                previous = current;
                current = current->Next;

            }

            return false;

        }

        public bool Find(int data) {

            Node* current = head;

            while (current != null) {

                if (current->Data == data)
                    return true;

                current = current->Next;

            }

            return false;
        }

        public void Reverse() {
        
            Node* previous = null;
            Node* current = head;
            Node* next = null;

            while (current != null) { 
            
                next = current->Next;
                current->Next = previous;
                previous = current;
                current = next;
                
            }

            head = previous;

        }

        public void Display() {

            Node* current = head;

            while (current != null) {

                Console.Write($"{current->Data} -> ");
                current = current->Next;

            }

            Console.WriteLine("null");

        }

        public void Dispose() {

            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing) {
        
            if (!_disposed) { 
                
                Node* current = head;

                while (current != null) {

                    Node* temp = current;
                    current = temp->Next;   
                    Marshal.FreeHGlobal((IntPtr)temp);
                
                }

                head = null;
                _disposed = true;
            
            }       
        }

        ~Singly_Linked_List() {
            Dispose(false);
        }
    }
}
