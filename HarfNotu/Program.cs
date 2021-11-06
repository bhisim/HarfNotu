using System;

//Bahar Merdamert Harf Notu Uygulaması

namespace HarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize sonucunuzu giriniz...");
            int vizenotu = int.Parse(Console.ReadLine());

            Console.WriteLine("Final sonucunuzu giriniz...");
            int finalnotu = int.Parse(Console.ReadLine());

            double nihaipuan = (vizenotu * 0.4) + (finalnotu * 0.6);
                       

            if(nihaipuan>=0 && nihaipuan<40)
            {
                Console.WriteLine("Harf notunuz F...");
            }
            else if(nihaipuan>=40 && nihaipuan<50)
            {
                Console.WriteLine("Harf notunuz DD...");
            }
            else if (nihaipuan >= 50 && nihaipuan < 60)
            {
                Console.WriteLine("Harf notunuz DC...");
            }
            else if (nihaipuan >= 60 && nihaipuan < 65)
            {
                Console.WriteLine("Harf notunuz CC...");
            }
            else if (nihaipuan >= 65 && nihaipuan < 70)
            {
                Console.WriteLine("Harf notunuz CB...");
            }
            else if (nihaipuan >= 70 && nihaipuan < 80)
            {
                Console.WriteLine("Harf notunuz BB...");
            }
            else if (nihaipuan >= 80 && nihaipuan < 90)
            {
                Console.WriteLine("Harf notunuz BA...");
            }
            else if (nihaipuan >= 90 && nihaipuan < 100)
            {
                Console.WriteLine("Harf notunuz AA...");
            }
            else
            {
                Console.WriteLine("Yanlış rakam tuşladınız");
            }
            Console.ReadKey();
        }
    }
}
