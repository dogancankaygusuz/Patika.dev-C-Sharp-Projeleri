using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Degistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kelimeyi girin: ");
            String kelime = Console.ReadLine();
            String[] Array = kelime.Split(' ');

            foreach (string x in Array)
            {
                for (int i = x.Length - 1; i >= 0; i--)
                {
                    Console.Write(x[i]);
                }
                Console.Write(" ");
            }
            Console.Read();
        }
    }
}
