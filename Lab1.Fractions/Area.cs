namespace Lab1.Fraction
{
    class Area
    {
        public string Name { get; set; }

        public int CityNum { get; set; }

        public Area()
        {
            Name = "";
            CityNum = 0;
        }

        public Area(string name, int num)
        {
            Name = name;
            CityNum = num;
        }
    }
}
