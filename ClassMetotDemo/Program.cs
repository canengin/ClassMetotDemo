using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();

            musteri1.Id=1;
            musteri1.Adi="Can";
            musteri1.Soyadi="Engin";
            musteri1.TcNo="12345678910";
            musteri1.EPosta="canengin@canengin.com";

            musteri2.Id=2;
            musteri2.Adi="Engin";
            musteri2.Soyadi="Can";
            musteri2.TcNo="12345678910";
            musteri2.EPosta="engincan@engincan.com";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------------------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.WriteLine("-------------------------");
            musteriManager.Guncelle(musteri1);
            musteriManager.Guncelle(musteri2);
            
            Musteri[] musteriler = new Musteri[]{musteri1,musteri2};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad : " + musteri.Adi);
                Console.WriteLine("Soyad : " + musteri.Soyadi);
                Console.WriteLine("-------------------------");
            }
            Console.ReadKey();
        }
    }
}
