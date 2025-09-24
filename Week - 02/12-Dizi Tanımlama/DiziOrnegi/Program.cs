using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnegi
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 2;
            }

            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
        }
    }
}
