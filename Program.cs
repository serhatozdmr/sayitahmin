using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rasgele = new Random();
            hafiza = rasgele.Next(1, 100);
            while (tahmin != hafiza) 
            {
                sayac++;
                Console.WriteLine("sayı girin lütfen:");
                tahmin = Convert.ToInt16(Console.ReadLine());

                if(tahmin > hafiza)
                {
                    Console.WriteLine("Tahminimiz daha küçük bir sayı");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Tahminimiz daha büyük bir sayı");
                }
            }
            Console.WriteLine("Tebrik ederiz sayıyı bildiniz");
            Console.WriteLine("{0}.denemede buldunuz iyi skor", sayac); 

        }
    }
}
