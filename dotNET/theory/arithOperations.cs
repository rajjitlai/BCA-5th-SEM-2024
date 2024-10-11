// operators in dotNET

using System;
namespace ArOperations
{
   class performOp
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is {0}", i + j);
            Console.WriteLine("The difference is {0}", i - j);
            Console.WriteLine("The product is {0}", i * j);
            Console.WriteLine("The quotient is {0}", i / j);
            Console.WriteLine("The remainder is {0}", i % j);
            Console.WriteLine("The increment of {0} is {1}", i, i++);
            Console.WriteLine("The decrement of {0} is {1}", i, i--);
        }
    }
}