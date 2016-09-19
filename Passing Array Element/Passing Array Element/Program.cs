//Developer:    Franklin Towett
//Prgram:       Passing Array values to a method
//Class:        IN2017
//Instructor:   R. Ray
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PassingArrayElement
{
    class Program
    {
        //Passing a Single Array Element to a Method
        static void Main(string[] args)
        {

            int[] someNums = { 10, 12, 22, 35 };
            int x;
            Write("\nAt beginning of Main() method...");
            for (x = 0; x < someNums.Length; ++x)
                Write("{0,6}", someNums[x]);
            WriteLine();
            for (x = 0; x < someNums.Length; ++x)
                MethodGetsOneInt(someNums[x]);
            Write("At end of Main() method.........");
            for (x = 0; x < someNums.Length; ++x)
                Write("{0,6}", someNums[x]);
            ReadLine();
        }
        private static void MethodGetsOneInt(int oneVal)
        {
            Write("In MethodGetsOneInt() {0}", oneVal);
            oneVal = 999;
            WriteLine("     After change {0}", oneVal);
        }
    }
}
