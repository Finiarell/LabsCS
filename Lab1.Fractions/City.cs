namespace Lab1.Fraction
{
    class City
    {
        public string Name { get; set; }

        public bool IsCapital { get; set; }

        public City()
        {
            Name = "";
            IsCapital = true;
        }

        public City(string name,bool isCapital)
        {
            Name = name;
            IsCapital = isCapital;
        }
    }
}
