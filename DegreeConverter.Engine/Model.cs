namespace DegreeConverter.Engine
{
	public class Model
	{
		public double outputValue;
		
        public double ToCelsius(bool isInCelsius, bool isInKelvin, bool isInFahrenheit, double inputDegree)
        {
            if (isInFahrenheit)
            {
                return 5 * (inputDegree - 32) / 9;
            }
            else if (isInKelvin)
            {
                return inputDegree - 273.15;
            }
            else
            {
                return inputDegree;
            }
        }

        public double ToKelvin(bool isInCelsius, bool isInKelvin, bool isInFahrenheit, double inputDegree)
        {
            double degreeInCelsius = ToCelsius(isInCelsius, isInKelvin, isInFahrenheit, inputDegree);
            return degreeInCelsius + 273.15;
        }

        public double ToFahrenheit(bool isInCelsius, bool isInKelvin, bool isInFahrenheit, double inputDegree)
        {
            double degreeInCelsius = ToCelsius(isInCelsius, isInKelvin, isInFahrenheit, inputDegree);
            return degreeInCelsius * 9 / 5 + 32;
        }
    }
}