//Developer:    Franklin Towett
//Program:      program to show overloaded method
//Class:        IN2017
//Instructor:   R. Ray
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example of Overloaded Method. Press Enter to display next.");
            DisplayWithBorders("Helen");
            DisplayWithBorders("Eleanor");
            DisplayWithBorders("Kulung Kertas");
            DisplayWithBorders("Winnie");
            DisplayWithBorders("Tuvalu");
        }
        private static void DisplayWithBorders(string word)
        {
            const int EXTRA_STARS = 4;
            const string SYMBOL = "*";
            int size = word.Length + EXTRA_STARS;
            int x;
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);
            Console.WriteLine();
            Console.WriteLine(SYMBOL + " " + word + " " + SYMBOL);
            for (x = 0; x < size; ++x)
                Console.Write(SYMBOL);
            Console.WriteLine("\n\n");
            Console.ReadLine();
        }
    }
}
