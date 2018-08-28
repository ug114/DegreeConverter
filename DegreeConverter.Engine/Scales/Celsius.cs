namespace DegreeConverter.Engine.Scales
{
    public class Celsius : IScale
    {
        public string Name => "Celsius";
        
        public double FromCelsius(double value)
        {
            return value;
        }

        public double ToCelsius(double value)
        {
            return value;
        }
    }
}