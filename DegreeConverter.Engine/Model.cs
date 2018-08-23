using System.Collections.Generic;

namespace DegreeConverter.Engine
{
	public class Model
	{
		public double outputValue;
	    public List<IScale> scalesList;

	    public void SetValue(double inputDegree, string from, string to)
	    {
	        double valueInCelsius = inputDegree;

	        Celsius celsius = new Celsius();
	        Fahrenheit fahrenheit = new Fahrenheit();
	        Kelvin kelvin = new Kelvin();

	        scalesList = new List<IScale>
	        {
	            celsius,
	            fahrenheit,
	            kelvin
	        };

	        foreach (IScale scale in scalesList)
	        {
	            if (scale.Name == from)
	            {
	                valueInCelsius = scale.ToCelsius(inputDegree);
	            }
	        }

	        foreach (IScale scale in scalesList)
	        {
	            if (scale.Name == to)
	            {
	                outputValue = scale.FromCelsius(valueInCelsius);
	            }
	        }
	    }
	}
}