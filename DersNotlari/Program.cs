using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersNotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Notlar
            //namespace: içinde classlari bulunduran yapilardır.

            // İki slash notlar için kullanılır.

            // {} : Blok yapısı (scope)

            // Class: İçinde metodları bulunduran yapılardır.

            // Metod: İş yapan kod bloklarıdır.

            // Main metodu: Konsol uygulamalarının giriş noktasıdır. (Anahtar)

            // Syntax: Kod yazım kuralları

            // --->Scope tanımlamalarının sonuna noktalı virgül gelmez.

            // Derleme(Compie): C# --> MS-IL-->(exe)--> Runtime --> Makina Dili(0-1)

            // Control + B tuşu ile sadece derleme yapabilirsin.

            // Control e basılı tutup sırayla K tuşuna ve D tuşuna bas çek yaparsan kodlar düzenlenir.

            // Control e basılı tutup sırasıyla K tuşuna ve C tuşuna bas çek yaparsan seçili bölümü notlara çevirir.

            //----> Control e basılı tutup sırasıyla K tuşuna ve U tuşuna bas çek yaparsan seçili bülümü notlardan kodlara çevirir.

            // */ ___yazı_______ /* ---> Yazı kısmı nota dönüşür.

            // IntelliSense : Kod yazım yardımcısı
            //IntelliCode : Yapay zeka kod yardımcısı

            // Solution : İçerisinde bir ya da birden fazla proje bulunduran yapılardır. Projelerin disk üzerinde kayıtlı olduğu yer bilgisini tutar.
            //---> Birden fazla dosya olduğunda hepsini açar.,


            // *************  .NET  *************************
            // Microsoft tarafından geliştirilen bir yazılım geliştirme platformudur. (framework)


            //**************  .NET Bileşenleri  ********************
            // 1- Programlama Dilleri: C#-VB-F#
            // 2- Editörler: Visual Studio - Visual Studio Code
            // 3- Kütüphaneler: Namespace
            // 4- Runtime 


            //*********** .NET ile Yapılabilecekler ***************
            // 1- Desktop applications (Console, Windows forms app)
            // 2- Web Applications (Gazi OBS, LMS)
            // 3- Mobile applications (Android-İOS) xamarin applications
            // 4- Game Development : Unity
            // 5- IoT : Internet Of Things : Akıllı Cihazlar
            // 6- AI : Yapay Zeka 

            ////-------------- C# VERİ TÜRLERİ ------------------
            //// 1- Değer tipi (Value Type) ---> STACK
            //int sayi = 50;
            //byte number = 50;
            //Console.WriteLine(sayi); //----> sayi değeri yazdırılır
            //Console.WriteLine(number);//------> number değeri yazdırılır.

            // "const int ... = ....;"  değerleri değiştirilemez.
            // const byte a = ..;

            //byte a;
            //double d;
            //a = 30;
            //d = 40;                   
            //      BUNU KISALT
            //byte a = 30;
            //double d = 40;

            //byte a, b;a = 30;b = 40;

            /*
             8 bit = 1 byte
            1024 byte = 1 kilobyte
            1024 KB = 1 MegaByte
            1024 MB = 1 GigaByte


            sbyte (8bit): -128 _ +127 aralığı
            short(16 bit): -32768 _ +32767 aralığı
            long (64 bit) : 

            *\




            /*


            */
            #endregion



            #region String biçimlendirme
            /*
            string isim = "Ahmet", soyad = "Mehmet";
            Console.WriteLine("merhaba " + isim + " " + soyad); //\
            Console.WriteLine("Merhaba {0} {1}", isim, soyad);//  \ AYNI
            Console.WriteLine($"Merhaba {isim} {soyad}");    //    \
            */
            #endregion



            #region isim soyisime göre merhaba

            //Console.WriteLine("İsminizi Giriniz");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyisminizi Giriniz");
            //string Soyisim = Console.ReadLine();
            //Console.WriteLine("Yaşınızı giriniz");
            //byte yas = byte.Parse(Console.ReadLine());
            //Console.WriteLine($"Hoşgeldin  {isim} isimli,{Soyisim} soyisimli,{yas} yaşlı kullanıcı");


            //tip güvenliği(type safety) = Atanmak istenen değer ile o değerin atanacağı değişkenin veri tipi aynı ya da uyumlu olmalıdır.
            //Ancak atamanın yapılmasında teknik olarak bir sorun yoksa tür dönüşümü yöntemleriyle sorun çözülebilir.


            #endregion




            #region Tür Dönüşümleri
            //var sayi = 50; ---> var uygun değeri otomatik atar.
            /*
             TÜR DÖNÜŞÜMLERİ (TYPE CASTING)
            */
            /*
            byte sayi = 20;
            int number = sayi; // Implicit Type Casting (küçük türden büyük türe yapılan dönüşümler otomatik olarak gerçekleştirilir.)
            */

            //checked
            //{
            //int sayi = 257;
            //byte number = (byte)sayi;//Explicit Type Casting = Açık açık bizim yaptığımız dönüşümlere denir.
            //                             //RİSK!!!!
            //                             //BÜYÜK TÜRDEN KÜÇÜK TÜRE DÖNÜŞTÜRMEDE VERİ KAYBI RİSKİ VARDIR.
            //    Console.WriteLine(number);

            /*
              STRİNG ---> DEĞER TİPİ
            */
            //string sayi = "20";
            //byte number = Convert.ToByte(sayi);
            //byte number = byte.Parse(sayi);
            #endregion








            #region OPERATÖRLER
            /*
             1 || 1 = 1
             1 || 0 = 1
             0 || 1 = 1
             0 || 0 = 0

             1 && 1 = 1
             1 && 0 = 0
             0 && 1 = 0
             0 && 0 = 0


            */
            //double maas = 5000;
            //maas += 1000;
            //Console.WriteLine(maas);
            //Console.WriteLine("...>...=(sonuc) ilk kısıma bir sayı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{sayi1}>...=(sonuc) ikinci kısıma bir sayı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{sayi1}>{sayi2} ifadesine göre:");
            //string sonuc = sayi1 > sayi2 ? "Bu ifade doğrudur.Birinci sayı büyüktür." : "Bu ifade yanlıştır.İkinci sayı büyüktür veya eşittir";
            //Console.WriteLine(sonuc);
            #endregion






        }
    }
}
