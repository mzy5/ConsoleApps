using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrPrim
{
    class Prim
    {
        public static bool GetPrim(int number)
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
            Console.Write("Insert number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if(GetPrim(number) == true)
            {
                Console.Write("The number is prime");
            }
            else
            {
                Console.Write("The number is NOT prime");
            }

            Console.ReadLine();
        }
    }
}
