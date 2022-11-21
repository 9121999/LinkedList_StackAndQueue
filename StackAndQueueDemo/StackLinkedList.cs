using StackAndQueueDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class StacksLinkedList
    {
        private Node top;
        public StacksLinkedList()
        {
            this.top = null;
        }
        public void Push(int value)//add 
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
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the peek of the stack", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("{0} stack is empty ,deletion is not possible");
                return;
            }
            Console.WriteLine("value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
    }
}