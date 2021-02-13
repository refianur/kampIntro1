using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;     //burada sayi1 sayi2 nin değerini alır ve sayi2 ile bağını koparır daha sonra sayi2 nin başına gelenler sayi1 bağlamaz
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };      //new : stack belleğinden heap e bir adres oluşturu tanımlıyor
            int[] sayilar2 = new int[] { 100, 200, 300 };              //stack            heap
            sayilar1 = sayilar2;                                       //sayilar1         [10,20,30]  mesela bu 101 numaralı adres      Burda eşitleme yaptığımızda sayilar1 in referans numarasını
            sayilar2[0] = 999;                                         //sayilar2         [100,200,300]      bu  102 numaralı adres      sayilar2 nin referans numarasına eşitliyoruz yani sayilar1 in 101, 102 ye dönüşüyor
            //sayilar1[0] ?? 999

            //int, decimol, float, double, bool(0-1), -- değer tip
            //array, class, interface -- referans tip
            //bellekte iki tane yerimiz vardır : 
              //stack - değer tipler , heap - adres gibi
              
        }
    }
}
