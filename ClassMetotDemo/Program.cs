using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1223;
            musteri1.Adı = "Soner";
            musteri1.Soyad = "ATEŞ";
            musteri1.Son4Hane = 5433;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 1224;
            musteri2.Adı = "Musacan";
            musteri2.Soyad = "UYSAL";
            musteri2.Son4Hane = 5673;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 1225;
            musteri3.Adı = "Adıgüzel";
            musteri3.Soyad = "YILMAZ";
            musteri3.Son4Hane = 2359;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ID + " - " + musteri.Adı + " : " + musteri.Soyad + " : " + musteri.Son4Hane);
            }
        }
    }
}
