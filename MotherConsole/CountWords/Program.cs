using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text: ");
            string text = Console.ReadLine();

            char empty = ' ';
            int counter = 1;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == empty && text[i+1] != empty)
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} words in this text. ");
            Console.ReadLine();
        }
    }
}
