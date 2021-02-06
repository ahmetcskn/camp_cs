using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Karasu";
            musteri1.id = 52;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Kasımoğlu";
            musteri2.id = 31;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Coşkun";
            musteri3.id = 165;
        }
    }
}
