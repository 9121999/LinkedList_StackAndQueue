using LinkedListDemo;
using QueueINLinkedList;

namespace StacksAndQueueDemo
{
    public  class Program
    {
        public static void Main(string[]args)
        {
            // StacksLinkedList stacksLinkedList = new StacksLinkedList();
            // stacksLinkedList.Push(56);
            // stacksLinkedList.Push(30);
            // stacksLinkedList.Push(70);
            // stacksLinkedList.Peek();
            // stacksLinkedList.Pop();
            // stacksLinkedList.Display();
            LinkedListQueue  linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }

    }
}