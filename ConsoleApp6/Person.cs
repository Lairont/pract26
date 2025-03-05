using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Person
    {
        private int age;
        static private int retirementAge = 60;

        public Person() { }
        public Person(int age) { this.Age = age; }

        static public int RetirementAge
        {
            get { return retirementAge; }
            set
            {
                if (value < 1)
                {
                    retirementAge = 1;
                }
                else if (value > 100)
                {
                    retirementAge = 100;
                }
                else retirementAge = value;
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void CheckAge(int age)
        {
            if (age <= retirementAge)
            {
                Console.WriteLine($"Осталось {retirementAge - age} лет до пенсии");
            }
            else
            {
                Console.WriteLine($"Уже на пенсии");
            }
        }
    }
}
