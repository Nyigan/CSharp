//
//Developer: Franklin Towett
//Project: Lesson02 - Using Classes and Objects
//Class: IN2017
//Instructor: R Ray.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 20.0;
            rect.Width = 10.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of the Rectangle is: {0}.", area );
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        private double length;

        private double width;
            public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)

                    length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)

                    width = value;
            }
        }
        public double GetArea()
        {
            return length * width;
        }

    }
}
