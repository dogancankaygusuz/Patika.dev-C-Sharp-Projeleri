using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessiz_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin girin: ");
            string kelime = Console.ReadLine();
            string[] strings = kelime.Split(' ');

            string unsuzler = "bcçdfgğhjklmnprsştvyz";

            foreach (var x in strings)
            {
                bool kontrol = false;

                for (int i = 0; i < x.Length - 1; i++)
                {
                    if (unsuzler.Contains(x[i]) && unsuzler.Contains(x[i + 1]))
                    {
                        kontrol = true;
                        break;
                    }
                }
                Console.WriteLine(kontrol + " ");
                Console.Read();
            }
        }
    }
}
