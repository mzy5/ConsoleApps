using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public double GetSum(double a, double b)
        {
            return a + b;
        }

        public double GetDifferenceAB(double a, double b)
        {
            return a - b;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public static int getNumber()
        {

            int valFromFirstNo;
            bool conversionIsSuccessful1;

            do
            {
                var firstNo = Console.ReadLine();

                conversionIsSuccessful1 = int.TryParse(firstNo, out valFromFirstNo);

                if (conversionIsSuccessful1 == false)
                {
                    Console.WriteLine("The data you have inserted is not a number! Please, try again. ");
                }
            } while (conversionIsSuccessful1 == false);

            return valFromFirstNo;
        }

        static void Main(string[] args)
        {
            int valFromFirstNo, valFromSecondNo;

            Console.Write("Insert first number: ");
            valFromFirstNo = getNumber();

            Console.Write("Insert second number: ");
            valFromSecondNo = getNumber();

            Program sum = new Program();
            Console.WriteLine(valFromFirstNo + " + " + valFromSecondNo + " = " + sum.GetSum(valFromFirstNo, valFromSecondNo));

            Program differenceAB = new Program();
            Console.WriteLine(valFromFirstNo + " - " + valFromSecondNo + " = " + differenceAB.GetDifferenceAB(valFromFirstNo, valFromSecondNo));

            Program differenceBA = new Program();
            Console.WriteLine(valFromSecondNo + " - " + valFromFirstNo + " = " + differenceBA.GetDifferenceAB(valFromSecondNo, valFromFirstNo));

            Program product = new Program();
            Console.WriteLine(valFromSecondNo + " * " + valFromFirstNo + " = " + product.GetProduct(valFromFirstNo, valFromSecondNo));

            Console.ReadLine();
        }
    }
}
