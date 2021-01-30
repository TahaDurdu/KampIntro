using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManeger
    {    //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdı , string acıklama ,double fiyat,int stokadedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdı);
        }

    }
}
