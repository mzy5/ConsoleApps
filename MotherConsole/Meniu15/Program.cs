using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meniu15
{
    class Program
    {
        public static char Menu()
        {
            Console.WriteLine("Type an option's number and face its consequences: ");
            Console.WriteLine("1st");
            Console.WriteLine("2nd");
            Console.WriteLine("3rd");
            Console.WriteLine("4th");
            Console.WriteLine("5th");

            char selectedOption = Console.ReadKey().KeyChar;

            return selectedOption;
        }
        static void Main(string[] args)
        {
            // Sa se afiseze un meniul in consola cu optiuni de la 1 la 5.
            // La alegerea fiecarei optiuni din meniu, programul trebuie sa stearga ecranul, 
            // apoi sa afiseze un mesaj si sa ofere posibilitatea de a te intoarce la meniul initial.
            // do some individual menus for each selected options, for eg, ATM

            char selectedOption;

            do {
                selectedOption = Menu();

                if (selectedOption == '1' || selectedOption == '2' || selectedOption == '3' || selectedOption == '4' || selectedOption == '5')
                {
                    // Console.WriteLine(selectedOption);
                    Console.Clear();

                    Console.WriteLine("Do you want to go back? Press Y or N");

                    char selectedChar = Console.ReadKey().KeyChar;
                    if (selectedChar == 'y' || selectedChar == 'Y')
                    {
                        Console.Clear();
                    }
                    else if (selectedChar == 'n' || selectedChar == 'N')
                    {
                        Console.Clear();
                        Console.WriteLine("Nein? kay, bye!");
                        Console.WriteLine("Press any key to close the console. ");
                        Console.ReadKey();
                        break;
                    }
                } else
                {

                    Console.WriteLine("Invalid option");
                }
            } while (selectedOption != 'x');
        }
    }
}
