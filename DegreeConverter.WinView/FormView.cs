using System;
using System.Windows.Forms;
using DegreeConverter.Engine;
using System.Collections.Generic;

namespace DegreeConverter.WinView
{
	public partial class FormView : Form, IView
	{
        public List<IScale> ScalesList { get; set; }

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
                
                for (int i = 0; i < text.Length; i++)
                {
                    if (!char.IsDigit(text[i]) && text[i] != ',')
                    {
                        MessageBox.Show("Enter the number.");
                        throw new ArgumentException();
                    }
                }           
                     
                return Convert.ToDouble(inputBox.Text);
            }
		}

        public event EventHandler<EventArgs> OK;
                
        private void ChooseFrom(object sender, EventArgs e)
        {
            Celsius celsius = new Celsius();
            Fahrenheit fahrenheit = new Fahrenheit();
            Kelvin kelvin = new Kelvin();

            ScalesList = new List<IScale>();
            ScalesList.Add(celsius);
            ScalesList.Add(fahrenheit);
            ScalesList.Add(kelvin);

            var radioButtonsFrom = groupBox1.Controls;

            foreach (RadioButton radioButton in radioButtonsFrom)
            {
                if (radioButton.Checked)
                {
                    foreach (IScale scale in ScalesList)
                    {
                        if (radioButton.Text == scale.Name)
                        {
                            scale.IsFrom = true;
                        }
                        else
                        {
                            scale.IsFrom = false;
                        }
                    }
                }
            }

            var radioButtonsTo = groupBox2.Controls;

            foreach (RadioButton radioButton in radioButtonsTo)
            {
                if (radioButton.Checked)
                {
                    foreach (IScale scale in ScalesList)
                    {
                        if (radioButton.Text == scale.Name)
                        {
                            scale.IsTo = true;
                        }
                        else
                        {
                            scale.IsTo = false;
                        }
                    }
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