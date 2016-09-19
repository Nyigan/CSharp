//Developer: Franklin Towett
//
//Pupose:      A method that receives parameters and returns a value
//             The porpose is to accept the length of the call in minutes
//              and rate charged per minute including 25-cent connection fee
//Class:        IN2017
//
//Instructor: R Ray
using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCall
{
    class PhoneCall
    {
        static void Main(string[] args)
        {
            int[] callLengths = { 2, 5};
            double[] rates = { 0.03, 0.12};
            double priceOfCall;

            WriteLine("{0, 10}{1, 10}{2, 10}", "Minutes", "Rate", "Price");

            //Nested pair of loops that pass each callLength and rate to the CalcPhoneCallPrice

            for (int x = 0; x < callLengths.Length; ++x)
                for (int y = 0; y < rates.Length; ++y)
                {
                    priceOfCall = CalcPhoneCallPrice(callLengths[x], rates[y]);
                    WriteLine("{0, 10}{1, 10}{2, 10}", callLengths[x], rates[y], priceOfCall.ToString("C"));
                    
                }
            //Pausing the output untill the user presses a key
            ReadLine();
        }
        private static double CalcPhoneCallPrice(int minutes, double rate)
        {
            const double BASE_FEE = 0.25;
            double callFee;
            callFee = BASE_FEE + minutes * rate;
            return callFee;
        }
      }
    }