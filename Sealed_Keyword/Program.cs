using System;

namespace Sealed_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            --Bir sınıfın miras vermesini veya bir sınıftan miras alınmayı engelleyen bir keyword'dür.
            --Sadece sınıflarda ve override edilmiş metodlarda kullanılır.
            
             */
        }
    }
    #region Örnek-1
    sealed class A//Kalıtım yapamaması için sealed keyword'ünü kullandık
    {

    }
    class B
    {

    } 
    #endregion

    class C
    {
        public virtual void X() 
        {
            Console.WriteLine("Merhaba aga.");
        }
    }
    class D:C
    {
        public sealed override void X()//Bir metodu sealed keywordu ile işaretleyerek kendisinden sonra bir daha kalıtım almamasını sağladık.
        {
            Console.WriteLine("sana da merhaba D");
        }
    }
    class E:D
    {
        //public override void X()
        //{
        //    Console.WriteLine("Merhaba E");
        //}
    }
}
