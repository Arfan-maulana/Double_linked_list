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

                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\n Duplicate number not allowed ");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                START = newNode;
                return;


                Node previous, current;
                for (current = previous = START;
                    current != null && nim >= current.noMhs;
                    previous = current, current = current.next)
                {
                    if (nim == current.noMhs)
                    {
                        Console.WriteLine("\n Duplicated roll numbers not alowed");
                        return;
                    }

                    
                }
                newNode.next = current;
                newNode.prev = previous;

                if(current == null)
                {
                    newNode.next = current;
                    previous.next = newNode;
                    return;
                }
                current.prev = newNode;
                previous.next = newNode;
            }
            public bool search(int rollNo, ref Node previous, ref Node current)
            {

                for(previous = current =START; current != null &&
                    rollNo != current.noMhs; previous = current,
                    current = current.next) { }
                return (current != null);
                    
            }
            public bool dellNode(int rollNo)
            {
                Node previous, current;
                previous = current = null;
                if (search(rollNo, ref previous, ref current)== false)
                    return false;
                if(current.next == null)
                {
                    previous.next = null;
                    return true;
                }
                // node beetwen two nodes in the ist
                if (current == START)
                {
                    START = START.next;
                    if (START != null)
                        START.prev = null;
                    return true;
                }
                
                previous.next = current.next;
                current.next.prev = previous;
                return true;
            }
            public bool listEmpty()
            {
                if (START == null)
                    return true;
                else
                    return false;

            }
            public void ascending()
            {

            }
            static void Main(string[] args)
            {

            }


        }
    }
}