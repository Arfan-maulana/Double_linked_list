using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_linked_list
{
    internal class Program
    {
        class Node
        {
            //node class represent 

            public int noMhs;
            public string name;
            //point to the seucceding node
            public Node next;

            public Node prev;
        }

        class DoubleLinkedList
        {

            Node START;

            public DoubleLinkedList()
            {
                START = null;
            }

            public void addnote()
            {
                int nim;
                string nm;
                Console.WriteLine("\n Enter the roll number off the student :");
                nim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Enter name off the student :");
                nm = Console.ReadLine();
                Node newNode = new Node();
                newNode.noMhs = nim;
                newNode.name = nm;

                if((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\n Duplicate number not allowed ");
                    return;
                }
                newNode.next = START;
                    if(START != null)
                    START.prev = newNode;
                    START = newNode;
                    return;
                   
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
