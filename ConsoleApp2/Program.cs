using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст: ");
            int Age = int.Parse(Console.ReadLine());
            Person p1 = new Person(Age);
            p1.CheckAge(Age);
            Console.ReadLine();
        }
    }
}
