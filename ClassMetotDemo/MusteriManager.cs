using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {


        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>> o <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("Hoşgeldiniz!" + "  " + musteri.Id + " - " + musteri.Ad + " " + musteri.Soyad +" - "+ musteri.MevduatMiktarı + " $");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>> o <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        public void Listele(Musteri musteri) 
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------- Müşteri Listesi -------------------");
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Id + " - " + musteri.Ad + " " + musteri.Soyad + " --> " + musteri.MevduatMiktarı + " $");
            
        }

        public void Sil(Musteri musteri) 
        {

            Console.WriteLine(" ");
            Console.WriteLine("##########################################################");
            Console.WriteLine("Yine bekleriz... " + musteri.Id + " - " + musteri.Ad + " " + musteri.Soyad + " - " + musteri.MevduatMiktarı + " $");
            Console.WriteLine("##########################################################");
        }   
    }
}
