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
            this.view.OK += new EventHandler<EventArgs>(OKed);
            view.SetResult(model.outputValue);
        }

        private void OKed(object sender, EventArgs e)
        {
            model.SetValue(view.InputDegree, view.ScalesList);
            view.SetResult(model.outputValue);
        }
    }
}