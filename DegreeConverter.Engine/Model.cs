using System.Collections.Generic;

namespace DegreeConverter.Engine
{
	public class Model
	{
		public double outputValue;

        public void SetValue(double inputDegree, List<IScale> scalesList)
        {
            double valueInCelsius = inputDegree;
            
            foreach (IScale scale in scalesList)
            {
                if (scale.IsFrom)
                {
                    valueInCelsius = scale.ToCelsius(inputDegree);
                }
            }

            foreach (IScale scale in scalesList)
            {
                if (scale.IsTo)
                {
                    outputValue = scale.FromCelsius(valueInCelsius);
                }
            }
        }
    }
}