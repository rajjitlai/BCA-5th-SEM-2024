using System;
using System.Collections;

namespace ArrayListCS
{
    class ArrayListProgram
    {
        public static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add("This");
            list.Add("is");
            list.Add("BCA");
            list.Add(5 + "th");
            list.Add("Sem");
            list.Add("Assignment,");
            list.Add(2024);

            Console.WriteLine("Original ArrayList:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}