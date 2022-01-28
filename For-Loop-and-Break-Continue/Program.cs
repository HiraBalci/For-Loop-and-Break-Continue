using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop_and_Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayac=int.Parse(Console.ReadLine());
            for(int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);// bütün tek sayıları ekrana yazdırır.
                }
               
            }
            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 1;i <= sayac; i++)
            {
                if(i % 2 == 1)
                {
                    tekToplam += i; //tekToplam=tekToplam+i

                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            //break,continue
            for(int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;//sadece 4'ü atladı.
                Console.WriteLine(i);
            }
        }
    }
}
