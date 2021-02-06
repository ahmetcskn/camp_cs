using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" "+ musteri.Soyad + "Adlı kullanıcı sisteme eklendi. ID : " + musteri.id);
        }
    }
}
