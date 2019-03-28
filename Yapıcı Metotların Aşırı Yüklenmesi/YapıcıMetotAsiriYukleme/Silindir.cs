using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetotAsiriYukleme
{
    class Silindir
    {
        private double r, h, PI =3.1415;

        //Nesne oluşturulurken double tipinden 2 parametre girildiğinde çalışacak olan yapıcı metot.
        public Silindir(double yaricap, double yukseklik)
        {
            r = yaricap;
            h = yukseklik;
        }

        //Nesne oluşturulurken double tipinden 3 parametre girildiğinde çalışacak olan yapıcı metot.
        public Silindir(double yaricap, double yukseklik, double PiSayisi)
        {
            r = yaricap;
            h = yaricap;
            PI = PiSayisi;
        }

        public double Hacim()
        {
            return (PI * r * r * h);
        }

        public double YuzeyAlani()
        {
            return(2 * PI * r * h);
        }


    }
}
