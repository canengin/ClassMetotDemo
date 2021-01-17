using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler, Ekleme işlemi başarıyla gerçekleşmiştir. ID : "+ musteri.Id);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler, Silme işlemi başarıyla gerçekleşmiştir. ID :"+ musteri.Id);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler, Günceleme işlemi başarıyla gerçekleşmiştir. ID :"+ musteri.Id);
        }

    }
}
