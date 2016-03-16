using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.Add("First");
            myLinkedList.Add("Second");
            myLinkedList.Add("Third");
            myLinkedList.Add("Fourth");

            // Loop through with this differently looking for loop to output.
            // In here the first part is initialization: Setting X to the head.
            // The second part is the test: if x != null, keep going.
            // The last part is: Set the current x to x's next pointer. (The next in the List.)
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }

            Console.WriteLine();
            Console.WriteLine();

            // use the retrieve method to start at the head of the linked list, walk through it, and return the value that is passed in index.
            Console.WriteLine(myLinkedList.Retrieve(2));
            Console.WriteLine(myLinkedList.Retrieve(1));

            Console.WriteLine();
            Console.WriteLine();
            // Do some deletes of the linked list
            // this will delete the first one in the list
            myLinkedList.delete(0);
            // now there are 3, and this will delete the middle one
            myLinkedList.delete(1);
            // now there are 3, and this will delete the last one
            myLinkedList.delete(1);


            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }
        }
    }
}
