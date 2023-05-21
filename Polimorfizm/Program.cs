using System;

namespace Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            -- Polimorfizm esasında bir biyolojik terimdir.
            -- Bir nesnenin birden fazla farklı türdeki referans tarafından işaretlenmesi Polimorfizm'dir
            -- Bir nesnenin, birden fazla referansla işaretlenmesi türün davranışlarını gösterebilmesini sağlar.
            -- Programlama da polimorfizm en temelden berri kullanılmaktadır.
            -- OOP'de polimorfizm aralarında kalıtımsal ilişki olan sınıflar da uygulanabilir.
            -- Bir nesneyi hangi referans ile işaretlersek o referansın özelliklerine ulaşabiliriz
             */
            Myclass2 myClass = new MyClass();//Myclass2 den kalıtım Almış Myclass'ı Refrans aldığı Myclass2 ile işaretleyebildik
            //Bu durum polimorfizm sayesinde oldu.


            A a=new B();
            a.X = 1;//A referansı ile işaretlendiği için sadece X özelliğini alabilirim Y özelliği burada gelmez.
            B b= new B();
            b.X = 2;//B referansı ile işaretlediğim için hem X hem de Y özelliğine ulaşabilirim.
            b.Y = 3;
            //Yukarıdaki olayda polimorfizm sayesinde B nesnesini hem A yı hem de B yi referans göstererek oluşturabildik.
            
        }
    }
    #region Örnek-1
    class MyClass : Myclass2//Myclass2'den kalıtım aldık
    {

    }
    class Myclass2
    {

    }
    #endregion
    #region Örnek-2
    class A
    {
        public int X { get; set; }
    }
    class B : A
    {
        public int Y { get; set; }
    } 
    #endregion
}
