using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            //reverse array
            int i = 0; // first element of the reversed part
            int j = arrayOfNumbers.Length - 1; // last element of the reversed part

            while (i < j)
            {
                var temp = arrayOfNumbers[i];
                arrayOfNumbers[i] = arrayOfNumbers[j];
                arrayOfNumbers[j] = temp;

                i++;
                j--;
            }
            Console.WriteLine("The reversed vector is:");
            for (int k = 0; k < arrayOfNumbers.Length; k++)
            {
                Console.Write(arrayOfNumbers[k] + " ");
            }

            //check and count odd numbers
            int numberOfOddNumbers = 0;
            for (int l = 0; l < arrayOfNumbers.Length; l++)
            {
                if(arrayOfNumbers[l] % 2 != 0)
                {
                    numberOfOddNumbers++;
                }
            }
            Console.WriteLine($"\nThere are {numberOfOddNumbers} odd numbers");

            //display items on even and odd positions
            Console.WriteLine("The numbers on the even positions are: ");
            for (int m = 0; m < arrayOfNumbers.Length; m++)
            {
                if (m % 2 == 0)
                {
                    Console.Write(arrayOfNumbers[m]);
                }
            }
            Console.WriteLine("\nThe numbers on the odd positions are: ");
            for (int n = 0; n < arrayOfNumbers.Length; n++)
            {
                if (n % 2 != 0)
                {
                    Console.Write(arrayOfNumbers[n]);
                }
            }

            Console.ReadKey();
        }

        
    }
}
