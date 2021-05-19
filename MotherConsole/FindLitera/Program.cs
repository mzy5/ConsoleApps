using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLitera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Find this litera: ");
            var litera = Convert.ToChar(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == litera)
                {
                    counter++;
                }
            }

            Console.WriteLine($"The letter {litera} has been found {counter} times. ");
            Console.ReadLine(); 
        }
    }
}
