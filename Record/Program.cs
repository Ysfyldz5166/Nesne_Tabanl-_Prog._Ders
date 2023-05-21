using System;

namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region init-Only prop
            MyClass a2;/*class içersinde Set bloğu silindiği için Burada değer atama işlemi yapılamaz.
            Bu yapıdaki proportylere getter-only proporty denir.
                        
                        */

            MyClass a1 = new MyClass
            {

                MyProperty1 = 1,
            };/*
               Burada ise C#' ın bi özelliği olan init-only proporty özelliği sayesinde Burada değer ataması yapabildik.
            İnit-only proporty'nin tanımlama şekli aşağıdaki class'da mevcut
               */
            #endregion

            #region Recard
            //Değiştirelemez objeler oluşturmak için kullanılır
            Myrecord b1 = new Myrecord() { 
            
            MyProperty= 2,
            };
       
            #endregion

        }
    }

    class MyClass
    {
        public int MyProperty { get; } = 3;//proporty'nin set bloğunun kaldırılması read-only olmaktadır
        public int MyProperty1 { get; init; }

    }

    record Myrecord
    {
        public int MyProperty { get; init;}
    }
}
