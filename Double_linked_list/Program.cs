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

                if (current == null)
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

                for (previous = current = START; current != null &&
                    rollNo != current.noMhs; previous = current,
                    current = current.next) { }
                return (current != null);

            }
            public bool dellNode(int rollNo)
            {
                Node previous, current;
                previous = current = null;
                if (search(rollNo, ref previous, ref current) == false)
                    return false;
                if (current.next == null)
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
                if (listEmpty())
                    Console.WriteLine("\nList is Empty");
                else
                {
                    Console.WriteLine("\nRecord in the ascending order of " + " roll number are :\n");
                    Node currentNode;
                    for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    { }

                    while (currentNode != null)
                    {
                        Console.Write(currentNode.noMhs + "" + currentNode.name + "\n");
                        currentNode = currentNode.prev;
                    }


                }
            }
            public void descending()
            {
                if (listEmpty())
                    Console.WriteLine("\nList is Empty");
                else
                {
                    Console.WriteLine("\nRecord in the ascending order of" + "roll number are:\n");
                    Node currentNode;
                    for (currentNode = START; currentNode != null; currentNode = currentNode.next) { }

                    while (currentNode != null)
                    {
                        Console.Write(currentNode.noMhs + "" + currentNode.name + "\n");
                        currentNode = currentNode.prev;
                    }

                }
            }
            class program
            {
                static void Main(string[] args)
                {
                    DoubleLinkedList obj = new DoubleLinkedList();
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("\nMenu");
                            Console.WriteLine("1. Add a record to the list ");
                            Console.WriteLine("2. Deleted a record from the list ");
                            Console.WriteLine("3. View all record in the ascending order of roll numbers ");
                            Console.WriteLine("4. View all record in the descending order of roll numbers ");
                            Console.WriteLine("5. Search for a record in the list ");
                            Console.WriteLine("6. Exit\n");
                            Console.WriteLine("Enter your choice (1-6): ");
                            char ch = Convert.ToChar(Console.ReadLine());
                            switch (ch)
                            {

                                case '1':
                                    {
                                        obj.addnote();
                                    }
                                    break;
                                case '2':
                                    {
                                        if (obj.listEmpty())
                                        {
                                            Console.WriteLine("\nList is empty");
                                            break;
                                        }
                                        Console.Write("\nenter the roll number of the student" + "whose record is to be deleted : ");
                                        int rolNo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine();
                                        if (obj.dellNode(rolNo) == false)
                                            Console.WriteLine("Record not found");
                                        else
                                            Console.WriteLine("record with roll number " + rolNo + "deleted \n");


                                    }
                                    break;
                                case '3':
                                    {
                                        obj.ascending();
                                    }
                                    break;
                                case '4':
                                    {
                                        obj.descending();
                                    }
                                    break;
                                case '5':
                                    {
                                        if (obj.listEmpty() == true)
                                        {
                                            Console.WriteLine("\nList is empty");
                                            break;
                                        }
                                        Node prev, curr;
                                        prev = curr = null;
                                        Console.Write("\nentr the roll number of the student whore record you want to search: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        if (obj.search(num, ref prev, ref curr) == false)
                                            Console.WriteLine("\n Record not found");
                                        else
                                        {
                                            Console.WriteLine("\n Record found");
                                            Console.WriteLine("\n Roll number : " + curr.noMhs);
                                            Console.WriteLine("\n Namw :" + curr.name);
                                        }
                                    }
                                    break;
                                case '6':
                                    return;
                                default:
                                    {
                                        Console.WriteLine("\nInvalid option");
                                    }
                                    break;


                            }

                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Check for the valueas entered");
                        }
                    }
                }
            }

        }
    }
}
