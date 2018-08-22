using System;
using System.Windows.Forms;
using DegreeConverter.Engine;
using System.Collections.Generic;

namespace DegreeConverter.WinView
{
	public partial class FormView : Form, IView
	{
        public bool IsFromCelsius { get; set; }
        public bool IsFromKelvin { get; set; }
        public bool IsFromFahrenheit { get; set; }

        public List<IScale> ScalesList { get; set; }

        public FormView()
		{
			InitializeComponent();
		}

		public void SetResult(double Degree)
		{
			resultBox.Text = Degree.ToString("N2"); 
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
                        MessageBox.Show("¬ведите число.");
                        throw new ArgumentException();
                    }
                }           
                     
                return Convert.ToDouble(inputBox.Text);
            }
		}

        public event EventHandler<EventArgs> OK;
        public event EventHandler<EventArgs> ToCelsius;
        public event EventHandler<EventArgs> ToKelvin;
        public event EventHandler<EventArgs> ToFahrenheit;
        
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
            
            //if (radioButtonFromCelsius.Checked)
            //{
            //    IsFromCelsius = true;
            //    IsFromKelvin = false;
            //    IsFromFahrenheit = false;
            //}
            //else if (radioButtonFromFahrenheit.Checked)
            //{
            //    IsFromFahrenheit = true;
            //    IsFromCelsius = false;
            //    IsFromKelvin = false;
            //}
            //else
            //{
            //    IsFromKelvin = true;
            //    IsFromCelsius = false;
            //    IsFromFahrenheit = false;
            //}

            //if (radioButtonToCelsius.Checked)
            //{
            //    ToCelsius(this, EventArgs.Empty);
            //}
            //else if (radioButtonToKelvin.Checked)
            //{
            //    ToKelvin(this, EventArgs.Empty);
            //}
            //else
            //{
            //    ToFahrenheit(this, EventArgs.Empty);
            //}
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChooseFrom(this, EventArgs.Empty);
            OK(this, EventArgs.Empty);
        }
    }
}