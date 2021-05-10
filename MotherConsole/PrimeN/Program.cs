using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeN
{
    class Program
    {
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Insert the number of numbers: ");
            var number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i) == true)
                {
                    Console.Write("The number " + i + " is prime");
                }
                else
                {
                    Console.Write("The number " + i + " is NOT prime");
                }

                Console.ReadLine();
            }
                
        }
    }
}
