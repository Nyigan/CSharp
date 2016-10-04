//
//Developer: Franklin Towett
//Project: Bike Console Application - Classes and Static & Non-Static Methods
//Class: IN2017
//Instructor: R Ray.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike myBike = new Bike();
            myBike.Make = "Yamaha";
            myBike.Model = "R1";
            myBike.Year = 2016;
            myBike.Color = "Black";
            

            Bike myOtherBike = myBike;

           Console.WriteLine("\t\t"+DateTime.Now.ToLongDateString());
            Console.WriteLine("\t\t************************\n");
            Console.WriteLine("Classes and Methods.");
            Console.WriteLine("____________________\n");

            Console.WriteLine("{0}  {1}  \t\t{2}  {3}\n", myOtherBike.Make, myOtherBike.Model, myOtherBike. Year, myOtherBike.Color);


            myOtherBike.Make = "Suzuki";
            myOtherBike.Model = "Hayabusa";
            myOtherBike.Color = "Red";

            Console.WriteLine("{0}  {1}  \t{2}  {3}\n", myBike.Make, myBike.Model, myBike.Year, myBike.Color);
            Bike myThirdBike = new Bike();
            Console.WriteLine("{0}  {1}  \t{2}  {3}\n\n", myThirdBike.Make, myThirdBike.Model, myThirdBike.Year, myThirdBike.Color);
            Console.WriteLine("Calling Static and Non-Static Methods.");
            Console.WriteLine("--------------------------------------\n");

            //Static Method
            Bike.BikeStaticMethod();
            Console.WriteLine();

            //calling a non static method
            Bike nonStatic = new Bike();
            nonStatic.BikeNonStaticMethod();
            Console.ReadLine();
        }
    }
    class Bike
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public Bike()
        {
            this.Make = "BMW";
            this.Model = "\tK1300 S";
            this.Year = 2015;
            this.Color = "Black";
        }

        public static void BikeStaticMethod()
        {
            Console.WriteLine("Hello from Static Method.");
        }
        public void BikeNonStaticMethod()
        {
            Console.WriteLine("Greetings from Non-Static Method.");
        }


    }
}
