using System;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Destructor nedir?
            /*
             --Yıkıcı metod da denir
             --Bir class'tan üretilmiş olan nesne imha edilirken otomatik çağrılan metoddur
             --C# programlama dilinde destructor sadece class yapılanmasında kullanılabilir ve bir
            class sadece ve sadece bir destructor barındırır
             --İçersinde parametre bulundurmaz.
             */
            #endregion
            #region İlgili Nesne hangi şartlarda kim tarafından  imha edilir
            //BİR NESNENİN İMHA EDİLMESİ İÇİN;
            /*
             1-İlgili nesne herhangi bir referans tarafından işaretlenmemelidir
             2-Nesnenin oluşturulduğu ve kullanıldığı scope sona ermiş olmalıdır
             3-İlgili nesneye bir daha erişilemez hale gelinmelidir
             */
            // bu durumlarda nesne imha edilir(GARBAGE COLLECTOR TARAFINDAN)
            #endregion
            A();
            GC.Collect();
            Console.ReadLine();//İmha ediciyi çalıştırdık
        }
        static void A()
        {
            MyClass a = new MyClass();
        }
    }
    #region Destructor tanımlama 
    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("Nesne imha ediliyor");
        }
    }
            #endregion

}
