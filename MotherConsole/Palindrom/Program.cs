using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in word: ");
            string word = Console.ReadLine();
            int j = 0;

            for (int i = 0; i <= word.Length-1; i++)
            {
                if (word[i].Equals(word[word.Length-1]))
                {
                    j++;
                }
            }
            Console.ReadLine();
        }
    }
}
