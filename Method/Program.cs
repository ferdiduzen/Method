using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 850800;
            urun1.Adi = "elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Id = 880000;
            urun2.Adi = "karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyat);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("***********");


            }

            SepetManager sepeteEkle = new SepetManager();
            sepeteEkle.Ekle(urun1);
            sepeteEkle.Ekle(urun2);


            Console.ReadLine();

        }
    }
}
