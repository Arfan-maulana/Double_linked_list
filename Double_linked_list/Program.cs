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
        }
        static void Main(string[] args)
        {

        }
    }
}
