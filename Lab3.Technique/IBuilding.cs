namespace Lab3.Technique
{
    public interface IBuilding
    {
        int Price { get; set; }

        bool TryBuy(int money);

        string Buy(ref int money);
    }
}
