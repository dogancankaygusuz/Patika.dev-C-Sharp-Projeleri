using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime ve bu kelimeden çıkarılacak harfin sırasını girin (virgül ile ayırınız): ");
            string kelime = Console.ReadLine();

            string[] input = kelime.Split(',');
            int sayi = int.Parse(input[1]);
            Console.WriteLine(sayi);

            input[0].Remove(sayi - 1);
            Console.WriteLine(input[0].Remove(sayi - 1, 1));
            Console.Read();
        }
    }
}
