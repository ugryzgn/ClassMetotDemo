using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456789;
            musteri1.Ad = "Uğur";
            musteri1.Soyad = "Yazgan";
            musteri1.MevduatMiktarı = 15000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 135791113;
            musteri2.Ad = "Samed";
            musteri2.Soyad = "Doğan";
            musteri2.MevduatMiktarı = 45000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 24681012;
            musteri3.Ad = "Kağan";
            musteri3.Soyad = "Karaköse";
            musteri3.MevduatMiktarı = 50000;

            //Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteri1);


        }
    }
}
