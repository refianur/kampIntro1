using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID - L

            GercekMusteri musteri1 = new GercekMusteri(); 
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123456789";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager custumorManager = new CustomerManager();
            custumorManager.Add(musteri1);
            custumorManager.Add(musteri2);


        }
    }
}
