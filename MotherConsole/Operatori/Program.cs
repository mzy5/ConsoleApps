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

            Console.Write("Insert first number: ");
            var firstNo = Console.ReadLine();

            bool conversionIsSuccessful1, conversionIsSuccessful2;
            conversionIsSuccessful1 = int.TryParse(firstNo, out valFromFirstNo);

            Console.Write("Insert second number: ");
            var secondNo = Console.ReadLine();

            conversionIsSuccessful2 = int.TryParse(secondNo, out valFromSecondNo);

            while (conversionIsSuccessful1 == false || conversionIsSuccessful2 == false)
            {
                Console.Write("The data you have inserted is not a number! Please, try again. ");
            }

            Program sum = new Program();
            Console.WriteLine(firstNo + " + " + secondNo + " = " + sum.GetSum(valFromFirstNo, valFromSecondNo));

            Program differenceAB = new Program();
            Console.WriteLine(firstNo + " - " + secondNo + " = " + differenceAB.GetDifferenceAB(valFromFirstNo, valFromSecondNo));

            Program differenceBA = new Program();
            Console.WriteLine(secondNo + " - " + firstNo + " = " + differenceBA.GetDifferenceBA(valFromFirstNo, valFromSecondNo));

            Program product = new Program();
            Console.WriteLine(secondNo + " * " + firstNo + " = " + product.GetProduct(valFromFirstNo, valFromSecondNo));

            Console.ReadLine();

            //validati ca ce introduce userul de la tastatura este intr-adevar un numar
            // dati mesaj daca introduce altceva decat numar si cereti sa va dea din nou numarul
        }
    }
}
