using System;
namespace Test
{
    class Prog
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> ds = new Dictionary<int, string>();
            ds.Add(1, "Name");
            ds.Add(2, "Address");
            ds.Add(3, "Course");

            Dictionary<string, int> ds1 = new Dictionary<string, int>{
                {"msg1", 1}, {"msg2", 2}, {"msg3", 3}
            };

            Console.WriteLine("Displaying the elements of ds: ");
            foreach (KeyValuePair<int, string> item in ds)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine("\nDisplaying the elements of ds1: ");
            foreach (KeyValuePair<string, int> item in ds1)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}