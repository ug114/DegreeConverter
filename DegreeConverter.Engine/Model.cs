namespace DegreeConverter.Engine
{
	public class Model
	{
		public double outputValue;
		
        public double valueCelsiusCelsius
        {
            get { return outputValue; }
            set { outputValue = value; }
        }

		public double valueCelsiusFahrenheit
		{
			get { return outputValue; }
			set 
			{ 
				outputValue = value * 9 / 5 + 32; 
			}
		}

		public double valueCelsiusKelvin
		{
			get { return outputValue; }
			set 
			{ 
				outputValue = value + 273.15;
			}
		}

        public double valueKelvinCelsius
        {
            get { return outputValue; }
            set
            {
                outputValue = value - 273.15;
            }
        }

        public double valueKelvinFahrenheit
        {
            get { return outputValue; }
            set
            {
                outputValue = 9 * (value - 273.15) / 5 + 32;
            }
        }

        public double valueKelvinKelvin
        {
            get { return outputValue; }
            set { outputValue = value;  }
        }

        public double valueFahrenheitKelvin
        {
            get { return outputValue; }
            set
            {
                outputValue = 5 * (value - 32) / 9 + 273.15;
            }
        }

        public double valueFahrenheitFahrenheit
        {
            get { return outputValue; }
            set { outputValue = value; }
        }

        public double valueFahrenheitCelsius
        {
            get { return outputValue; }
            set
            {
                outputValue = 5 * (value - 32) / 9;
            }
        }
    }
}