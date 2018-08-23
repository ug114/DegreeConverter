using System;
using System.Windows.Forms;
using DegreeConverter.Engine;
using System.Collections.Generic;

namespace DegreeConverter.WinView
{
	public partial class FormView : Form, IView
	{
        public string From { get; set; }
        public string To { get; set; }
        
        public FormView()
		{
			InitializeComponent();
		}

		public void SetResult(double degree)
		{
			resultBox.Text = degree.ToString("N2"); 
		}

		public double InputDegree
		{
			get
            {
                string text = inputBox.Text.ToString();
                double value;

                if (!Double.TryParse(text, out value))
                {
                    MessageBox.Show("Enter the number.");
                    throw new ArgumentException();
                }

                return value;
            }
		}

        public event EventHandler<EventArgs> OK;
                
        private void ChooseFrom(object sender, EventArgs e)
        {
            var radioButtonsFrom = groupBox1.Controls;

            foreach (RadioButton radioButton in radioButtonsFrom)
            {
                if (radioButton.Checked)
                {
                    From = radioButton.Text;
                }
            }

            var radioButtonsTo = groupBox2.Controls;

            foreach (RadioButton radioButton in radioButtonsTo)
            {
                if (radioButton.Checked)
                {
                    To = radioButton.Text;
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChooseFrom(this, EventArgs.Empty);
            OK(this, EventArgs.Empty);
        }
    }
}