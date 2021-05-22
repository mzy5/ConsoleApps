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

            do { 
                if (selectedOption == '1' || selectedOption == '2' || selectedOption == '3' || selectedOption == '4' || selectedOption == '5')
                {
                    // Console.WriteLine(selectedOption);
                    Console.Clear();

                    Console.WriteLine("Do you want to go back? Press Y or N");

                    char selectedChar = Console.ReadKey().KeyChar;
                    if (selectedChar == 'y' || selectedChar == 'Y')
                    {
                        Console.Clear();
                        Menu();
                    }
                    else if (selectedChar == 'n' || selectedChar == 'N')
                    {
                        Console.Clear();
                        Console.WriteLine("Nein? kay, bye!");
                        Console.WriteLine("Press any key to close the console. ");
                        Console.ReadKey();
                    }
                } else
                {

                    Console.WriteLine("\r\n");
                    Menu();
                }
            } while (selectedOption != ' ');

            Console.ReadLine();
        }
    }
}
