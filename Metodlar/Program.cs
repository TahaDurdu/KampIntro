using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Açiklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("---------Metotlar-----------");
            //class örneği oluşturma
            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);

            sepetManeger.Ekle2("Armut","Yeşil Armut",12,89);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 22,78);
            sepetManeger.Ekle2("Karpuz", "Diyarbakır Karpuzu", 36,41);
        }

    }
}
