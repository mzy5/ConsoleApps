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
            var arr = textCuSpatii.ToCharArray();

            char empty = ' ';

            for (int i = 0; i < textCuSpatii.Length; i++)
            {
                if(textCuSpatii[i] == empty)
                {
                    arr[i] = '_'; // wip
                }
            }
        }
    }
}
