using System;

namespace JaggedArray
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[3][];
            jarr[0] = new int[5] { 10, 20, 30, 40, 50 };
            jarr[1] = new int[3] { 1, 2, 3 };
            jarr[3] = new int[] { 9, 7, 11, 13 };

            for (int i = 0; i < jarr.Length; i++)
            {
                Console.Write("Element {0}", i);
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    Console.Write("{0}", jarr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
