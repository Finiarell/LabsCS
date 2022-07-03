using System;

namespace Lab1.Fraction
{
    public class Country
    {
        private City Capital { get; set; }
        private int RegionNum { get; set; }
        private int Square { get; set; }


        public Country()
        {
            Capital = new City();
            RegionNum = 0;
            Square = 0;
        }

        public Country(string capital, int number, int square)
        {
            Capital = new City(capital,true);
            RegionNum = number;
            Square = square;
        }

        public string DisplayCapital() => "Столица: " + Capital.Name;

        public string DisplaySquare() => "Площадь: " + Square.ToString();

        public string DisplayRegionNum() => "Количество областей: " + RegionNum.ToString();

    }
}
