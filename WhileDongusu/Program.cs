using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region İhtiyaç - 0 - 10 arası sayıları yazdırınız
            //TANIMLAMA

            //Bir işlemi birden çok kez yaptırmak istedğimizde döngü kullanırızı
            //Döngü oluşturmak için
            //Kırılabilecek (false) olabilecek bir koşul

            //Başlangıç deşikeni, koşul, iterasyon

            #endregion
            #region Nasıl Çalışır
            //if koşul parantezi true ise çalışır
            //if(true)
            //{
            //    Console.WriteLine("Çalıştı");
            //}

            //while koşul parantei true olduğu sürece çalışır
            //while (true)
            //{
            //    Console.WriteLine("çalıştı");
            //}
            //Console.WriteLine("çalıştı");

            #endregion

            #region 0-100 arası sayıları yazdırınız

            //int sayac = 0;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    //sayac = sayac + 1;
            //    //sayac += 1;
            //    sayac++;

            //}
            #endregion
            #region 0 - 100 arası çift sayıları yazdırınız

            //int sayac2 = 0;
            //while (sayac2 <= 100)
            //{
            //    Console.WriteLine(sayac2);
            //    sayac2 = sayac2 + 2;
            //}
            #endregion
            #region konsoldan alınan başlangıç değerinden 100'e kadar olan çift sayıları yazdırınız.
            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //while (sayi <= 100)
            //{
            //    if(sayi % 2 == 0 )
            //    {
            //        Console.WriteLine();
            //    }
            //    sayi++;
            //}

            #endregion
            #region 0-100 arasındaki pozitif sayıları yazdırınız

            //int sayı = 0;
            //while (sayı <= 100)
            //{
            //    if (sayı >= 0)
            //    {
            //        Console.WriteLine(sayı);
            //    }
            //    sayı++;
            //}
            #endregion
            #region kullanıcıdan alınan sayı ile arasındaki pozitif sayıları yazdırınız
            //Console.WriteLine("Sayı Giriniz: ");
            //int sayı2 =Convert.ToInt32(Console.ReadLine());
            //while (sayı2 <= 100)
            //{
            //    if (sayı2 >= 0)
            //    {
            //        Console.WriteLine(sayı2);
            //    }
            //    sayı2++;
            //}
            #endregion
            #region İçi dolu çeyrek baklava

            //int sayac = 0;
            //string satir = "";
            //while (sayac < 5)
            //{
            //    satir += "*";
            //    Console.WriteLine(satir);
            //    sayac++;
            //}


            //2. YOl

            string satir2 = "";
            while (satir2 != "*****")
            {
                satir2 += "*";
                Console.WriteLine(satir2);
            }

            #endregion

            #region 0-1000 arasında 4'e bölünebilen kaç sayı vardır?

            //int sayac = 0;
            //int adet = 0;

            //while (sayac <= 1000)
            //{
            //    if (sayac % 4 == 0)
            //    {
            //        adet++;
            //    }
            //    sayac++;
            //}
            //Console.WriteLine("0-1000 arasında 4'e bölünebilen " +adet+ " adet sayı vardır.");
            #endregion

            #region  ÖDEVLER
            //0 - 1000 arsaında 4'e bölünebilen kaç sayı vardır? toplamları ne?
            //Konsoldan alınan 5 sayının ortalaması

            #endregion

            #region konsoldan alınan sayıların ortalaması

            //string secenek = "e";
            //double toplam = 0;
            //int sayac = 0;

            //while (secenek == "e") ;
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    toplam += Convert.ToDouble(Console.ReadLine());
            //    sayac++;
            //    Console.WriteLine("Sayı girmeye devam edilsin mi? e/h");
            //    secenek = Console.ReadLine();
            //    Console.Clear();
            //}
            //double ortalama = toplam / sayac;

            #endregion

            #region Kullanıcı Giriş Validation - Ödev

            //kullanıcı adı admin Şifre 1234 ise hoşgeldin
            //Kullanıcı adış boş olmaz
            //şifre boş bolmaz

            #endregion
            #region Kullanıcı Giriş Validation 2 - Ödev

            //kullanıcı adı admin Şifre 1234 ise hoşgeldin
            //Kullanıcı adış boş olmaz
            //şifre boş bolmaz
            //Eğer bunlar boş ise tekrar kullanıcı adı istesin

            #endregion

            //Sayı tahmin oyunu
        }
    }
}
