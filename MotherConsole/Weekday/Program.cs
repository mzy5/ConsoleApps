using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert day: ");
            var day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert month: ");
            var month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert year: ");
            var year = Convert.ToInt32(Console.ReadLine());

            var date = new DateTime(year, month, day);

            var weekdate = date.DayOfWeek;

            Console.WriteLine($"This date falls on a {weekdate}");

            Console.ReadLine();
        }
    }
}
