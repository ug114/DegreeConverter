namespace DegreeConverter.Engine
{
	public class Model
	{
		public double outputValue;
		
  //      public double ValueCelsiusCelsius
  //      {
  //          get { return outputValue; }
  //          set { outputValue = value; }
  //      }

		//public double ValueCelsiusFahrenheit
		//{
		//	get { return outputValue; }
		//	set 
		//	{ 
		//		outputValue = value * 9 / 5 + 32; 
		//	}
		//}

		//public double ValueCelsiusKelvin
		//{
		//	get { return outputValue; }
		//	set 
		//	{ 
		//		outputValue = value + 273.15;
		//	}
		//}

  //      public double ValueKelvinCelsius
  //      {
  //          get { return outputValue; }
  //          set
  //          {
  //              outputValue = value - 273.15;
  //          }
  //      }

  //      public double ValueKelvinFahrenheit
  //      {
  //          get { return outputValue; }
  //          set
  //          {
  //              outputValue = 9 * (value - 273.15) / 5 + 32;
  //          }
  //      }

  //      public double ValueKelvinKelvin
  //      {
  //          get { return outputValue; }
  //          set { outputValue = value;  }
  //      }

  //      public double ValueFahrenheitKelvin
  //      {
  //          get { return outputValue; }
  //          set
  //          {
  //              outputValue = 5 * (value - 32) / 9 + 273.15;
  //          }
  //      }

  //      public double ValueFahrenheitFahrenheit
  //      {
  //          get { return outputValue; }
  //          set { outputValue = value; }
  //      }

  //      public double ValueFahrenheitCelsius
  //      {
  //          get { return outputValue; }
  //          set
  //          {
  //              outputValue = 5 * (value - 32) / 9;
  //          }
  //      }

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