using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert word to mirror: ");
            string word = Console.ReadLine();
            //var arr = word.ToCharArray();
            //var reversedArr = new Char[arr.Length];



            //int j = 0;

            //for (int i = arr.Length -1 ; i >= 0; i--)
            //{
            //    reversedArr[j] = arr[i];
            //    j++;
            //}



            ////var result = new string(reversedArr);
            //Console.WriteLine(reversedArr);

            //Console.ReadLine();


            string result = "";

            for (int i = word.Length - 1; i >=0; i--)
            {
                result = result + word[i];
            }

            Console.WriteLine(result);


            //var arr = word.ToCharArray();

            //int i = 0; // first element of the reversed part
            //int j = word.Length - 1; // last element of the reversed part

            //while (i < j)
            //{
            //    var temp = arr[i];
            //    arr[i] = arr[j];
            //    arr[j] = temp;

            //    i++;
            //    j--;
            //}
        }
    }
}
