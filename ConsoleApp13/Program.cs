using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adınız nedir? :");
            string ad = Console.ReadLine();
            Console.WriteLine("hoş geldiniz " + ad);
            Random rnd = new Random();
            int sayi = rnd.Next(1,11);

            Console.WriteLine("1 ile 10 arasında bir sayı tuttum tahmin edermisiniz :");
            int thm = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("yeni bir tahminde bulunun: ");
                thm= Convert.ToInt32(Console.ReadLine());

                if (thm != sayi)
                {
                    Console.WriteLine("yanlış tahmin  ");
                }
                else
                {
                    Console.WriteLine("tebrikler doğru tahmin! ");
                }

            }
            while (thm != sayi);

            
  
            Console.ReadKey();
        }
    }
}
