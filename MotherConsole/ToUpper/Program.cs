using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text to upper its... words: ");
            string textToUpper = Console.ReadLine();

            textToUpper = textToUpper.Trim();

            char space = ' ';
            string result = "";

            for (int i = 0; i < textToUpper.Length - 1; i++)
            {
                if (textToUpper[i] == space && textToUpper[i + 1] != space)
                {
                    var upped = textToUpper[i+1];
                    result = result + char.ToUpper(upped);
                }
                else 
                {
                    result = result + textToUpper[i];
                }
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
