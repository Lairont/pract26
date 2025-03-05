using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2.1, 3);
            Console.WriteLine($"{p1.ToString()}");
            Point p2 = new Point();
            Console.WriteLine($"{p2.ToString()}");
            Console.ReadLine();
        }
    }
}
