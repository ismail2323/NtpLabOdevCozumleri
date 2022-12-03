using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
    class DonguOrnek
    {
        public void yazdir()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("i = : " + i);
                i++;
            }
        }
    }
    class KararYapısıOrnek
    {
        public void yazdir()
        {
            int a = 5;
            if (a > 0)
            {
                Console.WriteLine("a pozitiftir");
            }
            else if (a < 0)
            {
                Console.WriteLine("a negatiftir");
            }
            else
            {
                Console.WriteLine("a '0' dır");
            }
        }
    }

    class DiziOrnek
    {
        public void yazdir()
        {
            string[] mevsimler = { "İlkBahar", "Yaz", "Sonbahar", "Kış" };
            foreach (string a in mevsimler)
            {
                Console.WriteLine(a);
            }
        }
    }
    class MetotAsiriYukleme
    {
        public void yazdir(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void yazdir(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    class Yapici
    {
        public Yapici(int a, int b)
        {
            Console.WriteLine(a * b);

        }
    }
    class Zaman
    {
        public int Saat; public int Dakika; public int Saniye;
        public Zaman(int saat, int dakika, int saniye)
        {
            Dakika = dakika + saniye / 60;
            Saniye = saniye % 60;
            Saat = saat + Dakika / 60;
            Dakika = Dakika % 60;
        }

        public static Zaman operator +(Zaman a, Zaman b)
        {
            int ToplamSaniye = a.Saniye + b.Saniye;
            int ToplamDakika = a.Dakika + b.Dakika;
            int ToplamSaat = a.Saat + b.Saat;
            return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
        }
    }
       enum notu : byte { basarisiz = 0, basarili }
        class Numaralandırma
        {
        static void Main()
        {
            notu a = notu.basarili;
            if (a == (notu)1)
            Console.Write("Başarılısınız");
            else
            Console.Write("Başarısızsınız");
        }
        }        struct üniversite
        {
        public string fakulte; public string bolum; public string Ogr_gor;
        public üniversite(string a, string b, string c)
        {
            fakulte = a; bolum = b; Ogr_gor = c; }
        }
        class structornek
        {
        public  void yazdir ()
        {
            üniversite k1 = new üniversite("Teknoloji Fakültesi", "Yazılım Mühendisliği", "2.sınıf");
            üniversite k2;
            Console.WriteLine(k1.fakulte);
            Console.WriteLine(k1.bolum);
            Console.WriteLine(k1.Ogr_gor);
            k2.fakulte = "Tıp Fakultesi";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
        }
        }        abstract class Hayvan
        {
        public abstract void ses();
       
        }
        class kus : Hayvan
        {
        public override void ses()
        {
            Console.WriteLine("cik cik");
        }
        }
        class kedi : Hayvan
        {
        public override void ses()
        {
            Console.WriteLine("miyav");
        }
        }
        interface Telefon
        {
        void bellek();
        void ram();
        void ekran();
        }
        class Xioami : Telefon
        {
         public void bellek()
        {
            Console.WriteLine("256 GB");
        }
        public void ram()
        {
            Console.WriteLine("8 GB");
        }
        public void ekran()
        {
            Console.WriteLine("90 Hz");
        }

        }
        class HataOrnek
        {
         public void hataYakalama ()
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (Exception)
            {
                Console.WriteLine("Geçersiz değer girişi");
            }
        }

        }
}





