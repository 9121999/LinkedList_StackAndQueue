namespace StacksAndQueueDemo
{
    public  class Program
    {
        public static void Main(string[]args)
        {
            StacksLinkedList stacksLinkedList = new StacksLinkedList();
            stacksLinkedList.Push(56);
            stacksLinkedList.Push(30);
            stacksLinkedList.Push(70);
            stacksLinkedList.Display();
        }

    }
}