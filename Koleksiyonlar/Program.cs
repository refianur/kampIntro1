using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //ctrl k + ctrl c - ctrl k + ctrl u (comment, uncomment)
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];  //bu arrayın yukarıdaki array ile hiç bir bağı yok. burada 5 elemanlı boş bir yeni array tanımladık
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);  //çalıştırdığımı ekranda bunun karşılığı olarak bir şey görünmüyor ama aslında boşluk olarak karşılığı görülüor çünkü tanımladığımız 5 elemanlı yeni array in sadece 4. elemanına bir isim verdik diğerleri boşluk olarak duruyor.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);  //List sayesinde bunu kaybetmeden yeni eklediğimizle beraber okuyabiliyoruz

        }
    }
}
