using System;
using System.Collections.Generic;
using System.Text;

namespace DegreeConverter.Engine
{
    interface IScale
    {
        string Name { get; set; }

        double FromCelsius(double value);
        double ToCelsius(double value);
    }
}
