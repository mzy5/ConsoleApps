using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsVoc
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> vocale = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
            int totalV = 0;
            int totalC = 0; ;

            Console.WriteLine("Insert word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (vocale.Contains(word[i]))
                {
                    totalV++;
                }
                else totalC++;
            }

            Console.WriteLine($"Nr de vocale: {totalV}");
            Console.WriteLine($"Nr de consoane: {totalC}");

            Console.ReadLine();
        }
    }
}
