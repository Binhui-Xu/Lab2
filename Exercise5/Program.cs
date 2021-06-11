using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            box1.setHeight(2);
            box1.setBreadth(4);
            box1.setLength(6);
            
            box2.setHeight(1);
            box2.setBreadth(2);
            box2.setLength(3);

            box3.setHeight(10);
            box3.setBreadth(5);
            box3.setLength(20);

            double volume = box1.getVolume();
            Console.WriteLine("Volume of Box1: {0}", volume);
            volume = box2.getVolume();
            Console.WriteLine("Volume of Box2: {0}", volume);
            volume = box3.getVolume();
            Console.WriteLine("Volume of Box3: {0}", volume);
        }
    }
    class Box
    {
        public double length;
        public double breadth;
        public double height;

        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
    }
}
