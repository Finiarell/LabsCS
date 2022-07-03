namespace Lab2.Cable
{
    public class FirstTypeCable
    {
        public string Type { get; set; }

        public int CoresNum { get; set; }

        public double Diameter { get; set; }

        public FirstTypeCable()
        {
            Type = "";
            CoresNum = 0;
            Diameter = 0;
        }

        public FirstTypeCable(string type, int coresNum, double diameter)
        {
            Type = type;
            CoresNum = coresNum;
            Diameter = diameter;
        }

        public virtual double Quality() => Diameter/CoresNum;

        public override string ToString() => "Тип: " + Type + ", Количество жил: " + CoresNum.ToString() + ", Диаметр: " + Diameter.ToString();
    }
}
