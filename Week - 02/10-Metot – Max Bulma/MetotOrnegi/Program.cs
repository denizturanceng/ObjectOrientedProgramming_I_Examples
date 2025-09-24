using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOrnegi
{
    class Program
    {
        static int FindMax(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        static void Main()
        {
            Console.WriteLine("Max: " + FindMax(10, 20));
        }
    }
}

