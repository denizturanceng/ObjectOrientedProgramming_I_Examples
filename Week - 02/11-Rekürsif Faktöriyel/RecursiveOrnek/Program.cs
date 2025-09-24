using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveOrnek
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        static void Main()
        {
            Console.WriteLine("Faktöriyel: " + Factorial(5));
        }
    }
}
