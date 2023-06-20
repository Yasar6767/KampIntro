using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    //naming convention
    //encapsulation - kapsülleme
    class SepetManager
    {
        public void Ekle(Urun urun) 
        { 
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        
        }

        public void Ekle2(string urunAdi , string Aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
}
