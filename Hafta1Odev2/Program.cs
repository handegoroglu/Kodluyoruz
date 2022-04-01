using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kalan görmek için değer atayalım
            int control = 0;
            //kullanıcıdan sayı girdisi isteyelim
            Console.Write("Sayı Girin : ");
            //string tipini int'e çevirelim
            int number = Convert.ToInt32(Console.ReadLine());
            //en küçük asal sayı 2 olduğundan i değişkenini 2 den başlatalım
            //mod alma kullanalım
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    control++;
            }
            //çıkan sonuca göre kullanıcıya yazdıralım
            if (control != 0)
                Console.WriteLine("Girdiğiniz sayı asal değildir.");
            else
                Console.WriteLine("Girdiğiniz sayı asaldır.");

            //1den 10bine kadar olan asal sayılar
            Console.WriteLine("1'den 10000'e kadar olan asal sayıları görmek için enter tuşuna basınız:");

            number = 0;
            for (int i = 2; i < 10000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        number++;
                    }

                }
                if (number == 0)
                {
                    Console.WriteLine(i);
                }
                number = 0;
                Console.ReadKey();
            }

        }
    }
}
