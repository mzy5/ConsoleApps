using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumProdMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the number of numbers: ");
            var number = Convert.ToInt32(Console.ReadLine());
            double produs = 1;
            double sum = 0;
            double medArit = 0;
            double[] arrayOfNum = new double[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Insert number: ");
                arrayOfNum[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arrayOfNum[i];
                produs = produs * arrayOfNum[i];
                medArit = sum / number;
            }
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The product is: " + produs);
            Console.WriteLine("The media aritmetica is: " + medArit);
            Console.ReadLine();
        }
    }
}
