using System;

namespace DegreeConverter.Engine
{
	public class Presenter
	{
		private readonly Model _model = new Model();
		private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;
            _view.OK += new EventHandler<EventArgs>(OkClicked);
            view.SetResult(_model.OutputValue);
        }

        private void OkClicked(object sender, EventArgs e)
        {
            try
            {
                _model.SetValue(_view.InputDegree, _view.From, _view.To);
            }
            catch (ArgumentException)
            {
                return;
            }
           
            _view.SetResult(_model.OutputValue);
        }
    }
}