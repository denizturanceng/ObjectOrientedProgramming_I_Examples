using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOrnegi
{
    class Program
    {
        static void Main()
        {
            string name = "Amasya University";

            Console.WriteLine("Length: " + name.Length);
            Console.WriteLine("Upper: " + name.ToUpper());
            Console.WriteLine("Lower: " + name.ToLower());
            Console.WriteLine("Replace: " + name.Replace("University", "Üniversitesi"));
        }
    }
}

