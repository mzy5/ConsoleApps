using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            do
            {
                Console.Write("Insert number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number <= 100)
                {
                    Console.WriteLine(number + " is smaller than 100");
                }
                else
                {
                    Console.WriteLine("The number you have inserted is bigger than 100");
                }
                    
            } while (number <= 100);
            Console.ReadLine();
        }
    }
}
