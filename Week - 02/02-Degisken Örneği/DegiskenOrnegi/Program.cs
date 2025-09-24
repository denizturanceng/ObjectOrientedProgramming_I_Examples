using System;

namespace DegiskenOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            short x;   // -32.768 ile 32.767 arasında değer alır. Tam sayı.
            int y;     // -2.147.483.648 ile 2.147.483.647 arasında değer alır. Tam sayı.
            double z;  // Ondalıklı sayılar için kullanılır.

            x = 10;
            y = 20;
            z = x + y;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", x, y, z); // yer tutucular sayesinde a= gibi yazabildik.
        }
    }
}
