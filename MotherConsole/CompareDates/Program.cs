using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDates
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Insert first date: ");
            Console.Write("Insert day: ");
            var day1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert month: ");
            var month1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert year: ");
            var year1 = Convert.ToInt32(Console.ReadLine());

            var firstDay = new DateTime(year1, month1, day1);


            Console.WriteLine("Insert second date: ");
            Console.Write("Insert day: ");
            var day2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert month: ");
            var month2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert year: ");
            var year2 = Convert.ToInt32(Console.ReadLine());

            var secondDay = new DateTime(year2, month2, day2);

            if (firstDay > secondDay)
            {
                Console.WriteLine($"{firstDay} is a more recent date");
            }
            else
            {
                Console.WriteLine($"{secondDay} is a more recent date");
            }
            Console.ReadLine();
        }
    }
}
