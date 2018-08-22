using System;
using System.Collections.Generic;
using System.Text;

namespace DegreeConverter.Engine
{
    public class Fahrenheit : IScale
    {
        public bool IsFrom { get; set; }
        public bool IsTo { get; set; }

        public string Name
        {
            get
            {
                return "Fahrenheit";
            }
            set { }
        }

        public double FromCelsius(double value)
        {
            return value *9 / 5 + 32;
        }

        public double ToCelsius(double value)
        {
            return 5 * (value - 32) / 9;
        }
    }
}
