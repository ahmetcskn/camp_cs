using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "Java kursu";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" 
            , "Proglamlamaya Başlangıç İçin Temel Kurs", 
              "Java Kursu", "Python Kursu", "Javascript Kursu"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine();
            Console.WriteLine("For Bitti");
            Console.WriteLine();

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine();
            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
