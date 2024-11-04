using System;

namespace DictionaryCS
{
    class DictionaryProgram
    {
        Dictionary<string, string> WordCollection = new Dictionary<string, string>();

        public void AddWords()
        {
            WordCollection.Add("Beautiful", "Sweet and lovely");
            WordCollection.Add("Words", "Group of words");
            WordCollection.Add("Meaning", "Description or meaning of a word");
            WordCollection.Add("Function", "A block of code that performs a specific task");
        }

        public static void Main()
        {
            DictionaryProgram program = new DictionaryProgram();
            program.AddWords();

            Dictionary<string, int> Data = new Dictionary<string, int> { { "Emp1", 101 }, { "Emp2", 102 }, { "Emp3", 103 } };

            Console.WriteLine("Some word meanings:");
            foreach (var word in program.WordCollection)
            {
                Console.WriteLine($"Key: {word.Key}, Value: {word.Value}");
            }

            Console.WriteLine("\n");
            
            Console.WriteLine("Employee Number:");
            foreach(KeyValuePair<string, int> data in Data)
            {
                Console.WriteLine("Key: {0}, Value: {1}", data.Key, data.Value);
            }

            Console.ReadKey();
        }
    }
}