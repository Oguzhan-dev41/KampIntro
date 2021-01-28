using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming Convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi" + urun.Adi);

        }

        public void Ekle2(string UrunAdi,string aciklama,double fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler , Sepete eklendi" + urunAdi);

        }



    }
}
