using System;

namespace WhileOrnegi
{
    class Program
    {
        static void Main()
        {
            int number = 1234, sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Basamak Toplamı = " + sum);
        }
    }
}
