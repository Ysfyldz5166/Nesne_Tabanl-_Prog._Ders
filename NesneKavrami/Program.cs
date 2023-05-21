using System;

namespace NesneKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nesne nedir nasıl tanımlanır

            Myclass m = new();
            new Myclass();//Nesne oluşturduk
            Myclass myclass = new Myclass();//Oluşturduğumuz nesneyi Stack bölgesinden referans oluşturduk
            myclass.a = 1;

            new Myclass()
            {
                a = 1,
                myprop1 = 30,
                myprop2 = 40
            };//Oluşturduğumuz nesneye ilk değerlerini vermiş olduk

            Myclass myclass2 = new Myclass()
            {
                a = 5,
                myprop1 = 30,
                myprop2 = 25
            };//Oluşturduğumuz nesneye ilk değerlerini vermiş olduk

            //REFERANS NEDİR?
            /*RAM'in Stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen/referans
            eden değişkenlerdir/ noktalardır.
            
            -Referanslar illaki bir nesne referans etmek zorunda değildir.

             */
            #endregion

            #region shallow kopy(Nesne kopyalama )
            // Bir nesnenin birden fazla referansşa işaretlenmesi olayıdır.
            #region Örnek1
            SallowKopy m1 = new SallowKopy();
            SallowKopy m2 = m1;
            SallowKopy m3 = m2;



            #endregion
            #region Örnek2
            SallowKopy m4 = null;
            SallowKopy m5 = new SallowKopy();
            SallowKopy m6 = m5;
            m4 = m6;
            #endregion
            #region Örnek3
            SallowKopy a1 = new SallowKopy();
            SallowKopy a2 = new SallowKopy();
            SallowKopy a3 = a1;
            a1 = a2;
            a2 = a1;
            a1 = a1; 
            #endregion
            #endregion
        }
    }
    class Myclass
    {
        public int a;
        public int myprop1 { get; set; }
        public int myprop2 { get; set;}
    }

    class SallowKopy
    {

    }
}
