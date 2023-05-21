using System;

namespace Static_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
             new MyClass();
             new MyClass();


            /*Bir sınıftan nesne üretilirken ilk tetiklenen fonksiyon static constructor'dur.
             -- static constructor ilgili class'dan tanımlanan ilk nesne üretilirken tetiklenir.
            Diğer nesne üretimlerinde normal constructor çalışır.
            --
             */
        }
    }
    class MyClass
    {
        public MyClass()
        {
            //Normal constructor yapısı tanımladık
            Console.WriteLine("Myclass constructoru tanımlandı");
        }
        static MyClass()
        {
            Console.WriteLine("Myclass static constructoru tanımlandı");

            //Static constructor yapısı tanımladık
            /*ilk üretilecek nesne için bu constructor tetiklenir ancak üretilecek diğer nesnelerde
            normal constructor tetiklenir.
             */
            //Üretilen ilk nesnenin dışında birdaha tetiklenmez.
            /*Static constructor'ın tetilenmesi için illaki ilk nesne üretimi yapılmasına gerek yoktur.
            İlgili sınıf içersinde herhangi bir static yapılanmanında statict constructr'ı tetiklemesini sağlar.
            
             
             */
        }
    }
}
