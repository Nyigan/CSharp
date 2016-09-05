using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte data type is from 0 to 255
            byte num1 = 45, num2 = 255;

            Console.WriteLine("Unsigned byte");
            Console.WriteLine("---------------------");
            Console.WriteLine("Byte Values are = {0} and {1}", num1, num2);
            Console.WriteLine();

            //Outputting the min and Max values of a byte (unsigned)
            Console.WriteLine("Minimum byte value is = "+ (byte.MinValue));
            Console.WriteLine("Maximum byte value is = "+ (byte.MaxValue));
            Console.WriteLine();

            //Outputting the min and Max values of a sbyte (signed byte)
            Console.WriteLine("Signed byte");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum signed byte value is = " + (sbyte.MinValue));
            Console.WriteLine("Maximum signed byte value is = " + (sbyte.MaxValue));
            Console.WriteLine();

            //Char data type only takes one character
            char char1 = 'a';
            char char2 = 'b';
            char char3 = 'c';
            //changing to uppercase
            char upp1 = char.ToUpper(char1);
            char upp2 = char.ToUpper(char2);
            char upp3 = char.ToUpper(char3);
            //Char data type manipuation
            Console.WriteLine("Char data type");
            Console.WriteLine("---------------------");
            Console.WriteLine("Lowercase  output is = {0}, {1}, {2} ", char1, char2, char3);
            Console.WriteLine("Uppercase output is = {0}, {1}, {2} ",upp1, upp2, upp3);
            Console.WriteLine();

            //Outputting the min and Max values of a long (Signed)
            Console.WriteLine("Signed Long");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum signed long value is = " + (long.MinValue));
            Console.WriteLine("Maximum signed long value is = " + (long.MaxValue));
            Console.WriteLine();

            //Outputting the min and Max values of a long (Unsigned)
            Console.WriteLine("UnSigned Long");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum unsigned long value is = " + (ulong.MinValue));
            Console.WriteLine("Maximum unsigned long value is = " + (ulong.MaxValue));
            Console.WriteLine();

            //Outputting the min and Max values of a short (Signed)
            Console.WriteLine("Signed Short");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum signed short value is = " + (short.MinValue));
            Console.WriteLine("Maximum signed short value is = " + (short.MaxValue));
            Console.WriteLine();

            //Outputting the min and Max values of a short (Unsigned)
            Console.WriteLine("UnSigned Short");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum unsigned short value is = " + (ushort.MinValue));
            Console.WriteLine("Maximum unsigned short value is = " + (ushort.MaxValue));
            Console.WriteLine();

            //Outputting the min and Max values of a integer (Signed)
            Console.WriteLine("Signed Integer");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum signed integer value is = " + (int.MinValue));
            Console.WriteLine("Maximum signed integer value is = " + (int.MaxValue));
            Console.WriteLine();

            //Outputting the min and Max values of a interger (Unsigned)
            Console.WriteLine("UnSigned Integer");
            Console.WriteLine("---------------------");
            Console.WriteLine("Minimum unsigned integer value is = " + (uint.MinValue));
            Console.WriteLine("Maximum unsigned integer value is = " + (uint.MaxValue));
            Console.WriteLine();

            //Float data types
            //To avaoid runtime error the values are suffixed with lowerase 'f' or uppercase 'F' but uppercase is preferred.
            float float1 = 123.25F;
            float float2 = 35.21f;
            Console.WriteLine("Float Data Types");
            Console.WriteLine("---------------------");
            Console.WriteLine("Float values are  = {0} and {1}", float1, float2);
            Console.WriteLine();


            //Double data types
            //Double data types can take negative values and uses double precision floating point
            double double1= 22.7;
            double double2 = 33.21;
            Console.WriteLine("Double Data Types");
            Console.WriteLine("---------------------");
            Console.WriteLine("Double values are  = {0} and {1}", double1, double2);
            Console.WriteLine();

            //decimal data types
            decimal dec1 = 123.25M;
            decimal dec2 = 35.21M;
            Console.WriteLine("Decimal Data Types");
            Console.WriteLine("---------------------");
            Console.WriteLine("Decimal values are  = {0} and {1}", dec1, dec2);
            Console.WriteLine("Minimum decimal value is = " + (decimal.MinValue));
            Console.WriteLine("Maximum decimal value is = " + (decimal.MaxValue));
            Console.WriteLine();

            //Boolean operations
            //the method considers 0 to be false, other numbers is true
            Console.WriteLine("Boolean Data Types - Considers zero to be false");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(Convert.ToBoolean(25));
            Console.WriteLine(Convert.ToBoolean(0));
            Console.WriteLine(Convert.ToBoolean(-78));
            Console.WriteLine(Convert.ToBoolean(0));
            Console.WriteLine();

            //String operations
            //the method considers 0 to be false, other numbers is true
            string str1 = "This is advance C# class";
            string str2 = "Taught by R Ray";
            Console.WriteLine("String Operations");
            Console.WriteLine("------------------");
            Console.WriteLine("The output is : {0} and {1}.", str1, str2);
            Console.ReadLine();

        }
    }
}
