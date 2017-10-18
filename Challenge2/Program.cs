//2. Make a class car with the properties numberOfTires = 4, year = 2017, 
//and model = "insert your model of choice", and create three instances of it: car1, car2, and car3.
using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.numberOfTires = 4;
            car1.year = 2008;
            car1.Model = "Sonata";

            Car car2 = new Car();
            car2.numberOfTires = 4;
            car2.year = 2017;
            car2.Model = "Civic";

            Car car3 = new Car();
            car3.numberOfTires = 4;
            car3.year = 1990;
            car3.Model = "Corolla";

        }
    }

    class Car
    {
        public int numberOfTires { get; set; }
        public int year { get; set; }
        public string Model { get; set; }

    }
}
