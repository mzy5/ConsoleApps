using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDay
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

            var lastDay = DateTime.DaysInMonth(year, month);

            var lastWeekDay = new DateTime(year, month, lastDay);

            var weekday = lastWeekDay.DayOfWeek;

            Console.WriteLine($"The last day of the month is: {lastDay} and it falls on a {weekday}");

            Console.ReadLine();
        }
    }
}
