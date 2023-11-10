using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Tersten_Yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin girin: ");
            string kelime = Console.ReadLine();
            string ters = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
                ters += kelime[i];

            Console.WriteLine("Ters hali: " + ters);
            Console.Read();
        }
    }
}
