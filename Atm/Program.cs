using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> hesaplar = new Dictionary<string, double>();
            hesaplar.Add("5555", 2000);
            hesaplar.Add("6666", 5000);
            hesaplar.Add("7777", 7000);

            string userId = Login(hesaplar);

            if (userId != null)
            {
                while (true)
                {
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:\n" +
                                      "1-Para Çekme:\n" +
                                      "2-Para Yatirma\n" +
                                      "3-Odeme Yapma\n" +
                                      "4-Cikis Yap:\n");
                    int secim = Convert.ToInt32(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            Withdraw(userId, hesaplar);
                            break;
                        case 2:
                            Deposit(userId, hesaplar);
                            break;
                        case 3:
                            Pay(userId, hesaplar);
                            break;
                        case 4:
                            Logout();
                            break;
                        default:
                            Console.WriteLine("Geçersiz işlem, lütfen tekrar deneyin.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı giriş, çıkış yapılıyor...");
            }
            Console.Read();
        }
        static string Login(Dictionary<string, double> accounts)
        {
            Console.Write("Kullanıcı adı: ");
            string kullanici_adi = Console.ReadLine();

            Console.Write("Parola: ");
            double sifre;
            if (!double.TryParse(Console.ReadLine(), out sifre))
            {
                Console.WriteLine("Parola yanlış formatta. Giriş başarısız.");
                return null;
            }

            double userId;
            if (accounts.TryGetValue(kullanici_adi, out userId) && sifre == userId)
            {
                Console.WriteLine("Giriş başarılı.");
                return kullanici_adi;
            }

            Console.WriteLine("Giriş başarısız. Kullanıcı adı veya parola yanlış.");
            return null;
        }
        static void Withdraw(string userId, Dictionary<string, double> accounts)
        {
            Console.Write("Lütfen çekmek istediğiniz tutarı girin: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > accounts[userId])
            {
                Console.WriteLine("Hesapta yeterli bakiye yok.");
            }
            else
            {
                accounts[userId] -= amount;
                Console.WriteLine("Yeni bakiye: {0}", accounts[userId]);
            }
        }
        static void Deposit(string userId, Dictionary<string, double> accounts)
        {
            Console.Write("Lütfen yatırmak istediğiniz tutarı girin: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            accounts[userId] += amount;
            Console.WriteLine("Yeni bakiye: {0}", accounts[userId]);
        }

        static void Pay(string userId, Dictionary<string, double> accounts)
        {
            Console.Write("Lütfen ödemek istediğiniz tutarı girin: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > accounts[userId])
            {
                Console.WriteLine("Hesapta yeterli bakiye yok.");
            }
            else
            {
                accounts[userId] -= amount;
                Console.WriteLine("Ödeme yapıldı. Yeni bakiye: {0}", accounts[userId]);
            }
        }
        static void Logout()
        {
            Console.WriteLine("Çıkış yapılıyor...");
            Environment.Exit(0);
        }
    }
}

