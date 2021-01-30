using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.ADi = "Taha";
            musteri1.Soyadi = "Durdu";
            musteri1.TcNo = "123456789";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek müşteri - Tüzel müşteri
            //SOLİD

            Muşteri musteri3 = new GercekMusteri();
            Muşteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
