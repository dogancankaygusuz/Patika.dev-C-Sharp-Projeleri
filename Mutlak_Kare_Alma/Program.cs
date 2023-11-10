using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutlak_Kare_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aralarında birer bosluk bırakarak sayilari giriniz: ");
            string sayi = Console.ReadLine();
            string[] arr_sayi = sayi.Split(' ');
            int[] arr_sayi1 = new int[arr_sayi.Length];

            int x = 0;
            double y = 0;

            for (int i = 0; i < arr_sayi.Length; i++)
            {
                int current = int.Parse(arr_sayi[i]);
                arr_sayi1[i] = current;

                if (arr_sayi1[i] < 68)
                    x += 67 - arr_sayi1[i];

                else if (arr_sayi1[i] > 68)
                    y += Math.Pow(Convert.ToDouble(arr_sayi1[i] - 67), 2);
            }
            Console.WriteLine("Farklarin toplami:" + x);
            Console.WriteLine("Farklarin mutlak karelerinin toplami:" + y);

            Console.ReadLine();
        }
    }
}
