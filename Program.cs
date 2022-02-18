using System;
namespace probles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    a = a + i;
                }
                
            }
            if (a == number)
            {
                Console.WriteLine("Print it is a perfecT number");
            }
            else
            {
                Console.WriteLine("Print it is not a perfecT number");
            }


        }
    }
}