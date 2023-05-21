using System;
using System.Reflection.Metadata.Ecma335;

namespace YoutubeNesneTabanlıProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Nesne tabanlı prog. bir yaklaşımdır
            * En küçük esas parçası nesne/obje/object'dir
            * İçersinde veri tutabilecek alanlar tutar bunlar Fielddir
            *Bu field'lerin işleyebilmesi için fonksiyonlar/metodlar vardır.
            *Nesneler birer class ürünüdür.
            *classlarda nesnelerin ortak alan tanımları yapılır.(Mesela bir arabanın rengi, modeli
            kaç yılında üretildiği )
            *
            
            CLASS NEREDE OLUŞTURULUR
            1-Namespace içinde
            2-Class içersinde 
            3-Namespace dışında


            *Aynı isimde birden fazla class oluşturulmaz
            *
             */
            Class_Members model = new Class_Members();
            model.Id = 1;
            #region Class Members(Üyeler)
            #region Field

            /*
             Field:Nesne içersinde veri depoladığımız alanlardır
            Clas içersindeki tanımlanan değişkenlerdir.Herhangi bir türde olabilirler
             */
            Class_Members class_Members1 = new Class_Members();//Nesne oluşturduk
            class_Members1.Id = 2;
            class_Members1.b = "Yusuf";//oluşturduğumuz nesneye class içindeki değerlerini verdik

            Class_Members class_Members2 = new Class_Members();//2. bir nesne oluşturduk
            class_Members2.Id = 3;
            class_Members2.b = "ahmet";//oluşturduğumuz nesneye class içindeki değerlerini verdik
            #endregion
            #region Property
            /*
             nesne içersinde özellik sağlar
            *Özünde bi metod yapısındadır. Ancak metoddan farklı olarak parametre almaz.İçinde get set denen iki yapı bulundurur
            *Proporty'de set olayı ile değer alma get ile de değer okuma işlemleri yapılır.
            *Fieldların kontrollü olarak dışarıya açılmasını sağlar.Bu olaya verilen isim EXCAPSULATİON'dur.
             */
            Proporty proporty = new Proporty();
            proporty.Yasi = 30;
            Console.WriteLine(proporty.Yasi);
            #endregion
            Proporty.metod_(12, 23); 
            #endregion
        }
    }
    /// <summary>
    /// Classların içersindeki yapıları anlatmak için kullandık
    /// </summary>
    class Class_Members//kendi class'ımızı yazdık
    {
        public int Id;//field oluşturduk
        public string b;


    }
    /// <summary>
    /// Proporty yapısını görmek için yaptığımız class
    /// </summary>
    class Proporty
    {

        public static int metod_(int a,int b)
        {
          int sonuc= a + b;
            return sonuc;
        } 
     
        string b;

        private int yasi;

        public int Yasi 
        {
            get { return yasi; }//proporty üzerinden ddeğer talep edildiğinde bu blok çalışır.
            set { yasi = value; }
        }
        public int H { get; set; }


    } 
}
