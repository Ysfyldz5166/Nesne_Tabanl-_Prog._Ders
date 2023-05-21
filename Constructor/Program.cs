using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructor nedir?
            /*
          CONSTRUCTOR(YAPICI)  
     -Constructur bir nesne üretimi sürecinde ilk tetiklenen metoddur
     -Nesne oluşturma sürecinde mutlaka tetiklenmek zorundadır
     -Nesnenin yaratılma aşamalarında içindeki field'lara ilk değer atamakla yükümlü olabilir

     */
            #endregion
            #region Constructor Nasıl Tanımlanır?
            /*
            - Constructor, özel bir sınıf elemanıdır,
            - Özel olsada fıtrat olarak bir metottur,
            - Lakin bildiğimiz metot imzalarından bir nebze farka sahiptin
            - Constructor'ların;
                **Method adı sınıf adıyla aynı olmalıdır.(Özel sınıf elemanları dışında hiçbir member sınıf adıyla aynı olamaz)
                **Geri dönüş değeri olmaz/tanımlanmaz
                **Erişim belirleyicisi public olmalı
             */
            #endregion


            new Constructor("yusuf");

            Constructor a = new();

            //Her classın bir difa
        }
    }
    class Constructor
    {
        public Constructor()//constructor yazdık
        {
            #region Tanım özellikleri
            //class ismi ile aynı isimde
            //feriye dönüş değeri tanımlamadık
            //public erişim belirleyicisi ile tanımlandı 
            #endregion
            #region difault constructor
            //her class da mutlaka bir difault constructor vardır. Biz class içersinde constructor yazarsak difault olan constructor'u ezmiş oluruz.

            #endregion

            Console.WriteLine("Bir adet constructor nesnesi oluşturuldu");


        }
        #region Parametreli constructor
        public Constructor(int a)
        {
            //Constructor'umuz parametre alabilir. Overloding kuralı burada da geçerlidir.
            
        }
        #endregion

        //Constructor'ın işaret belirleyicisini private yaparsak nesne tanımlayamayız
        #region This ile constructorlar arası geçiş

        public Constructor(string a):this()//This ile seçtiğimiz constructor daha önce çalışır
        {
            Console.WriteLine(a );
        }
        #endregion

    }
}
