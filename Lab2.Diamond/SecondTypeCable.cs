namespace Lab2.Cable
{
    public class SecondTypeCable : FirstTypeCable
    {
        public bool IsBraid { get; set; }

        public SecondTypeCable() => IsBraid = false;

        public SecondTypeCable(string type, int coresNum, double diameter, bool isBraid) : base(type, coresNum, diameter) => IsBraid = isBraid;

        public override double Quality()
        {
            if (IsBraid)
                return 2*base.Quality();
            else
                return 0.7*base.Quality();

        }

        public override string ToString() => base.ToString() + ", Наличие оплетки: " + IsBraid;
    }
}
