using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
         string model;
         int year;
        private static int totalCars = 0;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year;}
            set { year = value;}
        }
        public Car() { }
        public Car(string model, int year)
        {
            this.Model = model;
            this.Year = year;
            totalCars++;
        }
        public override string ToString()
        {
            return $"{model}\n{year}\n{totalCars}";
        }

    }
}
