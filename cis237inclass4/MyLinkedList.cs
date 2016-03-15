using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class MyLinkedList
    {
        // Node that will point to current node we are looking at
        public Node Current
        {
            get;
            set;
        }

        // Node that will point to beginning of linked list
        public Node Head
        {
            get;
            set;
        }

        // Node that will point to last Node in linked list
        public Node Tail
        {
            get;
            set;
        }

        // Constructor. Initialize properties to null
        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Current = null;
        }

        // this will be the add method to add a new node to list
        public void Add(string content)
        {
            // make new node
            Node node = new Node();

            // set the data for node to content that was passed in
            node.Data = content;

            // If head is null, there are no nodes in the linkin list
            // we are about to add the first node
            if (Head == null)
            {
                Head = node;
                //Tail = node;
            }
                // this is the case where there is already at least 1 node in the linked list, maybe many.
            else
            {
                // Take Tail Node, which is the lest one in list and set it's property which was null, to the new node we just created.
                Tail.Next = node;

                // valid replacement fore Tail = node, but might be harder to understand.
                //Tail = node;
            }

            // this was duplicated in both If and Else, so we moved it down here since it must be done for both of them.
            Tail = node;

        }
    }
}
