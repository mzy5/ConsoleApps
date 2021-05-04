using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherConsole
{
    class PrimeleNSum
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of numbers: ");
            var number = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            int [] a = new int[number];
            for (int i=0; i<=a.Length; i++)
            {
                suma = suma + a[i];
            }
            Console.Write("The sum of the first " + number + " numbers is: " + suma);
        }
    }
}
