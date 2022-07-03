namespace Lab1.Fraction
{
    class Region
    {
        public string Name { get; set; }

        public City Center { get; set; }

        public Region()
        {
            Name = "";
            Center = new City();
        }

        public Region(string name)
        {
            Name = name;
            Center = new City();
        }
    }
}
