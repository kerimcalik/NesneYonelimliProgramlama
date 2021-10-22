using System;
using System.Collections.Generic;
using ObjectOriatentedPrograming;

namespace NesneYonelimliProgramlama
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] dizi = { "a", "b", "c" };

            Dictionary<string, int> kisiler = new Dictionary<string, int> {
                {"kişi 1", 12 },
                { "kişi 2", 15},
                { "kişi 3", 16}
            };


            foreach (var item in kisiler)
            {
                var deger = item.Value;
            }

            Singleton.Singleton singleton = new Singleton.Singleton();
            //singleton.Prosedur();
            singleton.PersonelEkle("kerim", "çalık", 123);
            singleton.PersonelEkle("mert", "çalık", 123);
            singleton.PersonelEkle("ata", "çalık", 123);

            //YeniNameSpace.Sinif1
            //NesneProgramlama.YeniSinif
            //Tasitlar.Deniz.Yazdir();

            //Tasitlar.Deniz tasitlar = new Tasitlar.Deniz();
            //tasitlar.Getir();
            //tasitlar.Oku();

            //Seyahat.Deniz deniz = new Seyahat.Deniz
            //{
            //    AdSoyad = "Ahmet Mehmet",
            //    Yas = -100
            //};

            //Console.WriteLine("Ad, Soyad: " + deniz.AdSoyad);
            //deniz.Yazdir();

            //Kalitim.MirasYedi mirasYedi = new Kalitim.MirasYedi();

            DateTime tarihZaman = new DateTime();

            string tarih = tarihZaman.Date.ToShortDateString();



            Console.Read();
        }
    }

    class A
    {
        class A1
        {
            public A1()
            {

            }

            ~A1()
            {

            }

        }

        class A2
        {

        }
    }

    class B
    {
        static string Metod()
        {
            return string.Empty;
        }
    }

    class C
    {
        public class C1
        {
            public static void Prosedur()
            {
            }
        }

        protected class C2
        {
            private static void Prosedur()
            {


            }
        }
    }
}

namespace Seyahat
{
    class Deniz
    {
        private int _yas;
        private string _adSoyad;

        public int Yas
        {
            get
            {
                return _yas;
            }
            set
            {
                if (_yas <= 0 || _yas > 150)
                {
                    value = 0;
                }
                else
                {
                    _yas = value;
                }

            }
        }

        public string AdSoyad
        {
            get
            {
                return "Sayin" + _adSoyad;
            }
            set
            {
                _adSoyad = value;
            }
        }

        public Deniz()
        {
            Yas = _yas;
        }

        public void Yazdir()
        {
            Console.WriteLine("Seyahat > Deniz > Yazdir -> Yaş değeri = " + Yas);
            Console.WriteLine("Ad, soyad: " + AdSoyad);
        }
    }
}

namespace Tasitlar
{
    public class Deniz
    {
        public static void Yazdir()
        {
            Console.WriteLine("Tasitlar > Deniz > Yazdir");
        }

        public void Oku()
        {
            Console.WriteLine("Tasitlar > Deniz > Oku");
        }

        public void Getir()
        {
            Console.WriteLine("Tasitlar > Deniz > Getir");
        }
    }
}

namespace Kalitim
{
    public class Miras
    {
        //field -> alan
        //metot, prosedür
        //property -> özellikler
        internal void Prosedur()
        {

        }

        public string Alan;
        public string Ozellik { get; set; }
    }

    public class MirasYedi : Miras
    {
        public void MirasYediProseduru()
        {
            Prosedur();
            Alan = "10";
            Ozellik = "özellik";
        }
    }

    public class MirasYedininCocugu : MirasYedi
    {
        public void MirasYedininCocuguProseduru()
        {
            MirasYediProseduru();
            Alan = "20";
            Ozellik = "30";
            Prosedur();
        }
    }
}

namespace Singleton
{
    /// Singleton Design
    /// Bu yapıda kullanıcıya kendi başına bir nesne yaratma izni verilmez.
    /// Kullanıcı bizden sadece nesne talep edebilir.Ve bizden nesne talep ettiğinde de biz ona her defasında
    /// bellekte var olan nesneyi veririz.Böylece kullanıcı sadece tek bir nesne ile çalışmak zorunda kalır.
    /// Yani kullanıcı bir iş için 50 tane farklı nesne üretemez.
    /// Mesela SqlConnection nesnesini bazı durumlar da çok üretmek zorunda kalıyoruz.Birden fazla
    /// SqlConnection nesnesi üretip belleğe yük bindireceğimize var olan SqlConnection nesnesi üzerinden
    /// işlem yapmamız performans açısından olumlu olacaktır.
    /// </summary>
    public class Singleton
    {
        private static Singleton _nesnem;

        public Singleton NesneVar
        {
            get
            {
                return _nesnem;
            }
        }

        public Singleton()
        {
            _nesnem = new Singleton();
        }

        public void Prosedur()
        {
            Console.WriteLine("Prosedür çağrıldı");
        }

        public bool PersonelEkle(string ad, string soyad, long tc)
        {
            return true;
        }
    }
}

namespace FactoryMethod
{
    abstract class Oyun
    {
        public abstract void Platform();
    }

    class Atari : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Atari platformu");
        }
    }

    class PC : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("PC platformu");
        }
    }

    class PS : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("PS platformu");
        }
    }

    enum Oyunlar
    {
        Atari = 1,
        PC = 2,
        PS = 3
    }

    class Olustur
    {
        public Oyun FactoryMethod(Oyunlar oyunTipi)
        {
            Oyun oyun = null;
            switch (oyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
                case Oyunlar.PS:
                    oyun = new PS();
                    break;                
            }

            return oyun;
        }
    }
}

