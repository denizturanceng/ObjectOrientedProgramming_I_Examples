using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCatSimulator
{
    public class VirtualCat
    {
        public string Name { get; set; }
        public int Hunger { get; private set; }          // Açlık
        public int Energy { get; private set; }          // Enerji
        public int Playfulness { get; private set; }     // Oynama isteği

        public VirtualCat(string name)
        {
            Name = name;
            Hunger = 80;
            Energy = 80;
            Playfulness = 80;
        }

        // Yemek yediğinde sadece açlığı artsın
        public void Feed()
        {
            Hunger = Math.Min(100, Hunger + 20);
        }

        // Oyun oynadığında sadece oynama isteği artsın
        public void Play()
        {
            Playfulness = Math.Min(100, Playfulness + 20);
        }

        // Uyuduğunda sadece enerji artsın
        public void Sleep()
        {
            Energy = Math.Min(100, Energy + 25);
        }

        // Zaman geçtikçe tüm statlar azalsın
        public void Tick()
        {
            Hunger = Math.Max(0, Hunger - 10);         // Açlık orta hızda düşer
            Energy = Math.Max(0, Energy - 5);         // Enerji yavaş düşer
            Playfulness = Math.Max(0, Playfulness - 20); // Oynama isteği hızlı düşer
        }
    }
}