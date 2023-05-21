using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kalıtım genel not
            /*
                 --Inheritance(Kalıtım): NEsne tabanlı programlamanın en önemli özelliğidir.
                --Üretilen nesneler farklı nesnelere özelliklerini aktarabilmektedirler.
                --Her iki nesnede de ortak olan prop'ların tekrar tekrar tanımlanmasının önüne geçer.
                --C# da kalıtım sınıflara özel bir niteliktir.Bir sınıf sadece bir sınıftan kalıtım alabilir.
                --
    */ 
            #endregion
            Yazilimci yazilimci = new Yazilimci();
            yazilimci.Cinsiyet = true;
            yazilimci.Isim = "yusuf";
            yazilimci.Soyisim = "YILDIZ";
            yazilimci.Yas = 19;/*Kalıtımsal olarak alınmış bütün özellikleri içersine herhangi bir member
            tanımlamadan kullanabilmiş olduk. 
*/
        }
    }
    class Personel//Bir şirkete çalışan bütün elemanların ortak olarak sahip olacağı özelllikleri burada tanımladık
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set;  }
        public bool Cinsiyet {  get; set; }
        /*Bu class kalıtımı veren class olduğu için bu classa base class ismi verilir.
        --Bir classın sadece 1 tane base classı olur. 
         
         */
    }

    class Müdür : Personel// Derived/Child class
//      ' : ' operatörünü koyduktan sonra hangi sınıftan kalıtım almak istiyorsak o classın ismini yazdık ve kalıtım işlemini gerçekleştirdik.

    {
        /*Bu klas ise Müdür, Yazılımcı ve Stajyer clasları gibi Personel classından kalıtım aldığı için
        Derived/Child class denir  
         */
    }
    class Yazilimci : Personel// Derived/Child class
    {
        public string[] Kullandigidiller { get; set; }
    }
    class Stajyer : Personel// Derived/Child class
    {


    }
    //Oluşturulan bütün sınıflar Object sınıfından gelirler.
}
