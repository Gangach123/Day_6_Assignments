using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignments
{
     class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter 1 to convert temp. fahrenheit to celsius ");
            Console.WriteLine("Enter 2 to convert temp. celsius to fahrenheit ");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter a value");
            double value = Convert.ToDouble(Console.ReadLine());

            Conversion.TemperatureConversion(option, value);



        }
    }
    class Conversion
    {

        public static void TemperatureConversion(int option, double value)
        {
            double temp = 0;
            if (option == 1)
            {
                temp = (value - 32) * 5 / 9;

            }
            else if (option == 2)
            {
                temp = (value * 9 / 5) + 32;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("\n  Ans: " + temp);

        }


    }
}
