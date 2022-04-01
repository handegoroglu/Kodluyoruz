using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] words = { "elma", "armut", "çikolata", "çilek" };
            string chosenWord;
            int deserve = 5;
            Random rnd = new Random();
            chosenWord = words[rnd.Next(0, words.Length - 1)];
            char[] takePlace = new char[chosenWord.Length];

            for (int i = 0; i < takePlace.Length; i++)
            {
                takePlace[i] = '-';
                Console.Write('-');
            }
            Console.WriteLine();

            while (true)
            {

                Console.WriteLine("Kalan Hak:{0}", deserve);
                Console.Write("Bir harf girin   :");
                char character = Convert.ToChar(Console.ReadLine());

                bool flag = false;
                int available = 0;
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == character)
                    {
                        takePlace[i] = character;
                        flag = true;
                    }
                    if (takePlace[i] == '-')
                    {
                        available++;
                    }
                    Console.Write(takePlace[i]);
                }
                Console.WriteLine();

                if (available == 0)
                {
                    Console.WriteLine("Tebrikler kazandınız!...");
                    break;
                }

                if (flag == false)
                {
                    deserve--;
                }

                if (deserve == 0)
                {
                    Console.WriteLine("Üzgünüm kaybettiniz!.");
                    break;
                }

                Console.WriteLine("******************");
            }

            Console.Write("Seçilen kelime:  <<{0}>>         ", (chosenWord));
            Console.ReadLine();

        }
    }
}
