using System;
namespace delegateEg
{
    // declaring delegate
    public delegate void dd(int x, int y);

    class A
    {
        public void addition(int a, int b)
        {
            Console.WriteLine("Addition = {0}", a+b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            dd obj2 = obj.addition;
            obj2(5, 10);
        }
    }
}