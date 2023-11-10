using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.Write("Fibonacci derinliği girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            int[] fibonacci = new int[sayi];
            fibonacci[0] = 0;

            if (sayi > 1)
            {
                fibonacci[1] = 1;
            }

            for (int i = 2; i < sayi; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            double toplam = 0;

            for (int i = 0; i < sayi; i++)
            {
                toplam += fibonacci[i];
            }

            double ortalama = toplam / sayi;
            Console.WriteLine("Fibonacci serisi ortalaması: " + ortalama);

            Console.ReadLine();
        }
    }
}
