using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignments
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter no of year");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter principal");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter interest rate");
            double R = Convert.ToDouble(Console.ReadLine());

            payment.MonthlyPayment(Y, P, R);

        }
    }

    class payment
    {
        public static void MonthlyPayment(double Y, double P, double R)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = P * r / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("\nPayment:" + payment);
        }


    }
}
