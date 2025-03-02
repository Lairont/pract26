using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Point
    {
        private double x;
        private double y;
        private static int count;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public static int Count { get => count; set => count = value; }

        public Point()
        {
            X = 1.0;
            Y = 1.0;

        }
        static Point()
        {
            Count = 0;
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
            Count++;
        }

    }
}
