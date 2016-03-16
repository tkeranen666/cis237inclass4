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
        public string Retrieve(int position)
        {
            // Used as a temporary pointer to a spot within the linked list.
            Node tempNode = Head;

            // Used to hold the node at the index indicated by the passed in position.
            Node returnNode = null;

            // Counter to see where we are in the list.
            int counter = 0;

            // while oour tempNode is not at the end list.
            while (tempNode != null)
            {
                // if the count and the position match. This means that it will be zero based. If we wanted it to be 1 based,
                // we would need to subtract 1 from the position.
                if (counter == position)
                {
                    // Set the returnNode war to  the tempNode, which is the one we were looking for.
                    returnNode = tempNode;
                }
                // increment the count so that we actually move trhough the list
                counter++;

                // Set the tempNode to tempNode's next property, which will move us to the next node in linked list
                tempNode = tempNode.Next;
            }
            // we are going to use a tenerary operater to do a smaller version of an if.
            //This could easily be written as if / else. Essentially the part in the () is the test, and the part between the ? and the :
            // is what will happen if true.
            // the part after the : is what will happen when false.
            return (returnNode != null) ? returnNode.Data : null;
        }

        public bool delete(int position)
        {
            bool returnBool = false;
            // Set current to head
            Current = Head;

            // if the position we want to remove is the very first node, we need to do things different that if it is 1 thru end.
            // this part is equivilent to always removing from the front.
            if (position == 0)
            {
                // set the head to the current.next which will make the head point to the node at index 1, instead of index 0
                Head = Current.Next;

                // set the next property of the current to null so that the current (which was the old head) does not point to any other node.
                // this line is probably not required, but it doess illistrate how to clean up a node so it no longer points to anyuthing.
                Current.Next = null;

                // set the current (which was the old head) to null. Now that nod no longer exists and can be garbage collected
                Current = null;

                //check to see if the head is null, if so, tail musty become null as well, because in means we just deleted
                returnBool = true;
            }
            else
            {
                // set a tempnode to the first position in the linked list.
                Node tempNode = Head;
                
                // declare a orevious temp that will get a value after the tempnode moves
                Node previousTempNode = null;

                //start a counter to use to move through the linked list
                int count = 0;

                // loop until the tempnode is null, which means we are at the end.
                while (tempNode != null)
                {
                    // if we match the position and the count we are on, we found the one that we need to delete
                    if (count == position)
                    {
                        // set tje previous nodes next to the temp node's next
                        // jumping over the tempnode. the previous node's next
                        // will now point to the node after the tempnode
                        previousTempNode.Next = tempNode.Next;

                        // check to see if we are deleting the very last node in the list. if so we need to move the tail pointer
                        if (tempNode.Next == null)
                        {
                            // set the tail to previousTempnode, which is now in the new list
                            Tail = previousTempNode;
                        }

                        // we found the one to delete, so set the return bool to true.
                        returnBool = true;
                    }

                    // increment the count so we move through the linked list.
                    count++;

                    // set the previous tempnode to the current tempnode. this way when we move the tempnode forward, we will still have a pointer
                    // to where the tempnode was before it moved.
                    previousTempNode = tempNode;

                    // set the tempnode to the tempnode's next property, which will move it down the linked list one position.
                    tempNode = tempNode.Next;
                }
            }
            return returnBool;
        }
    }
}
