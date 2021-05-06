using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdusN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of numbers: ");
            var number = Convert.ToInt32(Console.ReadLine());
            int produs = 1;
            for (int i = 1; i <= number; i++)
            {
                produs = produs * i;
            }
            Console.Write("The sum of the first " + number + " numbers is: " + produs);
            Console.ReadLine();
        }
    }
}
