using System;
using System.Collections.Generic;
using System.Text;

namespace DegreeConverter.Engine
{
    public interface IScale
    {
        string Name { get; }
        
        double FromCelsius(double value);
        double ToCelsius(double value);
    }
}
