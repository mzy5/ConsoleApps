using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert day: ");
            var day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert month: ");
            var month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert year: ");
            var year = Convert.ToInt32(Console.ReadLine());

            var date = new DateTime(year, month, day, 18, 33, 0);

            var shortTime = date.ToShortTimeString();
            Console.WriteLine($"Short time: {shortTime}");

            var longTime = date.ToLongTimeString();
            Console.WriteLine($"Long time: {longTime}");

            CultureInfo culture = new CultureInfo("ja-JP");
            var culturePTdate = date.ToString("d", culture);
            Console.WriteLine($"PT culture time: {culturePTdate}");

            var utcTime = date.ToUniversalTime();
            Console.WriteLine($"Universal time: {utcTime}");

            Console.ReadLine();
        }
    }
}
