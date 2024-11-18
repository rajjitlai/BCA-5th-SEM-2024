using System;
namespace ReverseArray
{
    class Reversing
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 9, 1, 7, 3 };
            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array: ");
            foreach(int i in numbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}