using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int x)
        {
            this.x = x;
            this.y = x;
        }
    }

    class PointClass
    {
        public int x;
        public int y;
        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    struct PointStruct
    {
        public int x;
        public int y;
        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            //p.x = 10;
            //p.y = 20;
            Console.WriteLine("point: " + p.x + " / " + p.y);

            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA;
            pointClassB.x = 100;
            pointClassB.y = 200;
            Console.WriteLine("pointClassA : "
                + pointClassA.x + " / " + pointClassA.y);
            Console.WriteLine("pointClassB : "
                + pointClassB.x + " / " + pointClassB.y);

            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;
            pointStructB.x = 100;
            pointStructB.y = 200;
            Console.WriteLine("pointStructA : "
                + pointStructA.x + " / " + pointStructA.y);
            Console.WriteLine("PointStructB : "
                + pointStructB.x + " / " 
                + pointStructB.y);
        }
    }
}
