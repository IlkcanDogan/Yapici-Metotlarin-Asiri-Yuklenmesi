using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetotAsiriYukleme
{
    class Program
    {   
        /*
         * Yapıcı Metotların Aşırı Yüklenmesi
         * 
         * Tıkpı sıradan metotlar gibi yapıcı metotlarda aşırı yüklenebilir.
         * Parametre sayısı ve parametre tipinden en az birisinin farklı olması şartıyla
         * birden fazla yapıcı metot tanımlanabilir.
         *-------------------------------------------------
         *Varsayılan Yapıcı Metot
         *
         * Her sınıfın biz tanımlasak da tanımlamasak da bir yapıcı metodu vardır. Bu yapıcı
         * metoda "varsayılan yapıcı metot" denilir. Default olarak sınıf içerisinde yer alan
         * bu yapıcı metotdun görevi; sınıf içerisindeki özelliklere (değişkenlere) herhangi bir
         * ilk değer vermediğimizde, bu özelliklerden numerik olanlara "0", bool tipinden olanlara
         * "false" ve string gibi referans tipli olanlara da "null" değerini atamaktadır.
         */
        static void Main(string[] args)
        {
            //3.Parametre girilmediği için PI başlangıç değeri (3.1415) olacaktır.
            Silindir s1 = new Silindir(4,6);
            Console.WriteLine("Silindirin Hacmi: {0}\nSilindirin Yüzey Alanı: {1}\n",s1.Hacim(), s1.YuzeyAlani());

            //3.Parametreye girilen PI değeri atanacaktır.
            Silindir s2 = new Silindir(4,6,3);
            Console.WriteLine("Silindirin Hacmi: {0}\nSilindirin Yüzey Alanı: {1}", s2.Hacim(), s2.YuzeyAlani());

            Console.ReadLine();
        }
    }
}
