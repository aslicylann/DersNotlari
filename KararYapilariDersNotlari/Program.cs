using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariDersNotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("...>...=(sonuc) ilk kısıma bir sayı giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{sayi1}>...=(sonuc) ikinci kısıma bir sayı giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{sayi1}>{sayi2} ifadesine göre:");
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Birinci sayı büyüktür.");
            //}
            //else if (sayi2>sayi2)
            //{
            //    Console.WriteLine("İkinci sayı büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir.");
            //}
            //string a1 ="0", a2 = "0", a3 = "0",
            //    a4 = "0", a5 = "0";

            //Console.WriteLine("Dil Seçiniz./ Choose Language. (Tr - En)");
            //string dil = Console.ReadLine().ToUpper();
            //if (dil == "TR"||dil=="TÜRKÇE"|| dil=="TURKCE")
            //{
            //    a1 = "İşlem için bir sayı giriniz";
            //    a2 = "İşlem için ikinci bir sayı giriniz.";
            //    a3 = "İşlemi giriniz (*,/,+,-)";
            //    a4 = "Yapılan işlemin sonucu =";
            //    a5 = "Hatalı giriş yaptınız";
            //}

            //else if (dil == "EN"|| dil=="ENGLİSH"||dil=="ENG")
            //{
            //    a1 = "Enter first number for operation";
            //    a2 = "Enter second number for operation";
            //    a3 = "Enter the operation  (*,/,+,-)";
            //    a4 = "Operation's result";
            //    a5 = "You have logged in incorrectly";
            //}

            //else if (dil != "EN" || dil != "en" || dil != "English" || dil != "english" || dil != "Tr" || dil != "tr" || dil != "Turkish" || dil != "turkish")
            //{
            //    Console.WriteLine("Hatalı dil girişi yaptınız./You entered the wrong language.");
            //    Console.ReadKey();
            //}
            //else
            //{

            //}

            //Console.WriteLine($"{a1}");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a2}");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a3}");
            //char islem = char.Parse(Console.ReadLine());

            //if (islem == '+')
            //{
            //    Console.WriteLine($"{a4}= {sayi1 + sayi2}");
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine($"{a4}= {sayi1 - sayi2}");
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine($"{a4}={sayi1 / sayi2}");
            //}
            //else if (islem == '*')
            //{
            //    Console.WriteLine($"{a4}={sayi1 * sayi2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a5}");
            //}

            //    try
            //{
            //    Console.WriteLine("Hava Nasıl?");
            //    string hava = Console.ReadLine().ToUpper();

            //    if (hava == "GÜZEL" || hava == "İYİ" || hava == "GUZEL")
            //    {
            //        Console.WriteLine("Kaç derece?");
            //        sbyte derece = sbyte.Parse(Console.ReadLine());
            //        if (derece < 15)
            //        {
            //            Console.WriteLine("Hava soğuk, evde otur.");
            //        }
            //        else if (15 <= derece && derece < 35)
            //        {
            //            Console.WriteLine("Hava güzel dışarı çıkabilirsin.");
            //        }

            //        else
            //        {
            //            Console.WriteLine("Hava çok sıcak evde oturmalısın.");
            //        }




            //    }

            //    else if (hava == "KÖTÜ" || hava == "BERBAT" || hava == "İĞRENÇ")
            //    {
            //        Console.WriteLine("Evde otur.");

            //    }

            //    else

            //    {
            //        Console.WriteLine("Hava tanımlanamadı.");
            //    }
            //}

            //catch (FormatException ex1)
            //{
            //    Console.WriteLine("Lütfen sayı girerek tekrar deneyiniz.");
            //}
            //catch (OverflowException ex2)
            //{
            //    Console.WriteLine("Lütfen -255,+255 aralığında bir sayı girerek tekrar deneyiniz.");
            //}





            //// Exeption handling
            //try
            //{
            //    Console.WriteLine("Bir sayı girin");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sayı ile giriş yapınız.");
            //}

            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arasında bir değer giriniz.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir sorun oluştu.");
            //    Console.WriteLine($"Hata detayları:\nTarih ve saat:{DateTime.Now}" +
            //        $"\nHata mesajı:{ex.Message}\nStack Trace:{ex.StackTrace}");

        }
    }
}
