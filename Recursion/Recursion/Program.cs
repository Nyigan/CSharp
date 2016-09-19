//Developer:    Franklin Towett
//Program:      Recursive function
//Class:        IN2017
//Instructor:   R. Ray
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Factorial of 10 is = " +Factorial(10));
            Console.ReadLine();
        }
        //The int data type only works up to factorial of 32, because of int range
        //To achieve more values change to long or any other data type that can accomadate more values
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1; //base case
            }
            else
            {
                return n * Factorial(n - 1); //recursive case
            }
        }
    }
}
