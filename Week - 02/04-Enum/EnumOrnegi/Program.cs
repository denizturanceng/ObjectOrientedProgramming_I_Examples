using System;

namespace EnumOrnegi
{
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }

    class Program
    {
        static void Main()
        {
            Days today = Days.Mon;
            Console.WriteLine("Bugün: " + today);
        }
    }
}
