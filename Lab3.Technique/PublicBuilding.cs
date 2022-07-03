using System;

namespace Lab3.Technique
{
    public abstract class PublicBuilding : IBuilding
    {
        public int Price { get; set; }

        public string Location { get; set; }

        public string Director { get; set; }

        public int FoundationYear { get; set; }

        public bool TryBuy(int money) => money >= Price;

        public string Buy(ref int money)
        {
            if (TryBuy(money))
            {
                money -= Price;
                return "Вы купили здание.";
            }
            else 
            {
                return "Необходимо ещё " + (Price - money).ToString() + " тысяч для покупки этого здания.";
            }
        }

        public abstract string DisplayInformation();

        public string Rate()
        {
            Random random = new Random();
            return (random.Next(0, 200) < 95) ? "Это популярное здание." : "Это не очень популярное здание.";
        }
    }
}
