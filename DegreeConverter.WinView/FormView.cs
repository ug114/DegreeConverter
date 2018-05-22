using System;
using System.Windows.Forms;
using DegreeConverter.Engine;

namespace DegreeConverter.WinView
{
	public partial class FormView : Form, IView
	{
        public bool IsFromCelsius { get; set; }
        public bool IsFromKelvin { get; set; }
        public bool IsFromFahrenheit { get; set; }

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
                    if (char.IsLetter(text[i]))
                    {
                        throw new ArgumentException();
                    }
                }           
                     
                return Convert.ToDouble(inputBox.Text);
            }
		}

        public event EventHandler<EventArgs> OK;
        //public event EventHandler<EventArgs> FromFahrenheitToCelsius;
        //public event EventHandler<EventArgs> FromCelsiusToCelsius;
        //public event EventHandler<EventArgs> FromKelvinToCelsius;
        //public event EventHandler<EventArgs> FromFahrenheitToFahrenheit;
        //public event EventHandler<EventArgs> FromCelsiusToKelvin;
        //public event EventHandler<EventArgs> FromCelsiusToFahrenheit;
        //public event EventHandler<EventArgs> FromKelvinToKelvin;
        //public event EventHandler<EventArgs> FromKelvinToFahrenheit;
        //public event EventHandler<EventArgs> FromFahrenheitToKelvin;

        public event EventHandler<EventArgs> ToCelsius;
        public event EventHandler<EventArgs> ToKelvin;
        public event EventHandler<EventArgs> ToFahrenheit;
        
        private void ChooseFrom(object sender, EventArgs e)
        {
            //if (radioButtonFromCelsius.Checked && radioButtonToCelsius.Checked)
            //{
            //    FromCelsiusToCelsius(this, EventArgs.Empty);
            //}
            //else if (radioButtonFromFahrenheit.Checked && radioButtonToCelsius.Checked)
            //{
            //    FromFahrenheitToCelsius(this, EventArgs.Empty);
            //}
            //else if (radioButtonFromKelvin.Checked && radioButtonToCelsius.Checked)
            //{
            //    FromKelvinToCelsius(this, EventArgs.Empty);
            //}
            //else if (radioButtonFromCelsius.Checked && radioButtonToFahrenheit.Checked)
            //{
            //    FromCelsiusToFahrenheit(this, EventArgs.Empty);
            //}
            //else if(radioButtonFromCelsius.Checked && radioButtonToKelvin.Checked)
            //{
            //    FromCelsiusToKelvin(this, EventArgs.Empty);
            //}
            //else if (radioButtonFromFahrenheit.Checked && radioButtonToFahrenheit.Checked)
            //{
            //    FromFahrenheitToFahrenheit(this, EventArgs.Empty);
            //}
            //else if(radioButtonFromFahrenheit.Checked && radioButtonToKelvin.Checked)
            //{
            //    FromFahrenheitToKelvin(this, EventArgs.Empty);
            //}
            //else if(radioButtonFromKelvin.Checked && radioButtonToFahrenheit.Checked)
            //{
            //    FromKelvinToFahrenheit(this, EventArgs.Empty);
            //}
            //else if (radioButtonFromKelvin.Checked && radioButtonToKelvin.Checked)
            //{
            //    FromKelvinToKelvin(this, EventArgs.Empty);
            //}

            if (radioButtonFromCelsius.Checked)
            {
                IsFromCelsius = true;
                IsFromKelvin = false;
                IsFromFahrenheit = false;
            }
            else if (radioButtonFromFahrenheit.Checked)
            {
                IsFromFahrenheit = true;
                IsFromCelsius = false;
                IsFromKelvin = false;
            }
            else if (radioButtonFromKelvin.Checked)
            {
                IsFromKelvin = true;
                IsFromCelsius = false;
                IsFromFahrenheit = false;
            }

            if (radioButtonToCelsius.Checked)
            {
                ToCelsius(this, EventArgs.Empty);
            }
            else if (radioButtonToKelvin.Checked)
            {
                ToKelvin(this, EventArgs.Empty);
            }
            else if (radioButtonToFahrenheit.Checked)
            {
                ToFahrenheit(this, EventArgs.Empty);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ChooseFrom(this, EventArgs.Empty);
            OK(this, EventArgs.Empty);
        }
    }
}