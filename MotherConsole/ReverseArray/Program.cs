using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

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

            for (int k = 0; k < arrayOfNumbers.Length; k++)
            {
                Console.Write(arrayOfNumbers[k] + " ");
            }

            Console.ReadKey();
        }
    }
}
