using System;

namespace ObjectOriatentedPrograming
{
    public class Program
    {
        static void ForOlustur()
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }

        public static void Main(string[] args)
        {
            Calisan calisan = new Calisan(321313, "kerim","çalık");
           
        }


    }

    public class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TcNo { get; set; }
        
        public static void IseAl()
        {

        }

        public Calisan(int name, string surname)
        {

        }

       
        public Calisan(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public Calisan(string ad, string soyad, long tc)
        {
            Ad = ad;
            Soyad = soyad;
            TcNo = tc;
        }
    }

    public class OzelCalisan: Calisan
    {
        public int OzelCalisanId { get; set; }
    }

    public class TamZamanliCalisan: OzelCalisan
    {
        
    }

    public class YariZamanliCalisan : Calisan
    {

    }

    public class StajyerliCalisan : Calisan
    {

    }
}
