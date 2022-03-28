using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Queue
    {
        LinkedList linklist;

        public Queue()
        {
            linklist = new LinkedList();
        }

        public void Enqueue(Node node)
        {
            linklist.AddNode(node);
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Queue: ");
            linklist.Display();
        }

        public void Top()
        {
            var val = linklist.Head;
            Console.WriteLine("\nTop" + val.data);
        }
    }
}
