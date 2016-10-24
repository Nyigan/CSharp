//
//Developer: Franklin Towett
//Project: Collection of Objects Example
//Class: IN2017
//Instructor: R Ray.
//
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFirstCar = new Car();
            myFirstCar.Make = "BMW";
            myFirstCar.Model = "M5";
            myFirstCar.Year = 2017;
            myFirstCar.VIN = "BM123654789";

            Car mySecondCar = new Car();
            mySecondCar.Make = "Mercedes";
            mySecondCar.Model = "E Class";
            mySecondCar.Year = 2017;
            mySecondCar.VIN = "MB789654123";

            Book book1 = new Book();
            book1.Title = "Visual C# 2015";
            book1.Author = "Joyce Farrel";
            book1.ISBN = "978-582456-8564";
            book1.Publisher = "CENGAGE";

            Book book2 = new Book();
            book2.Title = "Android Boot Camp";
            book2.Author = "Corinne Hoisington";
            book2.ISBN = "978-8564-89546";
            book2.Publisher = "CENGAGE";

            ////ArrayList
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(myFirstCar);
            //myArrayList.Add(mySecondCar);
            //myArrayList.Add(book1);
            //myArrayList.Remove(book1);


            //This is generic array List<T>
            List<Car> myList = new List<Car>();
            myList.Add(myFirstCar);
            myList.Add(mySecondCar);

            Console.WriteLine("Generic Array List");
            Console.WriteLine("--------------------");

            foreach (Car car in myList)
            {
                Console.Write(car.Make + " ");
                Console.WriteLine(car.Model);

            }
            Console.WriteLine();


            //Generic Dictionary<TKey, TValue>

            Dictionary<string, Car > myDictionary= new Dictionary<string, Car>();
            myDictionary.Add(myFirstCar.VIN, myFirstCar);
            myDictionary.Add(mySecondCar.VIN, mySecondCar);

            Console.WriteLine("Generic Dictionary");
            Console.WriteLine("--------------------");
            Console.WriteLine(myDictionary["MB789654123"].VIN);
            Console.WriteLine();

            //Collection Iniatializer
            List<Car> myNewList = new List<Car>()
            {
                new Car {Make="Peugot", Model="406", Year=2017, VIN="P1" },
                new Car {Make="Nissan", Model="Sentra", Year=2016, VIN="N1" },
                new Car {Make="Pagani", Model="Zonda", Year=2016, VIN="PZ1" }
            };

            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
    }
}
