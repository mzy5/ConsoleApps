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

            do
            {
                var digit = number % 2;

                binaryNumber.Add(digit);
                number = number / 2;
            } while (number != 0);

            binaryNumber.Reverse();

            Console.WriteLine(binaryNumber);

            for (int i = 0; i < binaryNumber.Count; i++)
            {
                Console.WriteLine(binaryNumber[i]);
            }

            foreach (int item in binaryNumber)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }

    }

}
