using System;

namespace Lab3.Technique
{
    public class Theatre : PublicBuilding
    {
        public int LastRepair { get; set; }

        public string Performance { get; set; }

        public override string ToString() => "Цена: " + Price.ToString() + ", Адрес: " + Location + ", Директор: " + Director + ", Год основания: " + FoundationYear.ToString() +
            ", Год последней реконструкции: " + LastRepair.ToString() + ", Ближайшее представление: " + Performance;

        public override string DisplayInformation()
        {
            return "Полная информация о здании — " + ToString();
        }

        public string TryWatchPerformance()
        {
            Random random = new Random();
            return (random.Next(0, 200) < 100) ? "Вам понравилось представление." : "Вам не понравилось представление.";
        }

        public string Replace() => "Вы пересели на другое место.";
    }
}
