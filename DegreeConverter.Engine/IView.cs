using System;
using System.Collections.Generic;

namespace DegreeConverter.Engine
{
	public interface IView
	{
        string From { get; set; }
        string To { get; set; }
	    double InputDegree { get; }
        
        void SetResult(double degree);
        
        event EventHandler<EventArgs> OK;
    }
}