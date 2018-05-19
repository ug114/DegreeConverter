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
            try
            {
                model.valueCelsiusFahrenheit = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }

        private void SetCelsiusKelvin(object sender, EventArgs e)
        {
            try
            {
                model.valueCelsiusKelvin = view.InputDegree;
            }
            catch (Exception exception)
            {

            }

        }

        private void SetFahrenheitCelsius(object sender, EventArgs e)
		{
			try
            {
                model.valueFahrenheitCelsius = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }

        private void SetFahrenheitFahrenheit(object sender, EventArgs e)
        {
            try
            {
                model.valueFahrenheitFahrenheit = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }

        private void SetFahrenheitKelvin(object sender, EventArgs e)
        {
            try
            {
                model.valueFahrenheitKelvin = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }

        private void SetKelvinCelsius(object sender, EventArgs e)
        {
            try
            {
                model.valueKelvinCelsius = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }

        private void SetKelvinFahrenheit(object sender, EventArgs e)
        {
            try
            {
                model.valueKelvinFahrenheit = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }

        private void SetKelvinKelvin(object sender, EventArgs e)
        {
            try
            {
                model.valueKelvinKelvin = view.InputDegree;
            }
            catch (Exception exception)
            {

            }
        }
    }
}