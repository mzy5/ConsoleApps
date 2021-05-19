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

            text = text.Trim();

            char space = ' ';
            int counter = 1;

            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == space && text[i+1] != space)
                {
                    counter++;
                }
            }

            Console.WriteLine($"There are {counter} words in this text. ");
            Console.ReadLine();
        }
    }
}
