using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-->tip güvenliği verinin önüne tipini yazmak zorundasın
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapilmisMi = true; //bu true gerçek hayatta veri kaynağından gelir cash gibi
            double dolarBugun = 7.45;
            double dolarDun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Buttonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Button");
            }
            else
            {
                Console.WriteLine("Değişmedi buttonu");
            }


            if (sistemeGirisYapilmisMi==true)
            {
                Console.WriteLine("Kullanıcı Buttonu");
            }
            else
            {
                Console.WriteLine("Lütfen Giris Yapiniz");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
