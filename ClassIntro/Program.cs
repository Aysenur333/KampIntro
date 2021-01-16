using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ayşenur";
            int yas = 36;

            Kurs kurs1=new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();

            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs2.KursAdi = "python";
            kurs2.Egitmen = "berkan yılmaz";
            kurs2.IzlenmeOrani = 68;

            kurs3.KursAdi = "java";
            kurs3.Egitmen = "kadir yıldız";
            kurs3.IzlenmeOrani = 68;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+": "+kurs.Egitmen);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.IzlenmeOrani);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
