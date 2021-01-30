using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adı = "Taha";
            int yaş = 20;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "java";
            kurs2.Eğitmen = "taha";
            kurs2.İzlenmeOrani = 50;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "python";
            kurs3.Eğitmen = "erencan";
            kurs3.İzlenmeOrani = 30;

            //Console.WriteLine(kurs1.KursAdı + " " + kurs2.Eğitmen + " " + kurs3.İzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı);
            }
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }

        public string Eğitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
