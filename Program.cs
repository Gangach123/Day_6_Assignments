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
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            double SqrtNumber = Math.Sqrt(Number);
            Console.WriteLine("Square root of {0} is: {1}", Number, SqrtNumber);
            Console.ReadLine();
        }

    }
}
