using System;

// Program to illustrate use of multiple namespace
namespace BCA
{
    class A
    {
        public void Msg() => Console.Write("Welcome to BCA");
    }

    class B
    {
        public static void Main(String[] args)
        {
            A obj = new A();
            obj.Msg();
            Console.Read();
        }
    }
}
