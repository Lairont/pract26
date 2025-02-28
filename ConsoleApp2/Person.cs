using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        int age;
       public static int retirementAge = 60;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() { }
        public Person(int age)
        {
            this.Age = age;
        }
        public void CheckAge(int age)
        {
            if(age<=retirementAge)
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
