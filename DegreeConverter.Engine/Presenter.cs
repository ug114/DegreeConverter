using System;

namespace DegreeConverter.Engine
{
	public class Presenter
	{
		private Model model = new Model();
		private IView view;

		public Presenter(IView view)
		{
			this.view = view;
            this.view.FromCelsiusToCelsius += new EventHandler<EventArgs>(SetCelsiusCelsius);
			this.view.FromCelsiusToFahrenheit += new EventHandler<EventArgs>(SetCelsiusFahrenheit);
            this.view.FromCelsiusToKelvin += new EventHandler<EventArgs>(SetCelsiusKelvin);
            this.view.FromFahrenheitToCelsius += new EventHandler<EventArgs>(SetFahrenheitCelsius);
            this.view.FromFahrenheitToFahrenheit += new EventHandler<EventArgs>(SetFahrenheitFahrenheit);
            this.view.FromFahrenheitToKelvin += new EventHandler<EventArgs>(SetFahrenheitKelvin);
            this.view.FromKelvinToCelsius += new EventHandler<EventArgs>(SetKelvinCelsius);
            this.view.FromKelvinToFahrenheit += new EventHandler<EventArgs>(SetKelvinFahrenheit);
            this.view.FromKelvinToKelvin += new EventHandler<EventArgs>(SetKelvinKelvin);
            this.view.OK += new EventHandler<EventArgs>(OKed);
            view.SetResult(model.outputValue);
		}

        private void OKed(object sender, EventArgs e)
        {
            view.SetResult(model.outputValue);
        }

		private void SetCelsiusCelsius(object sender, EventArgs e)
		{
            try
            {
                model.valueCelsiusCelsius = view.InputDegree;
            }
            catch(Exception exception)
            {
                
            }
	    }

        private void SetCelsiusFahrenheit(object sender, EventArgs e)
        {
            model.valueCelsiusFahrenheit = view.InputDegree;
        }

        private void SetCelsiusKelvin(object sender, EventArgs e)
        {
            model.valueCelsiusKelvin = view.InputDegree;
        }

        private void SetFahrenheitCelsius(object sender, EventArgs e)
		{
			model.valueFahrenheitCelsius = view.InputDegree;
        }

        private void SetFahrenheitFahrenheit(object sender, EventArgs e)
        {
            model.valueFahrenheitFahrenheit = view.InputDegree;
        }

        private void SetFahrenheitKelvin(object sender, EventArgs e)
        {
            model.valueFahrenheitKelvin = view.InputDegree;
        }

        private void SetKelvinCelsius(object sender, EventArgs e)
        {
            model.valueKelvinCelsius = view.InputDegree;
        }

        private void SetKelvinFahrenheit(object sender, EventArgs e)
        {
            model.valueKelvinFahrenheit = view.InputDegree;
        }

        private void SetKelvinKelvin(object sender, EventArgs e)
        {
            model.valueKelvinKelvin = view.InputDegree;
        }
    }
}