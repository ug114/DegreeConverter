using System.Collections.Generic;
using DegreeConverter.Engine.Scales;
using System.Linq;
using System.Runtime.InteropServices;

namespace DegreeConverter.Engine
{
	public class Model
	{
		public double outputValue;
	    public readonly List<IScale> scalesList = new List<IScale>()
	    {
            new Celsius(),
            new Fahrenheit(),
            new Kelvin()
	    };

	    public void SetValue(double inputDegree, string fromScale, string toScale)
	    {
	        var valueInCelsius = scalesList.First(scale => scale.Name == fromScale).ToCelsius(inputDegree);
	        outputValue = scalesList.First(scale => scale.Name == toScale).FromCelsius(valueInCelsius);
	    }
	}
}