using System.Collections;

namespace stackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();  
            stack.Push("Hello");        
            stack.Push(120);
            stack.Push(13.23);

            Console.WriteLine("Stack Elements are:");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPopped Element: {stack.Pop()}");

            Console.WriteLine($"\nTop Element after Pop: {stack.Peek()}");
        }
    }
}
