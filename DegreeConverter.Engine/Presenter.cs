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
            //this.view.ToCelsius += new EventHandler<EventArgs>(SetCelsius);
            //this.view.ToFahrenheit += new EventHandler<EventArgs>(SetFahrenheit);
            //this.view.ToKelvin += new EventHandler<EventArgs>(SetKelvin);
            this.view.OK += new EventHandler<EventArgs>(OKed);
            view.SetResult(model.outputValue);
        }

        private void OKed(object sender, EventArgs e)
        {
            model.SetValue(view.InputDegree, view.ScalesList);
            view.SetResult(model.outputValue);
        }

        //private void SetCelsius(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        model.outputValue = model.ToCelsius(view.IsFromCelsius, view.IsFromKelvin, view.IsFromFahrenheit, view.InputDegree);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void SetKelvin(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        model.outputValue = model.ToKelvin(view.IsFromCelsius, view.IsFromKelvin, view.IsFromFahrenheit, view.InputDegree);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        //private void SetFahrenheit(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        model.outputValue = model.ToFahrenheit(view.IsFromCelsius, view.IsFromKelvin, view.IsFromFahrenheit, view.InputDegree);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
    }
}