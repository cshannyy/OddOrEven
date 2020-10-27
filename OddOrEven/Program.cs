using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOdd(6));
        }

        public static bool IsOdd(int number)
       {
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is Odd");

                return true;
            }
            else
            {
                Console.WriteLine("Your number is even");

                return false;
            }

       }
    }
}
