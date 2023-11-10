using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucgen_Cizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taban uzunlugu girin: ");
            Int32 taban = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= taban; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
