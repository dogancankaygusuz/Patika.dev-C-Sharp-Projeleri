using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Ikililerin_Toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aralarinda bosluk birakacak sekilde sayilari girin: ");
            var sayi = Console.ReadLine();
            var x = sayi.Split(' ');

            String sonuc = String.Empty;

            for (int i = 0; i < x.Length; i += 2)
            {
                if (x[i] == x[i + 1])
                    sonuc += Math.Pow((Convert.ToInt32(x[i]) + Convert.ToInt32(x[i + 1])), 2) + " ";
                else
                    sonuc += Convert.ToInt32(x[i]) + Convert.ToInt32(x[i + 1]) + " ";
            }
            Console.WriteLine(sonuc);
            Console.Read();
        }
    }
}
