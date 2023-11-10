using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Cizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yaricapini girin: ");
            double r = Convert.ToDouble(Console.ReadLine());

            for (int a = -(int)r; a <= (int)r; a++)
            {
                for (int b = -(int)r; b <= (int)r; b++)
                {
                    if (b * b + a * a <= r * r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
