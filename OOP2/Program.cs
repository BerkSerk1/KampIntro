using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "berk";
            musteri1.Soyadi = "gngr";
            musteri1.TcNo = "65484321576";

            //doflama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4537687421";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "6541";

            //Gerçek müşteri - Tüzel müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(musteri1);
            customermanager.Add(musteri2);


        }
    }
}
