//
//Developer: Franklin Towett
//Project: Working with LINQ - LINQ example
//Class: IN2017
//Instructor: R Ray.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            ////LINQ Query

            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;


            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            Console.WriteLine("Using a LINQ Query to return all BMWs in descending order using year.\n");
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);
            }
            Console.WriteLine("_____________________________________________________________\n");



            ////LINQ Method
            var bmw = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            var orderedCar = myCars.OrderByDescending(p => p.Year);

            
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make=="BMW");

            Console.WriteLine("Shows BMW in descending order using VIN.\n");
            Console.WriteLine(firstBMW.VIN);
            Console.WriteLine("_____________________________________________________________\n");


            Console.WriteLine("Checks if the Cars are Greater 2007 and returns true or false.\n");
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));
            Console.WriteLine("_____________________________________________________________\n");


            //Console.WriteLine("Returns the sticker price after substrating $3000.\n");
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.Make, p.StickerPrice));
            //Console.WriteLine();


            //Check if the car exists
            Console.WriteLine("Returns True if the Car exits or false if it doesn't.\n");
            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            Console.WriteLine("_____________________________________________________________\n");

            Console.WriteLine("Total sticker Price of all Cars in the lot.\n");
            Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));
            Console.WriteLine("_____________________________________________________________\n");

            //Console.WriteLine("Returns Cars ");
            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{0} {1} {2}\n", car.Year, car.Model, car.VIN);
            //    Console.WriteLine();
            //}
            Console.ReadLine();
          

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
