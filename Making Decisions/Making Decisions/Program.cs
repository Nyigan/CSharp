//
//Developer:    Franklin Towett
//Program:      Assignment on Decisions Making in C#
//Class:        IN2017
//Instructor:   R Ray
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Decisions
{
    class Program
    {


        //**********************************************************************
        //this enum type is used with swicth statement below
        enum Weekday
        {
            SUNDAY = 1, MONDAY, TEUSDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
        //***********************************************************************


        static void Main(string[] args)
        {


            //Simple if statement
            int num1 = 10 / 2;
            if (num1 == 5)
            {
                Console.WriteLine("Testing whether 10 devided by 2 is 5");
                Console.WriteLine("It is True");
                Console.WriteLine();
            }



            //An if-else example to test if one number is greater than the other
            int a = 2, b = 4;
            Console.WriteLine("Program to test if one number is greater than the other");
            if (a > b)
            {
                Console.WriteLine("{0} is greater than {1} ", a, b);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} is not greater {1}", a, b);
                Console.WriteLine();
            }



            //Another if-else example to test if input is greater or lower than the initial value
            const int HIGH = 15;
            string numberString;
            int number;
            Console.WriteLine("Testing if user input is greater than or lower than initial value");
            Console.Write("Enter an integer to test: ");
            numberString = Console.ReadLine();
            number = Convert.ToInt32(numberString);
            if (number > HIGH)
            {
                Console.WriteLine("{0} is greater than {1} ", number, HIGH);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0} is not greater {1}", number, HIGH);
                Console.WriteLine();
            }



            //using switch statement
            int year;
            Console.WriteLine("Enter class year: ");
            year = Convert.ToInt32(Console.ReadLine());
            switch (year)
            {
                case 1:
                    Console.WriteLine("Freshman");
                    break;
                case 2:
                    Console.WriteLine("Sophomore");
                    break;
                case 3:
                    Console.WriteLine("Senior");
                    break;
                case 4:
                    Console.WriteLine("Senior");
                    break;
                default:
                    Console.WriteLine("Invalid Year");
                    break;
            }
            Console.WriteLine();


            //Using Enumeration with a switch statement to check days of the week
            //declaration is made before the main method of this enum, check above

            int day;
            string message;
            Console.Write("Enter day of the week number: ");
            day = Convert.ToInt32(Console.ReadLine());

            switch ((Weekday)day)
            {
                case Weekday.SUNDAY:
                case Weekday.SATURDAY:
                    message = "It's weekend, go back to bed or go play.";
                    break;
                case Weekday.MONDAY:
                case Weekday.TEUSDAY:
                case Weekday.WEDNESDAY:
                case Weekday.THURSDAY:
                case Weekday.FRIDAY:
                    message = "It is work day, get up and do something.";
                    break;
                default:
                    message = "That day is yet to come, work on what to be done when it gets here. ";
                    break;
            }
            Console.WriteLine(message);
            Console.WriteLine();


            //Basic Do-while loop
            int x = 0;
            Console.WriteLine("Display numbers from 0 to 10");
            do
            {
                Console.Write(" " + x);
                x++;
            } while (x <= 10);
            Console.WriteLine();
            Console.WriteLine();
            

            //Basic For Loop
            Console.WriteLine("For loop to output 1 to 5");
            for (int y = 1; y <= 5; y++)
            {
                Console.Write(" " +y);
            }
            Console.WriteLine();
            Console.WriteLine();


            //Unary operators
            //Putting the operators as prefix or postfix achieve the same results.
            int w = 2, z = 5;
            w++;
            Console.WriteLine("The value after increment the value of w = {0}.", w);
            Console.WriteLine();
            z--;
            Console.WriteLine("After decrementing the value of z = {0}.", z);

            Console.ReadLine();
        }
    }
}
