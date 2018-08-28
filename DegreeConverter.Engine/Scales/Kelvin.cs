namespace DegreeConverter.Engine.Scales
{
    public class Kelvin : IScale
    {
        public string Name => "Kelvin";
       
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
