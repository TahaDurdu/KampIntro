using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

        //Array = dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs" , "Java"
            ,"C#","python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            //foreach dizilere uygulanır dizileri tek tek dolaşır.
            foreach ( string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
