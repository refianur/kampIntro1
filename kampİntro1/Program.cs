using System;

namespace kampİntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself

            //Console.WriteLine("Kategori");
            //Console.Writeline("Kategori");
            //Console.WriteLine("Kategori");

            //kategoriEtiketi - değer tutucu, takma isim, alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun) 
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else 
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else 
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

            

        }
    }
}
