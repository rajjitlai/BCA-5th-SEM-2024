using System;

namespace SinInCS
{
    public class Shape
    {
        protected float length, breadth, height;
        public void setDim(float l, float b, float h)
        {
            length = l;
            breadth = b;
            height = h;
        }
    }

    public class Cuboid : Shape
    {
        public float getVolume()
        {
            return (length * breadth * height);
        }
    }

    public class Program
    {
        static void Main()
        {
            Cuboid data = new Cuboid();
            data.setDim(24, 15, 30);
            Console.WriteLine("The Volume of the Cuboid is {0}", data.getVolume());
            Console.ReadKey();
        }
    }
}