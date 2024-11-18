using System;

namespace SortArray
{
    class Sorting
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 2, 9, 1, 7, 3 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted array: ");
            foreach (int number in numbers) { 
                Console.Write(number + " ");
            }
        }
    }
}