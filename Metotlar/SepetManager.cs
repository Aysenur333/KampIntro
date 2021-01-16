using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        //Urun yazmassan neyi ekleyeceğini program bilemez...
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:  "+urun.Adi);
        }


        //bu kullanım çalışır ama hatalı bir kullanımdır
        //int stokAdedi sonradan eklendi 
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);
        }

    }
}
