using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Lütfen Adınızı giriniz: ");
            //string ad=Console.ReadLine();
            //Console.WriteLine("kaç kere yazılsın: ");
            //int say=int.Parse(Console.ReadLine());
            //for (int i = 0; i < say; i++)
            //{
            //    Console.WriteLine($"{i+1}.{ad}");
            //}
            //Console.ReadKey();
            //Console.WriteLine("Başlangıç sayısını giriniz:");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş sayısını giriniz:");
            //int bit = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek/Çift");
            //String durum = Console.ReadLine().ToLower();
            //int top = 0;

            //if (bas > bit)
            //{
            //    int temp = bas;
            //    bas = bit;
            //    bit = temp;

            //}
            //if (durum == "tek")
            //{

            //    for (int i = bas; i <= bit; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //            top += i;
            //        }


            //    }
            //}
            //else if (durum == "çift")
            //{

            //    for (int i = bas; i <= bit; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //            top += i;
            //        }


            //    }
            //}
            //Console.WriteLine($"Sayıların Toplamı: {top}");
            //Console.ReadKey();



            //üslü ifade işlemleri

            //int sonuc = 1;
            //sonuc = sonuc * 2;
            //sonuc = sonuc * 2;
            //sonuc= sonuc *  2;
            //Console.WriteLine(sonuc);


            //Console.WriteLine("taban değeri giriniz");
            //int taban=int.Parse(Console.ReadLine());
            //Console.WriteLine("üs değeri giriniz");
            //int us=int.Parse(Console.ReadLine());
            //int sonuc = 1;

            //for(int i = 0; i <us; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine(sonuc);



            //Console.WriteLine("bir sayı giriniz");
            //int sayi=int.Parse(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = 1;  i <= sayi; i++)
            //{
            //    sonuc = sonuc * i;       //sonuc*=i; gibi de yazılabilir
            //}
            // Console.WriteLine(sonuc);





            //ASAL SAYILARI BULMA:

            //Console.WriteLine("bir sayı giriniz");
            //int sayi=int.Parse(Console.ReadLine());
            //int sayac = 0;

            //for(int i = 1;  i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //    }


            //}
            //Console.WriteLine(sayac == 2 ? " Asal" : "Asal Değildir");

            //VEYA

















            //SONSUZ DÖNGÜ:

            //for(; ; )
            //{

            //    Console.WriteLine("Kullanıcı Adı Giriniz:");
            //    string user=Console.ReadLine();
            //    Console.WriteLine("Şifre Giriniz:");
            //    string pass=Console.ReadLine();

            //    if (user == "Aslı" && pass == "123") 
            //    {
            //        Console.WriteLine("Giriş Başarılı!");
            //        break;
            //    }

            //}


            //int max = int.MinValue;
            //int toplam = 0;
            //int sayac = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    sayac++;
            //    toplam += sayi;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    Console.WriteLine("devam etmek istiyor musunuz?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "h")
            //    {
            //        break;
            //    }
            //    else if (cvp == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("hatalı giriş yaptınız");
            //    }
            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max}\n sayıların toplamı:{toplam}\n girilen sayıların aritmetik ortalaması:");



            // "/t" boşluk


            //İÇ İÇE FOR DÖNGÜSÜ:

            //for (int i = 0;i<3;i++)
            //{
            //    for(int j = 0;j<4;j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}



            //for(int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //Console.WriteLine("Enter row count/Satır sayısı giriniz:");
            //int row=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column count/Sütun sayısı giriniz:");
            //int column=int.Parse(Console.ReadLine());


            //for (int i = 0; i < row; i++)
            //{
            //    for(int j = 0; j < column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");

            //    }
            //    Console.WriteLine();
            //}




            // abcd=4*dcba ise abcd=? örneği:

            //bool control = false;
            //for (int a = 1; a <= 9; a++)
            //{
            //    for (int b = 0; b <= 9; b++)
            //    {
            //        for (int c = 0; c <= 9; c++)
            //        {
            //            for (int d = 0; d <= 9; d++)
            //            {
            //                if (1000 * a + 100 * b + 10 * c + 1 * d == 4 * (1000 * d + 100 * c + 10 * b + 1 * a))
            //                {

            //                    Console.WriteLine($"{a}{b}{c}{d}");

            //                    break;
            //                    control = true;
            //                }

            //                if (control) { break; }
            //                {

            //                }
            //                if (control) { break; }
            //            }

            //            if (control) { break; }
            //        }
            //        if (control) { break; }
            //    }
            //}




            // dik üçgen yap hipotenüs 50 olana kadar yazdır örneği:


            //for (int i = 1; i< 50; i++)
            //{
            //    for(int j = 1; j< 50; j++)
            //    {
            //        for(int k = 1; k< 50; k++)
            //        {
            //            if (i * i + j * j == k * k)
            //            {
            //                Console.WriteLine($"{i}-{j}-{k}");
            //            }

            //        }
            //    }
            //}




            //GİRİLEN ARALIKLARDAKİ ASAL SAYILARI BULMA ÖRNEĞİ:

            //Console.WriteLine("Enter starting number:");
            //int star=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number:");
            //int end=int.Parse(Console.ReadLine());
            //for(int i=star; i< end; i++)
            //{
            //    int count = 0;
            //    for(int j=2; j<=(i/2); j++)
            //    {
            //        if(i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(count==0 ? $" {i}-Is prime": $"{i}-Is not prime");
            //} 



            // WHILE DÖNGÜSÜ:

            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine("Gazi");
            //    count++;

            //}


            //    Console.WriteLine("BİR SAYI GİRİNİZ:");
            //int sayi=int.Parse(Console.ReadLine());
            //while(true)
            //{
            //    Console.WriteLine(sayi);
            //}



            //DO WHILE DÖNGÜSÜ:











            //rastgele sayı atma


            //for (int i = 0;i<10;i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        Random rnd = new Random();
            //        int number=rnd.Next(33,127);
            //        Console.WriteLine((char)number);
            //    }
            //    Console.WriteLine();
            //}



            Random rnd = new Random();
            int Nnumber = rnd.Next(10);

            while (true)
            {
                Console.WriteLine("guess the number:");
                int number=int.Parse(Console.ReadLine());
                if (number == number)
                {
                    Console.WriteLine("you won!");
                    break;
                }
                else
                {
                    Console.WriteLine("try again!");

                }

            }



         














        }
    }
}
