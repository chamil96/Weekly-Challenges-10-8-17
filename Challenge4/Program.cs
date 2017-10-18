//4. Make a class Vehicle with the properties Type, NumberOfTires, Year, and Model.
//Then write a constructor that takes in those 4 properties as parameters and sets the values of the properties.
//Once your constructor is complete create two instances of Vehicle, the first one should be your dream car and the second should be your i would hate car. 
//Finally display the model of your dream car and the model of your hate car.
using System;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle dreamCar = new Vehicle(4, 2008, "Sonata", "sedan");
            Vehicle nightmareCar = new Vehicle(4, 1990, "Camry", "sedan");
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public int NumberOfTires { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }

        public Vehicle(int numOfTires, int year, string model, string type)
        {
            Type = type;
            NumberOfTires = numOfTires;
            Model = model;
            Year = year;

        }

    }
}
