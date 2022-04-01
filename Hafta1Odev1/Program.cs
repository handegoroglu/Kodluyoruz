using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Vize Notunuzu Giriniz");
            int midtermExam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Final Notunuzu Giriniz.");
            int finalExam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geçme notu 50'dir,ortalamanız buna göre hesaplanmaktadır.");//github

            int note = Convert.ToInt32((midtermExam + finalExam) / 2);



            if (note >= 50 && note <= 100)
            {
                Console.WriteLine("Tebrikler,Dersi Geçtiniz!!!");
                Console.WriteLine("Not ortalamanız: " + note);
            }
            else if (note >= 0 && note <= 50)
            {
                Console.WriteLine("Dersten geçemediniz.");
                Console.WriteLine("Not ortalamanız: " + note);
            }
            else
            {
                Console.WriteLine("Hatalı bir değer girdiniz.!");
            }








            Console.ReadKey();

        }
    }
}
