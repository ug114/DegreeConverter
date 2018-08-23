using System;
using System.Collections.Generic;
using System.Text;

namespace DegreeConverter.Engine
{
    public interface IScale
    {
        string Name { get; }
        bool IsFrom { get; set; }
        bool IsTo { get; set; }

        double FromCelsius(double value);
        double ToCelsius(double value);
    }
}
