using System.Collections.Generic;
using DegreeConverter.Engine.Scales;
using System.Linq;
using System.Runtime.InteropServices;

namespace DegreeConverter.Engine
{
	public class Model
	{
		public double OutputValue;
	    private readonly List<IScale> _scalesList = new List<IScale>()
	    {
            new Celsius(),
            new Fahrenheit(),
            new Kelvin()
	    };

	    public void SetValue(double inputDegree, string fromScale, string toScale)
	    {
	        var valueInCelsius = _scalesList.First(scale => scale.Name == fromScale).ToCelsius(inputDegree);
	        OutputValue = _scalesList.First(scale => scale.Name == toScale).FromCelsius(valueInCelsius);
	    }
	}
}