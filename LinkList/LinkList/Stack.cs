using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class Stack
    {
        LinkedList linkList;
        public Stack()
        {
            linkList = new LinkedList();
        }
        public void Push(Node node)
        {
            linkList.AddNode(node);
        }
        public void DisplayStack()
        {
            linkList.Display();
        }
        public void Top()
        {
            var val = linkList.Head;
            Console.WriteLine("\nTop" + val.data);
        }
        public void Pop(Node node)
        {
            Console.WriteLine("");
            linkList.Remove();
        }
    }
}