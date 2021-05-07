using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divizori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            Console.WriteLine("Divizorii lui " + number + " sunt: ");
            do
            {
                if (number % i == 0)
                {
                    Console.Write(i + "; ");
                }
                i++;
            } while (i <= number);

            Console.ReadLine();
        }
    }
}
