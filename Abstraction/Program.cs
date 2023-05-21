using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             --Abstraction türkçesi soyutlamadır. Abstraction bir davranıştır.
            --Kod yazımı esnasında bir classtan nesne ürettikten sonra kullanım esnasında sadece gerekli memberlerin getirilmesi olayıdır.
            --Abstarct classlar tercihen kullsnılsn yapılardır.
            --Abstarct classtan biz nesne üretemeyiz. Ancak compailer üretebilir. Başka bir classa abstract classı referans olarak göstererek 
            nesne üretmeyi sağlayabiliriz.
             */
        }
    }
    abstract class AbstractMyClass
    {
        int a;
        public void X()
        {
        
        }

        public int MyProperty { get; set; }
        abstract public void Z();
        abstract public int Y { get; set; }
    }
    class MyClass : AbstractMyClass
    {
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Z()
        {
            throw new NotImplementedException();
        }
    }
}
