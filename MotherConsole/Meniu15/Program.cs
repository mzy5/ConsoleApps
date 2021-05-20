using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meniu15
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("Type an option's number and face its consequences: ");
            Console.WriteLine("1st");
            Console.WriteLine("2nd");
            Console.WriteLine("3rd");
            Console.WriteLine("4th");
            Console.WriteLine("5th");
        }
        static void Main(string[] args)
        {
            // Sa se afiseze un meniul in consola cu optiuni de la 1 la 5.
            // La alegerea fiecarei optiuni din meniu, programul trebuie sa stearga ecranul, 
            // apoi sa afiseze un mesaj si sa ofere posibilitatea de a te intoarce la meniul initial.

            Menu();

            char selectedOption = Console.ReadKey().KeyChar;

            if (selectedOption == '1' || selectedOption == '2' || selectedOption == '3' || selectedOption == '4' || selectedOption == '5')
            {
                // Console.WriteLine(selectedOption);
                Console.Clear();

                char selectedChar = Console.ReadKey().KeyChar;
                Console.WriteLine("Do you want to go back? Press Y or N");
                if (selectedChar == 'y' || selectedChar == 'Y')
                {
                    Menu();
                }
                else if (selectedChar == 'n' || selectedChar == 'N')
                {
                   //???
                }
            }

            Console.ReadLine();
        }
    }
}
