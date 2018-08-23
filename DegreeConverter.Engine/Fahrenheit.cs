﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DegreeConverter.Engine
{
    public class Fahrenheit : IScale
    {
        public string Name => "Fahrenheit";
       
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
