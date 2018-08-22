namespace DegreeConverter.Engine
{
    public class Kelvin : IScale
    {
        public bool IsFrom { get; set; }
        public bool IsTo { get; set; }

        public string Name
        {
            get
            {
                return "Kelvin";
            }
            set { }
        }

        public double FromCelsius(double value)
        {
            return value + 273.15;
        }

        public double ToCelsius(double value)
        {
            return value - 273.15;
        }
    }
}
