using System;

namespace SwitchOrnegi
{
    class Program
    {
        static void Main()
        {
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Mükemmel!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("İyi iş çıkardın");
                    break;
                case 'D':
                    Console.WriteLine("Geçtin");
                    break;
                default:
                    Console.WriteLine("Geçersiz not");
                    break;
            }
        }
    }
}
