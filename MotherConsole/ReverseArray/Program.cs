using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            int[] reversedArray = new int[10];

            //reverse array
            //int i = 0; // first element of the reversed part
            //int j = arrayOfNumbers.Length - 1; // last element of the reversed part

            //while (i < j)
            //{
                
            //    reversedArray[i] = arrayOfNumbers[j];

            //     i++;
            //     j--;
            //}
            //Console.WriteLine("The reversed vector is:");
            //for (int k = 0; k < reversedArray.Length; k++)
            //{
            //    Console.Write(reversedArray[k] + " ");
            //}

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

            //check and count odd numbers
            int numberOfEvenNumbers = 0;
            int sumOfEvenNumbers = 0;
            for (int n = 0; n < arrayOfNumbers.Length; n++)
            {
                if (arrayOfNumbers[n] != 0 && arrayOfNumbers[n] % 2 == 0)
                {
                    sumOfEvenNumbers = sumOfEvenNumbers + arrayOfNumbers[n];
                    numberOfEvenNumbers++;
                }
            }
            Console.WriteLine($"\nThe mean of the array's even numbers is: {sumOfEvenNumbers / numberOfEvenNumbers}");

            //display items between array[a, b]
            Console.WriteLine("Insert the left interval margin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the right interval margin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The elements in between positions {a} and {b} are: ");
            for (int o = a; o <= b; o++)
            {
                Console.Write(arrayOfNumbers[o] + " ");
            }

            //delete the element on position p
            Console.WriteLine("Insert the position you want to delete the element from: ");
            int position = Convert.ToInt32(Console.ReadLine());

            int p = 0;
            int lengthOfArray = arrayOfNumbers.Length;
            while (p != position - 1)
            {
                while (p < lengthOfArray)
                {
                    arrayOfNumbers[p] = arrayOfNumbers[p + 1];
                    p++;
                }
                lengthOfArray--;
            }
            Console.WriteLine("$The array, after removing the item from the {position} is: ");
            for (int q = 0; q < arrayOfNumbers.Length; q++)
            {
                Console.Write(arrayOfNumbers[q]);
            }

            Console.ReadKey();
        }

        
    }
}
