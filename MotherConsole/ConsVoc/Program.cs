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
            string[] vocale= {"a", "e", "i", "o", "u"};
            Console.WriteLine("Insert word: ");
            string word = Console.ReadLine();

            int j = 0;
            int k = 0; ;

            for (int i = 0; i <= word.Length; i++)
            {
                if (word[i].Equals(vocale[i]))
                {
                    j++;
                }
                else k++;
            }

            Console.WriteLine($"Nr de vocale: {j}");
            Console.WriteLine($"Nr de consoane: {k}");
        }
    }
}
