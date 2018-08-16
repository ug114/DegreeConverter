using System;
using System.Collections.Generic;
using System.Text;

namespace DegreeConverter.Engine
{
    public class Celsius : IScale
    {
        public string Name
        {
            get
            {
                return "Celsius";
            }
            set { }
        }

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
