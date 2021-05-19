using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWithUnderline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert space separated words: ");
            string textCuSpatii = Console.ReadLine();

            textCuSpatii = textCuSpatii.Trim();

            char space = ' ';
            string result = "";

            for (int i = 0; i < textCuSpatii.Length; i++)
            {
                if(textCuSpatii[i] != space)
                {
                    result = result + textCuSpatii[i];
                }
                else
                {
                    result = result + "_";
                }
            }
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
