using System;
using System.Runtime.InteropServices;

namespace Virtual_Override_Sanal_Yapılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Sanal yapılar, bir sınıf içerisinde bildirilmiş olan ve o sınıftan türeyen 
            alt sınıflarda da tekrar bildirilebilen yapılardır.
               Sanal yapı kullanıldığında hangi classtan çağrıldığına run time de kara verilir.
               Classda sanal yapı oluşturmak için Virtual keywordü kullanmak yeterlidir.
            */

            #region Oluşturulan sanal yapıların Override edilmiş halleri yazdırıldı.
            //Obje obje = new Obje();
            //obje.Bilgi();
            //Terlik terlik = new Terlik();
            //terlik.Bilgi();
            //Kalem kalem = new Kalem();
            //kalem.Bilgi(); 
            #endregion
            #region Örnek-2
            //Memeli memeli = new Memeli();
            //memeli.konus();
            //İnsan insan=new İnsan();
            //insan.konus();
            //İnek inek = new İnek();
            //inek.konus();
            #endregion

            #region Örnek-3
            Ucgen ucgen=new Ucgen(4,6);
            Console.WriteLine(ucgen.Alanhesapla());
            Dikdortgen dikdortgen=new Dikdortgen(2,4);
            Console.WriteLine(dikdortgen.Alanhesapla());
            #endregion
        }
    }
    #region Sanal bir yapı oluşturma gösterildi
    class MyClass
    {
        public void MyMethod()
        {
            //Normal bir proporty tanımlaması yaptık.
            //Derleme zamanında hangi class dan çağırılacağı bellidir.
            //Sanal olmadığı için başka bir classda tekrar kullanırsak Name heiding olayı gerçekleşir.


        }
    }
    class MyClass2
    {
        public virtual void MyMethod()
        {
            //Sanal bir proporty tanımlaması yaptık.
            //Derleme anında hangi kclassdan çağırılacağı belli değildir run time anında belli olur.
            //Başka bir classda ezilebilir değiştirilip tekrardan yazılabilir.
        }
    } 
    #endregion
    #region Virtual ve Override işlemi örneği verildi
    //Bir sanal yapı oluşturma ve override edilme olayıı inceleyelim.
    class Obje
    {
        public virtual void Bilgi()
        {
            Console.WriteLine("ben bir objeyim...");
        }
    }
    class Terlik : Obje
    {
        override public void Bilgi()
        {
            Console.WriteLine("Ben bir terliğim...");
        }
    }
    class Kalem : Obje
    {
        override public void Bilgi()
        {
            Console.WriteLine("Ben bir kalemim...");
        }
    }
    #endregion

    #region Örnek-2
    class Memeli
    {
        virtual public void konus()
        {
            Console.WriteLine("Ben bir memeliyim");
        }
    }
    class İnsan : Memeli
    {
        public override void konus()
        {
            Console.WriteLine("Ben bir insanım...");
        }
    }
    class İnek : Memeli
    {
        public override void konus()
        {
            Console.WriteLine("Ben bir ineğim...");
        }
    }
    #endregion

    #region Örnek-3
    class Sekil
    {
      public  int _boy;
      public  int _en;
        public Sekil(int boy, int en)
        {
            _boy = boy;
            _en = en;  
        }
       virtual public int Alanhesapla()
        {
            return 0;
        }

    }
    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en):base(boy, en)
        {
            
        }
        public override int Alanhesapla()
        {
            return _boy * _en;
        }
    }
    class Dikdortgen:Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy, en)
        {

        }
        public override int Alanhesapla()
        {
            return _boy * _en;
        }
    }
    #endregion
}
