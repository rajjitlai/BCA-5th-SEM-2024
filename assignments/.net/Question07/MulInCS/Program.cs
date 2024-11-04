using System;

namespace MulInCS
{
    interface IPrintable
    {
        void Print(string course);
    }

    interface IDisplayable
    {
        void Display(int duration);
    }

 
    class Document : IPrintable, IDisplayable
    {
        public void Print(string course)
        {
            Console.WriteLine("The name of the course is: {0}", course);
        }

        public void Display(int duration)
        {
            Console.WriteLine("The duration of the course is: {0}", duration + " years");
        }
    }

    class Program
    {
        public static void Main()
        {
            Document doc = new Document();
            doc.Print("BCA");
            doc.Display(4);

            Console.ReadKey();
        }
    }
}
