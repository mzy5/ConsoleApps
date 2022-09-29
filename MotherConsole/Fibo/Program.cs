using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        //check the position in the Fibonacci list for the number inserted from keyboard
        public static int Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n==1)
            {
                return 1;
            }

            return Fibo(n - 1) + Fibo(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Insert n: ");
            var n = Convert.ToInt32(Console.ReadLine());

            int result = Fibo(n);

            Console.Write(result);
            Console.ReadLine();
        }
    }
}
