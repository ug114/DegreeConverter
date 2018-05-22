using System;

namespace DegreeConverter.Engine
{
	public interface IView
	{
        bool IsFromCelsius { get; set; }
        bool IsFromKelvin { get; set; }
        bool IsFromFahrenheit { get; set; }

        void SetResult(double Degree);

        double InputDegree { get; }

        event EventHandler<EventArgs> ToCelsius;
        event EventHandler<EventArgs> ToKelvin;
        event EventHandler<EventArgs> ToFahrenheit;
        event EventHandler<EventArgs> OK;
    }
}