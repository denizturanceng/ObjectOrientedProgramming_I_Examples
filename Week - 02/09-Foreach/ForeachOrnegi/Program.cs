using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachOrnegi
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 }; // 

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
