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

            int i = 0; // first element of the reversed part
            int j = word.Length - 1; // last element of the reversed part

            while (i < j)
            {
                var temp = word[i];
                word[i] = word[j];
                word[j] = temp;

                i++;
                j--;
            }
        }
    }
}
