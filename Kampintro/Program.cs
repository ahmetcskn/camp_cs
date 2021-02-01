using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarBugun = 6.00;
            double dolarDun = 7.50;
            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Düşüş Sembolü");
            }
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Sembolü");
            }
            if (dolarDun==dolarBugun)
            {
                Console.WriteLine("Eşit Sembolü");
            }
        }
    }
}
