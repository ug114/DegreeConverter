using System;
using System.Collections.Generic;

namespace DegreeConverter.Engine
{
	public interface IView
	{
	    double InputDegree { get; }
        List<IScale> ScalesList { get; set; }

        void SetResult(double degree);
        
        event EventHandler<EventArgs> OK;
    }
}