// bitwise operators in C#
using System;
namespace BCA
{
    class BitWOperation
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("AND: {0} & {1} = {2}", i, j, i&j);
            Console.WriteLine("OR: {0} | {1} = {2}", i, j, i|j);
            Console.WriteLine("XOR: {0} ^ {1} = {2}", i, j, i^j);
            Console.WriteLine("NOT: ~{0} = {1}", i, ~i);
            Console.WriteLine("Left Shift: {0} << 1 = {1}", i, i << 1);
            Console.WriteLine("Right Shift: {0} >> 1 = {1}", i, i >> 1);
        }
    }
}

// Output
/*
Enter first number: 1
Enter second number: 0
AND: 1 & 0 = 0
OR: 1 | 0 = 1
XOR: 1 ^ 0 = 1
NOT: ~1 = -2
Left Shift: 1 << 1 = 2
Right Shift: 1 >> 1 = 0
 */