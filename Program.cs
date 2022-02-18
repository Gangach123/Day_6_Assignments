using System;
namespace probles
{
    class Program
    {
        static void Main(string[] args)
        {
            int first=0;
            int second=1;
            int third=0;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(first + " " + second + " ");
            for (int i = 2; i < number; i++)
            {
                third = first + second;
                Console.Write(third+" ");
                first = second;
                second = third;
            }
           
        }
    }
}