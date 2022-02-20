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
            int num, reverse = 0, rem;
            Console.WriteLine("Enter the num ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reverse the number " + reverse);
        }

    }
}
