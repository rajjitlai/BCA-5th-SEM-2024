using System.Collections;

namespace queueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("Hello");  
            queue.Enqueue(120);
            queue.Enqueue(13.23);

            Console.WriteLine("Queue Elements are:");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nDequeued Element: {queue.Dequeue()}");

            Console.WriteLine($"\nFront Element after Dequeue: {queue.Peek()}");
        }
    }
}
