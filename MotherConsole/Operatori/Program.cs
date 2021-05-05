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

        public double GetDifferenceBA(double a, double b)
        {
            return b - a;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int valFromFirstNo, valFromSecondNo;

            bool conversionIsSuccessful1, conversionIsSuccessful2;
            
            do {
                Console.Write("Insert first number: ");
                var firstNo = Console.ReadLine();

                conversionIsSuccessful1 = int.TryParse(firstNo, out valFromFirstNo);

                if (conversionIsSuccessful1 == false)
                {
                    Console.WriteLine("The data you have inserted is not a number! Please, try again. ");
                }
            } while (conversionIsSuccessful1 == false) ;

            

            do {
                Console.Write("Insert second number: ");
                var secondNo = Console.ReadLine();

                conversionIsSuccessful2 = int.TryParse(secondNo, out valFromSecondNo);

                if (conversionIsSuccessful2 == false)
                {
                    Console.WriteLine("The data you have inserted is not a number! Please, try again. ");
                }
            } while (conversionIsSuccessful2 == false);

            Program sum = new Program();
            Console.WriteLine(valFromFirstNo + " + " + valFromSecondNo + " = " + sum.GetSum(valFromFirstNo, valFromSecondNo));

            Program differenceAB = new Program();
            Console.WriteLine(valFromFirstNo + " - " + valFromSecondNo + " = " + differenceAB.GetDifferenceAB(valFromFirstNo, valFromSecondNo));

            Program differenceBA = new Program();
            Console.WriteLine(valFromSecondNo + " - " + valFromFirstNo + " = " + differenceBA.GetDifferenceBA(valFromFirstNo, valFromSecondNo));

            Program product = new Program();
            Console.WriteLine(valFromSecondNo + " * " + valFromFirstNo + " = " + product.GetProduct(valFromFirstNo, valFromSecondNo));

            Console.ReadLine();
        }
    }
}
