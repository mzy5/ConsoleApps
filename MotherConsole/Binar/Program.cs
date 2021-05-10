using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            List<int> binaryNumber = new List<int>();

            do {
                var digit = number % 2;
                
                binaryNumber.Add(digit);
                number = number / 2;
            } while (number != 0);

            binaryNumber.Reverse();

            foreach (int i in binaryNumber)
            {
                Console.Write(i);
            }

            Console.ReadLine();
        }
    }
}
