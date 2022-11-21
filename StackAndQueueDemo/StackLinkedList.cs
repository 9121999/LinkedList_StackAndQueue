using StackAndQueueDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StacksAndQueueDemo
{
    public class StacksLinkedList
    {
        private Node top;
        public void  Stack()
        {
            this.top = null;
        }
        public void Push(int value) // add
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("After Pushed Element :" +temp.data + " ");
                temp = temp.next;
            }
        }
    }
}