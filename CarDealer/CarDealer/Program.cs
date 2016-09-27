//
//Developer: Franklin Towett
//Project: CarDealer Console Application - Using Classes and Objects
//Class: IN2017
//Instructor: R Ray.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object from the car class
            Car myCar = new Car();

            myCar.Make = "Mercedes Benz";
            myCar.Model = "E Class";
            myCar.Year = 2016;
            myCar.Color = "Black";

            Console.WriteLine("My car is a {0} {1} {2} and the color is {3} .", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set;}

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

    }
}
