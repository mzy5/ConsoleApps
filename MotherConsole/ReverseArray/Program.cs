using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

            for (int i=arrayOfNumbers.Length -1 ; i >=0 ; i--)
            {
                Console.Write(arrayOfNumbers[i] + " ");
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
            for (int m = 0; m < arrayOfNumbers.Length; m +=2)
            {
                if (m % 2 == 0)
                {
                    Console.Write(arrayOfNumbers[m]);
                }
            }
            Console.WriteLine("\nThe numbers on the odd positions are: ");
            for (int n = 1; n < arrayOfNumbers.Length; n+=2)
            {
                if (n % 2 != 0)
                {
                    Console.Write(arrayOfNumbers[n]);
                }
            }

            //average of even numbers
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


            //inversare ?!!?!?!


            //delete the element on position p
            Console.WriteLine("\nInsert the position you want to delete the element from: ");
            int position = Convert.ToInt32(Console.ReadLine());
            int[] shorterArray = new int[arrayOfNumbers.Length - 1];
            int index = 0;

            while (position < arrayOfNumbers.Length - 1)
            {
                if (index < position)
                {
                    shorterArray[index] = arrayOfNumbers[index];
                    index++;
                }else
                {
                    shorterArray[position] = arrayOfNumbers[position + 1];
                    position++;
                    index++;
                }
            }

            Console.WriteLine($"The array, after removing the item from the position {position} is: ");
            for (int q = 0; q < shorterArray.Length; q++)
            {
                Console.Write(shorterArray[q]);
            }

            //insert an element on a position
            Console.WriteLine("\nInsert the position you want to insert the element to: ");
            int positionToInsert = Convert.ToInt32(Console.ReadLine());
            int[] longerArray = new int[arrayOfNumbers.Length + 1];



            Console.ReadKey();
        }

        
    }
}
