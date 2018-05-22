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

        //event EventHandler<EventArgs> FromFahrenheitToCelsius;

        //event EventHandler<EventArgs> FromCelsiusToCelsius;

        //event EventHandler<EventArgs> FromKelvinToCelsius;

        //event EventHandler<EventArgs> FromFahrenheitToFahrenheit;

        //event EventHandler<EventArgs> FromCelsiusToKelvin;

        //      event EventHandler<EventArgs> FromCelsiusToFahrenheit;

        //      event EventHandler<EventArgs> FromKelvinToKelvin;

        //      event EventHandler<EventArgs> FromKelvinToFahrenheit;

        //      event EventHandler<EventArgs> FromFahrenheitToKelvin;

        event EventHandler<EventArgs> ToCelsius;
        event EventHandler<EventArgs> ToKelvin;
        event EventHandler<EventArgs> ToFahrenheit;
        event EventHandler<EventArgs> OK;
    }
}