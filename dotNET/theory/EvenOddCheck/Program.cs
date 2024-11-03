using System;

namespace ClassTest
{
    class Program
    {
        public int val;
        public bool calc(int x)
        {
            val = x;

            return val % 2 == 0;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            Console.Write("Enter a number: ");


            int num = int.Parse(Console.ReadLine());


            bool IsEven = obj.calc(num);

            if (IsEven)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
