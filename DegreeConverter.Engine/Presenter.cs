using System;

namespace DegreeConverter.Engine
{
	public class Presenter
	{
		private readonly Model model = new Model();
		private readonly IView view;

        public Presenter(IView view)
        {
            this.view = view;
            this.view.OK += new EventHandler<EventArgs>(OkClicked);
            view.SetResult(model.outputValue);
        }

        private void OkClicked(object sender, EventArgs e)
        {
            try
            {
                model.SetValue(view.InputDegree, view.From, view.To);
            }
            catch (ArgumentException)
            {
                return;
            }
           
            view.SetResult(model.outputValue);
        }
    }
}