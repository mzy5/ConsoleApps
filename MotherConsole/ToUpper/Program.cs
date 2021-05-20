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

            string result = char.ToUpper(textToUpper[0]).ToString();

            for (int i = 1; i < textToUpper.Length; i++)
            {
                if (textToUpper[i] != space && textToUpper[i - 1] == space)
                {
                    var upped = textToUpper[i];
                    result = result + char.ToUpper(upped);
                }
                else
                {
                    result = result + textToUpper[i];
                }
            }


            //string result = "";

            //for (int i = 0; i < textToUpper.Length; i++)
            //{

            //    if (i == 0 || (textToUpper[i] != space && textToUpper[i - 1] == space))
            //    {
            //        var upped = textToUpper[i];
            //        result = result + char.ToUpper(upped);
            //    }
            //    else
            //    {
            //        result = result + textToUpper[i];
            //    }

            //}

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
