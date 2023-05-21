using System;
using System.Collections;
using System.Collections.Generic;

namespace koleysiyon_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            --Koleksiyon yapılarında tanımlama yaparken  her hangi bir sınır ya da eleman sayısı belirlemize gerek yoktur.
            --Dizileri tanımladığımızda kullansak ta kullanmasak ta bellekte  belli bir alan tutarlar.Kolkesiyonlar ise kullandığımız kadar alan 
            tutarlar
            --Dizi yapılanmalarında sonradan eleman atanabilecek bir yapı mevcut değildir ancak koleksiiyon yapıları zaten değer girildiği kadar büyüyebiliyor.
             
             */
            //Koleksiyon tanımlama
            ArrayList yaslar = new ArrayList();

            //Tanımlanmış koleksiyona değer atama
            yaslar.Add(123);
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                yaslar.Add(rnd.Next(0, 30));
            }

            //Değerleri verilmiş koleksiyonun değer okunması
            Console.WriteLine(yaslar[0]);
            Console.WriteLine(yaslar[1]);
            Console.WriteLine("-------------------------------------------------");
            foreach (var i in yaslar)
            {
                Console.WriteLine(i);
            }
            //Koleksiyon uzunluğu
            //Count ile koleksiyon yapısının uzunluğunu buluruz.

            Console.WriteLine($"Koleksiyonun uzunluğu= {yaslar.Count}");

            /*
            --ArrayList verilen datayı boxing işlemine tabi tutar.
            --ArrayList içersindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir. kendi türünde işlem yapmak istediğimizde umbaxing yapmak zorundayız.
            --
             */

            //Koleksiyona atadığımız sayıları object türünden int'e dönüştürüp ortalamasını almak.
            int toplam = 0;
            double sonuc;

            for (int i = 0; i < yaslar.Count; i++)
            {
                toplam += (int)yaslar[i];
                 sonuc = toplam / yaslar.Count;
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------");

            //LİST KOLEKSİYONU İLE ÇALIŞMAK
            List<string> arkilerim = new List<string> 
            { 
                "yusuf","ece","betül","eren","güray","miraç","meriç",
            };

            foreach (string arkiler in arkilerim)
            {
                Console.WriteLine(arkiler);
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            //Bir class yapısındaki yeni nesneleri koleksiyon yapısı ile tuttuk hatta değerler verdik. 
            List<Customers> customers = new List<Customers>
            {
                new Customers{Id=1,Name="Yusuf"},
                new Customers{Id=2,Name="Mahmut"},
                new Customers{Id=3,Name="Pakize"}
            };

            customers.Add(new Customers { Id = 4,Name= "Mehtap" });
            Console.WriteLine($"Şirketteki çalışan sayısı={ customers.Count }");

        }

        class Customers
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
    }
}
