using System;
using Public_Deneme_Class;

namespace Erisim_Belirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            --Private: Sadece tanımlandığı blok içersinde ulaşılabilir.
            --Protected:Bu erişim belirleyici ile işaretleme durumlarında kalıtım alan sınıflarda da kullanılabilir.
            --İnternal: Class yapılarının default erişim belirleyicisidir. Projemiz içersinde istediğiimiz yerden erişebilmemizi sağlar.
            --Public: Farklı farklı projelerde de kullanabilmemiz için gerekli olan erişim belirleyicisidir.
             */
            int a = 5;//private erişim belirleyici bir değişkendir. Başına privet yazmamıza gerek kalmaz bir şey yazmazsak private olur.

            MyClass myClass = new MyClass();/* Başka bir projede bulunan Myclass'ı Bu projeye getirdik ve class dan nesne ürettik
                                             Nesneyi Public_Deneme_Class projesinden referans gösterdik*/
        }
    }
    #region Protected örnek
    class MyClass1
    {
        protected int Id { get; set; }
    }
    class MyClass2 : MyClass1
    {
        public void method1()
        {
            Id++;
        }
    } 
    //Protected ile işaretlenmiş bir proporty'e başka bir clasta kalıtım aldığı için erişebildik.
    #endregion
}
