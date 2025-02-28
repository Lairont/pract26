using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cars1 = new Car("БМВ", 1994);
            Console.WriteLine($"{cars1.ToString()}");
            Car cars2 = new Car("Мерседес", 1969);
            Console.WriteLine($"{cars2.ToString()}");
            Console.ReadLine();
        }
    }
}
