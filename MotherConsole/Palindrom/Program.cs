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
            int j = word.Length-1;
            bool isPalindrome = true;

            for (int i = 0; i <= word.Length/2; i++)
            {
                if (word[i] != word[j])
                {
                   isPalindrome = false;
                   break;
                }
                j--;
            }

            if (isPalindrome)
            {
                Console.WriteLine("The word is a palindrome");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
