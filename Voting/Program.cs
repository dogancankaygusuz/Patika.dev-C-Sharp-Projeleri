using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kategori> kategori = new List<Kategori>();
            kategori.Add(new Kategori("Film Kategorileri"));
            kategori.Add(new Kategori("Tech Stack Kategorileri"));
            kategori.Add(new Kategori("Spor Kategorileri"));

            Console.Write("Kullanıcı adiniz: ");
            string username = Console.ReadLine();

            Kullanici user = Kullanici.GetUserByUsername(username);
            if (user == null)
            {
                user = new Kullanici(username);
                Kullanici.Users.Add(user);
                Console.WriteLine("Yeni kullanıcı kaydedildi.");
            }

            Console.WriteLine("Aşağıdaki kategorilerden birini seçin:");

            for (int i = 0; i < kategori.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {kategori[i].Name}");
            }

            Console.Write("Seçiminiz (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            kategori[choice - 1].Votes++;
            Console.WriteLine($"Teşekkürler, {username}. Oyunuz kaydedildi.");

            int totalVotes = 0;
            foreach (Kategori category in kategori)
            {
                totalVotes += category.Votes;
            }
            Console.WriteLine("KATEGORI\t\t\t\t OY SAYISI\t\t OY ORANI");
            foreach (Kategori category in kategori)
            {
                double votePercentage = (double)category.Votes / totalVotes * 100;
                Console.WriteLine($"{category.Name,-40} {category.Votes,-20} {votePercentage,5:N2}%");
            }
            Console.WriteLine("Program sonlandı. Çıkmak için ENTER tuşuna basın.");
            Console.ReadLine();
        }
    }
    class Kategori
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Kategori(string name)
        {
            this.Name = name;
            Votes = 0;
        }
    }
    class Kullanici
    {
        public static List<Kullanici> Users = new List<Kullanici>();

        public string Username { get; set; }

        public Kullanici(string username)
        {
            Username = username;
        }
        public static Kullanici GetUserByUsername(string username)
        {
            foreach (Kullanici user in Users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
