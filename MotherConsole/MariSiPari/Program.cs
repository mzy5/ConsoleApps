using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariSiPari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar natural: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(string.Format("Introduceti cele {0} numere naturale:", numar));

            Console.WriteLine($"Introduceti cele {numar} numere naturale:");
            int max = int.MinValue;
            int j = 0;

            for (int i = 0; i < numar; i++)
            {
                Console.WriteLine("Introduceti un numar natural: ");
                int altnumar = Convert.ToInt32(Console.ReadLine());

                if (altnumar % 2 == 0)
                {
                    if (altnumar > max)
                    {
                        max = altnumar;
                        j=1;
                    }
                    else if ( altnumar == max) {
                        j++;
                    }
                }

            }

            Console.WriteLine($"Maximul este: {max}");
            Console.WriteLine($"Numarul lui de aparitii este: {j}");

            Console.ReadLine();

        }
    }
}
/*
Tema 2:

  Citeste de la tastatura un numar natural n si n numere naturale si afiseaza pe randuri separate:
  - cel mai mare număr par introdus
  - numărul său de apariții

  Aplicatia ar trebui sa se comporte astfel:

  Afiseaza textul: Introduceti un numar natural:
  - aici trebuie ca userul sa introduca de la tastatura o valoare si sa dea enter;
 
 Apoi, se afiseaza textul: Introduceti cele { n } numere naturale:
  - aici valoarea n din mesaj va fi inlocuita cu numarul natural citit la primul pas:
 
 De ex daca valoarea introdusa de user este 4 atunci mesajul afisat ar trebui sa fie "Introduceti cele 4 numere naturale:"
  - apoi userul va introduce cele n(sau 4 valori in cazul exemplului) de la tastatura pe rand si dupa fiecare valoare va da enter;
  - dupa ce cele n numere au fost citite se va afisa un mesaj cu textul: Cele {n} numere au fost citite cu succes!
  
  Aici n va li inlocuit cu valoarea citita intial de catre user(daca userul a introdus initial 4 atunci mesajul ar trebui sa fie urmatorul : "Cele 4 numere au fost citite cu succes!"

  Dupa ce valorile cele doua legate de pozitie precum si maxim au fost determinate se vor afiseaza urmatoarele texte:
   [Cel mai mare numar par din sir este] = [cel mai mare numar par din sir]
   [Numarul sau de aparitii este] = [numarul de aparitii al maximului]


*/
