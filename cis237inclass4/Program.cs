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
        }
    }
}
