using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             -Encapsulation, nesnelerimizde ki fıeld'ların kontrollü bir şekilde dışarıya açılmasıdır.
             - Bir başka deyişle, nesnelerimizi başkalarının yanlış kullanımlarından korumak için kontrolsüz değişime kapatmaktır-
            
             */
            Kapsülleme a1=new Kapsülleme();
            a1.A = 15;
        }
    }

    class Kapsülleme
    {
        private int a;

        public int A { get => a; set => a = value; }
    }
}
