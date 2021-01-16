using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi_="elma";
            double fiyat = 13;
            string aciklama = "amasya elması";
            

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };                    //Bu satır aslında bir arraydir.


            //tip güvenli --->type safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");
            }


            Console.WriteLine("------Metotlar--------------");
            //encapsulation bu dur.sonradan eklenen prop-lar hataya neden olur bunu encapsulation ile yaptığımızda hata almayız urun1 yaz hata yok olsun propları tek tek yazarsan hata alırsın
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //stokAdedi prop sonradan eklendi ve hat verdi çünkü imzaya uymuyordu. 
            sepetManager.Ekle2("Armut", "yeşil", 12,100); // bu sorunlu yazım şekline ait bu parametreleri vermek zorundasın
            sepetManager.Ekle2("Armut", "sarı", 12,100);

        }
    }
}



//Dont repeat yourself -> DRY- Clean Code--Best Practice