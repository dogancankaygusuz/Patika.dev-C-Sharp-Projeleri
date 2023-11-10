using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islem seciniz");
            Console.WriteLine("1-Daire\n2-Dikdortgen\n3-Kare\n4-Yamuk");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Daireyi sectiniz.\n1-Alan Hesaplama\n2-Cevre Hesaplama");
                    int a = Convert.ToInt32(Console.ReadLine());
                    double pi = 3.14d;
                    if (a == 1 || a == 2)
                    {
                        Console.Write("Yaricapi girin: ");
                        int r = Convert.ToInt32(Console.ReadLine());

                        if (a == 1)
                            Console.WriteLine("Dairenin Alanı: " + pi * r * r);
                        else if (a == 2)
                            Console.WriteLine("Dairenin Cevresi: " + 2 * pi * r);
                    }
                    else
                        Console.WriteLine("Hatali işlem sectiniz");
                    break;

                case 2:
                    Console.WriteLine("Dikdörtgeni sectiniz.\n1-Alan Hesaplama\n2-Cevre Hesaplama");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (b == 1 || b == 2)
                    {
                        Console.Write("Kisa kenari girin: ");
                        int kisa = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Uzun kenari girin: ");
                        int uzun = Convert.ToInt32(Console.ReadLine());

                        if (b == 1)
                            Console.WriteLine("Dikdörtgenin Alanı: " + kisa * uzun);
                        else if (b == 2)
                            Console.WriteLine("Dikdörtgenin Cevresi: " + 2 * (kisa + uzun));
                    }
                    else
                        Console.WriteLine("Hatali işlem sectiniz");
                    break;
                case 3:
                    Console.WriteLine("Kareyi sectiniz.\n1-Alan Hesaplama\n2-Cevre Hesaplama");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (c == 1 || c == 2)
                    {
                        Console.Write("Kenar uzunlugu girin: ");
                        int kenar = Convert.ToInt32(Console.ReadLine());

                        if (c == 1)
                            Console.WriteLine("Karenin Alanı: " + kenar * kenar);
                        else if (c == 2)
                            Console.WriteLine("Karenin Cevresi: " + 4 * kenar);
                    }
                    else
                        Console.WriteLine("Hatali işlem sectiniz");
                    break;
                case 4:
                    Console.WriteLine("Yamugu sectiniz.\n1-Alan Hesaplama");
                    int d = Convert.ToInt32(Console.ReadLine());
                    if (d == 1)
                    {
                        Console.Write("Ust tabani girin: ");
                        int ust = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Alt tabani girin: ");
                        int alt = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Yuksekligi girin: ");
                        int h = Convert.ToInt32(Console.ReadLine());

                        if (d == 1)
                            Console.WriteLine("Yamugun Alanı: " + (alt + ust) * h / 2);
                    }
                    else
                        Console.WriteLine("Hatali işlem sectiniz");
                    break;
                default:
                    Console.WriteLine("Hatali islem sectiniz...");
                    break;
            }
            Console.Read();
        }
    }
}
