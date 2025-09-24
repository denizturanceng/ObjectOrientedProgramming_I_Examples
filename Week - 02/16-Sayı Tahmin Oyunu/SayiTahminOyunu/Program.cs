using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int hedef = rnd.Next(1, 31);

            int tahmin;
            Console.WriteLine("1-30 arasında bir sayı tuttum. Tahmin Et.");

            while (true)
            {

                Console.WriteLine("Tahminini Gir: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if(tahmin >= 1 && tahmin <= 30)
                {
                    if (tahmin > hedef)
                        Console.WriteLine("Daha küçük bir sayı dene.");
                    else if (tahmin < hedef)               
                        Console.WriteLine("Daha büyük bir sayı dene.");
                    else
                    {
                        Console.WriteLine("Tutturdun!");
                        break;
                    }
                        
                }
                else
                {
                    Console.WriteLine("Girdiğin değer istenilen aralıkta değil.");
                    continue;
                }

            }
            Console.ReadLine();
        }
    }
}
