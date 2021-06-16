using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            // int[] arrayOfNumbers = { 10, 10, 10, 10, 10, 10, 10};

            int[] arrayOfNumbers = { 8, 6, 9, 3, 2, 4, 1, 5, 7 };

            for (int i = arrayOfNumbers.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayOfNumbers[i] + " ");
            }

            //check and count odd numbers
            int numberOfOddNumbers = 0;
            for (int l = 0; l < arrayOfNumbers.Length; l++)
            {
                if (arrayOfNumbers[l] % 2 != 0)
                {
                    numberOfOddNumbers++;
                }
            }
            Console.WriteLine($"\nThere are {numberOfOddNumbers} odd numbers");

            //display items on even and odd positions
            Console.WriteLine("The numbers on the even positions are: ");
            for (int m = 0; m < arrayOfNumbers.Length; m += 2)
            {
                if (m % 2 == 0)
                {
                    Console.Write(arrayOfNumbers[m]);
                }
            }
            Console.WriteLine("\nThe numbers on the odd positions are: ");
            for (int n = 1; n < arrayOfNumbers.Length; n += 2)
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

            while (index < arrayOfNumbers.Length - 1)
            {
                if (index < position)
                {
                    shorterArray[index] = arrayOfNumbers[index];
                    index++;
                }
                else
                {
                    shorterArray[index] = arrayOfNumbers[index + 1];
                    index++;
                }
            }

            Console.WriteLine($"The array, after removing the item from the position {position} is: ");
            for (int q = 0; q < shorterArray.Length; q++)
            {
                Console.Write(shorterArray[q]);
            }

            //insert an element on a position ???
            Console.WriteLine("\nInsert the item you want to insert: ");
            int itemToInsert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the position you want to insert the element to: ");
            int positionToInsert = Convert.ToInt32(Console.ReadLine());
            int[] longerArray = new int[arrayOfNumbers.Length + 1];
            int indexToo = 0;


            while (indexToo < arrayOfNumbers.Length )
            {
                if (indexToo == positionToInsert)
                {
                    longerArray[indexToo] = itemToInsert;
                    longerArray[indexToo + 1] = arrayOfNumbers[indexToo];
                    indexToo++;

                }
                else if (indexToo < positionToInsert)
                {
                    longerArray[indexToo] = arrayOfNumbers[indexToo];
                    indexToo++;
                }
                else
                {
                    longerArray[indexToo + 1] = arrayOfNumbers[indexToo];
                    indexToo++;
                }
                //else
                //{
                //    longerArray[indexToo] = arrayOfNumbers[indexToo + 1];
                //    indexToo++;
                //}
            }
            Console.WriteLine($"\nThe array, after adding {itemToInsert} on the position {positionToInsert} is: ");
            for (int r = 0; r < longerArray.Length; r++)
            {
                Console.Write(longerArray[r]);
            }

            //check if all array's elements are equal
            int counter = 0;
            for (int s = 0; s < arrayOfNumbers.Length - 1; s++)
            {
                if (arrayOfNumbers[s] == arrayOfNumbers[s + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("\nIt turns out, the array's elements are not equal.");
                    break;
                }
            }
            if (counter == arrayOfNumbers.Length - 1)
            {
                Console.WriteLine("\nAll of the array's elements are equal");
            }

            BubbleSort(arrayOfNumbers, arrayOfNumbers.Length);

            //compare 2 vectors
            int count = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int j = 0; j < shorterArray.Length; j++)
                {
                    if(arrayOfNumbers[i] != shorterArray[j])
                    {
                        Console.WriteLine("The 2 arrays are distinct. ");
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"\nThe 2 arrays have {count} items in common.");

            Console.ReadKey();
        }

        private static void BubbleSort(int[] array, int n)
        {
            int i, j, temp;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // swap the elements
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nThe bubble sorted array looks like this: ");
            for (i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}