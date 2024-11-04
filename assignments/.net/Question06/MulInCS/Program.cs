using System;

namespace MulInCS
{
    class FirstData
    {
        protected float length, breadth;
        public void setDim1(float l)
        {
            length = l;
        }
    }

    class SecondData : FirstData
    {
        public void setDim2(float b)
        {
            breadth = b;
        }
    }

    class Rectangle : SecondData
    {
        public float getArea()
        {
            return (length * breadth);
        }
    }

    class Program
    {
        public static void Main()
        {
            Rectangle data = new Rectangle();
            data.setDim1(22);
            data.setDim2(10);
            Console.WriteLine("The area of the rectangle is: {0}", data.getArea());
            Console.ReadKey();
        }
    }
}