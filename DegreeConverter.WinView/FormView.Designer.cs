namespace DegreeConverter.WinView
{
	partial class FormView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.resultBox = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFromKelvin = new System.Windows.Forms.RadioButton();
            this.radioButtonFromFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonFromCelsius = new System.Windows.Forms.RadioButton();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonToKelvin = new System.Windows.Forms.RadioButton();
            this.radioButtonToFahrenheit = new System.Windows.Forms.RadioButton();
            this.radioButtonToCelsius = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(128, 290);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(98, 20);
            this.resultBox.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(146, 265);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Результат:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(127, 37);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 4;
            // 
            // labelNewValue
            // 
            this.labelNewValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNewValue.Location = new System.Drawing.Point(128, 9);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(98, 25);
            this.labelNewValue.TabIndex = 5;
            this.labelNewValue.Text = "Новое значение:";
            this.labelNewValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButtonFromKelvin);
            this.groupBox1.Controls.Add(this.radioButtonFromFahrenheit);
            this.groupBox1.Controls.Add(this.radioButtonFromCelsius);
            this.groupBox1.Location = new System.Drawing.Point(36, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFromKelvin
            // 
            this.radioButtonFromKelvin.AutoSize = true;
            this.radioButtonFromKelvin.Location = new System.Drawing.Point(188, 20);
            this.radioButtonFromKelvin.Name = "radioButtonFromKelvin";
            this.radioButtonFromKelvin.Size = new System.Drawing.Size(73, 17);
            this.radioButtonFromKelvin.TabIndex = 2;
            this.radioButtonFromKelvin.TabStop = true;
            this.radioButtonFromKelvin.Text = "Кельвину";
            this.radioButtonFromKelvin.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromFahrenheit
            // 
            this.radioButtonFromFahrenheit.AutoSize = true;
            this.radioButtonFromFahrenheit.Location = new System.Drawing.Point(97, 20);
            this.radioButtonFromFahrenheit.Name = "radioButtonFromFahrenheit";
            this.radioButtonFromFahrenheit.Size = new System.Drawing.Size(87, 17);
            this.radioButtonFromFahrenheit.TabIndex = 1;
            this.radioButtonFromFahrenheit.TabStop = true;
            this.radioButtonFromFahrenheit.Text = "Фаренгейту";
            this.radioButtonFromFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromCelsius
            // 
            this.radioButtonFromCelsius.AutoSize = true;
            this.radioButtonFromCelsius.Location = new System.Drawing.Point(6, 20);
            this.radioButtonFromCelsius.Name = "radioButtonFromCelsius";
            this.radioButtonFromCelsius.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFromCelsius.TabIndex = 0;
            this.radioButtonFromCelsius.TabStop = true;
            this.radioButtonFromCelsius.Text = "Цельсию";
            this.radioButtonFromCelsius.UseVisualStyleBackColor = true;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(133, 68);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(88, 13);
            this.labelFrom.TabIndex = 9;
            this.labelFrom.Text = "Из градусов по:";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(138, 148);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(77, 13);
            this.labelTo.TabIndex = 10;
            this.labelTo.Text = "В градусы по:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.radioButtonToKelvin);
            this.groupBox2.Controls.Add(this.radioButtonToFahrenheit);
            this.groupBox2.Controls.Add(this.radioButtonToCelsius);
            this.groupBox2.Location = new System.Drawing.Point(36, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 50);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonToKelvin
            // 
            this.radioButtonToKelvin.AutoSize = true;
            this.radioButtonToKelvin.Location = new System.Drawing.Point(188, 20);
            this.radioButtonToKelvin.Name = "radioButtonToKelvin";
            this.radioButtonToKelvin.Size = new System.Drawing.Size(73, 17);
            this.radioButtonToKelvin.TabIndex = 2;
            this.radioButtonToKelvin.TabStop = true;
            this.radioButtonToKelvin.Text = "Кельвину";
            this.radioButtonToKelvin.UseVisualStyleBackColor = true;
            // 
            // radioButtonToFahrenheit
            // 
            this.radioButtonToFahrenheit.AutoSize = true;
            this.radioButtonToFahrenheit.Location = new System.Drawing.Point(97, 20);
            this.radioButtonToFahrenheit.Name = "radioButtonToFahrenheit";
            this.radioButtonToFahrenheit.Size = new System.Drawing.Size(87, 17);
            this.radioButtonToFahrenheit.TabIndex = 1;
            this.radioButtonToFahrenheit.TabStop = true;
            this.radioButtonToFahrenheit.Text = "Фаренгейту";
            this.radioButtonToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // radioButtonToCelsius
            // 
            this.radioButtonToCelsius.AutoSize = true;
            this.radioButtonToCelsius.Location = new System.Drawing.Point(6, 20);
            this.radioButtonToCelsius.Name = "radioButtonToCelsius";
            this.radioButtonToCelsius.Size = new System.Drawing.Size(71, 17);
            this.radioButtonToCelsius.TabIndex = 0;
            this.radioButtonToCelsius.TabStop = true;
            this.radioButtonToCelsius.Text = "Цельсию";
            this.radioButtonToCelsius.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(135, 229);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(84, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 326);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNewValue);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.resultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormView";
            this.Text = "Degree Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox resultBox;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Label labelNewValue;
		private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFromKelvin;
        private System.Windows.Forms.RadioButton radioButtonFromFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonFromCelsius;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonToKelvin;
        private System.Windows.Forms.RadioButton radioButtonToFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonToCelsius;
        private System.Windows.Forms.Button buttonOK;
    }
}

