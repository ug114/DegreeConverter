﻿namespace DegreeConverter.Engine
{
    public class Kelvin : IScale
    {
        public string Name
        {
            get
            {
                return "Kelvin";
            }
            set { }
        }

        public double FromCelsius(double value)
        {
            return value + 273.15;
        }

        public double ToCelsius(double value)
        {
            return value - 273.15;
        }
    }
}
