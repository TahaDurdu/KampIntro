using System;

namespace kamp1._ders
{
    class Program
    {
        static void Main(string[] args)
        {
            string katagorietiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            bool sistemegirişyapmişmi = false ;
            double dolardun = 7.55;
            double dolarbugun = 7.55;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            

            if (sistemegirişyapmişmi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu ");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}