using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n: ");
            var n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            a[0] = 0;
            a[1] = 1;

            Console.Write("The numbers are: ");
            Console.Write(a[0] + "; ");
            Console.Write(a[1] + "; ");
            for (int i = 2; i <= n; i++)
            {
                int number = a[i - 1] + a[i - 2];
                Console.Write(number + "; ");
            }
            Console.ReadLine();
        }
    }
}
