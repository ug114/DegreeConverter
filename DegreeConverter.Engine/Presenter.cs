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
            //         this.view.FromCelsiusToCelsius += new EventHandler<EventArgs>(SetCelsiusCelsius);
            //this.view.FromCelsiusToFahrenheit += new EventHandler<EventArgs>(SetCelsiusFahrenheit);
            //         this.view.FromCelsiusToKelvin += new EventHandler<EventArgs>(SetCelsiusKelvin);
            //         this.view.FromFahrenheitToCelsius += new EventHandler<EventArgs>(SetFahrenheitCelsius);
            //         this.view.FromFahrenheitToFahrenheit += new EventHandler<EventArgs>(SetFahrenheitFahrenheit);
            //         this.view.FromFahrenheitToKelvin += new EventHandler<EventArgs>(SetFahrenheitKelvin);
            //         this.view.FromKelvinToCelsius += new EventHandler<EventArgs>(SetKelvinCelsius);
            //         this.view.FromKelvinToFahrenheit += new EventHandler<EventArgs>(SetKelvinFahrenheit);
            //         this.view.FromKelvinToKelvin += new EventHandler<EventArgs>(SetKelvinKelvin);

            this.view.ToCelsius += new EventHandler<EventArgs>(SetCelsius);
            this.view.ToFahrenheit += new EventHandler<EventArgs>(SetFahrenheit);
            this.view.ToKelvin += new EventHandler<EventArgs>(SetKelvin);
            this.view.OK += new EventHandler<EventArgs>(OKed);
            view.SetResult(model.outputValue);
		}

        private void OKed(object sender, EventArgs e)
        {
            view.SetResult(model.outputValue);
        }

		//private void SetCelsiusCelsius(object sender, EventArgs e)
		//{
  //          try
  //          {
  //              model.ValueCelsiusCelsius = view.InputDegree;
  //          }
  //          catch(Exception exception)
  //          {
                
  //          }
	 //   }

  //      private void SetCelsiusFahrenheit(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueCelsiusFahrenheit = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

  //      private void SetCelsiusKelvin(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueCelsiusKelvin = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }

  //      }

  //      private void SetFahrenheitCelsius(object sender, EventArgs e)
		//{
		//	try
  //          {
  //              model.ValueFahrenheitCelsius = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

  //      private void SetFahrenheitFahrenheit(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueFahrenheitFahrenheit = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

  //      private void SetFahrenheitKelvin(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueFahrenheitKelvin = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

  //      private void SetKelvinCelsius(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueKelvinCelsius = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

  //      private void SetKelvinFahrenheit(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueKelvinFahrenheit = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

  //      private void SetKelvinKelvin(object sender, EventArgs e)
  //      {
  //          try
  //          {
  //              model.ValueKelvinKelvin = view.InputDegree;
  //          }
  //          catch (Exception exception)
  //          {

  //          }
  //      }

        private void SetCelsius(object sender, EventArgs e)
        {
            model.outputValue = model.ToCelsius(view.IsFromCelsius, view.IsFromKelvin, view.IsFromFahrenheit, view.InputDegree);
        }

        private void SetKelvin(object sender, EventArgs e)
        {
            model.outputValue = model.ToKelvin(view.IsFromCelsius, view.IsFromKelvin, view.IsFromFahrenheit, view.InputDegree);
        }

        private void SetFahrenheit(object sender, EventArgs e)
        {
            model.outputValue = model.ToFahrenheit(view.IsFromCelsius, view.IsFromKelvin, view.IsFromFahrenheit, view.InputDegree);
        }
    }
}