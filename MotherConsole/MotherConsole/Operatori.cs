﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotherConsole
{
    class Operatori
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
            Console.Write("Insert first number: ");
            var firstNo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert second number: ");
            var secondNo = Convert.ToDouble(Console.ReadLine());

            Operatori sum = new Operatori();
            Console.WriteLine(firstNo + " + " + secondNo + " = " + sum.GetSum(firstNo, secondNo));

            Operatori differenceAB = new Operatori();
            Console.WriteLine(firstNo + " - " + secondNo + " = " + differenceAB.GetDifferenceAB(firstNo, secondNo));

            Operatori differenceBA = new Operatori();
            Console.WriteLine(secondNo + " - " + firstNo + " = " + differenceBA.GetDifferenceBA(firstNo, secondNo));

            Operatori product = new Operatori();
            Console.WriteLine(secondNo + " * " + firstNo + " = " + product.GetProduct(firstNo, secondNo));

            Console.ReadLine();

            //validati ca ce introduce userul de la tastatura este intr-adevar un numar
            // dati mesaj daca introduce altceva decat numar si cereti sa va dea din nou numarul

        }
    }
}
