using System;

namespace SinInCS
{
    interface ICourse
    {
        void PrintCourseName(string course);
        void DisplayCourseDuration(int duration);
    }

    class Document : ICourse
    {
        public void PrintCourseName(string course)
        {
            Console.WriteLine("The name of the course is: {0}", course);
        }

        public void DisplayCourseDuration(int duration)
        {
            Console.WriteLine("The duration of the course is: {0}", duration + " years");
        }
    }

    class Program
    {
        public static void Main()
        {
            Document doc = new Document();
            doc.PrintCourseName("BCA");
            doc.DisplayCourseDuration(4);

            Console.ReadKey();
        }
    }
}
