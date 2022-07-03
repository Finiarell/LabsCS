
namespace Lab2
{
    partial class AddCableForm
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.TypeTextBox = new System.Windows.Forms.TextBox();
			this.CaratWeightLabel = new System.Windows.Forms.Label();
			this.CoresNumTextBox = new System.Windows.Forms.TextBox();
			this.CutQualityLabel = new System.Windows.Forms.Label();
			this.DiameterTextBox = new System.Windows.Forms.TextBox();
			this.FirstClassRadioButton = new System.Windows.Forms.RadioButton();
			this.SecondClassRadioButton = new System.Windows.Forms.RadioButton();
			this.ColorLabel = new System.Windows.Forms.Label();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.IsBraidButtonTrue = new System.Windows.Forms.RadioButton();
			this.IsBraidButtonFalse = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.Location = new System.Drawing.Point(10, 40);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(480, 19);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Введите тип кабеля";
			// 
			// TypeTextBox
			// 
			this.TypeTextBox.Location = new System.Drawing.Point(12, 62);
			this.TypeTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.TypeTextBox.Name = "TypeTextBox";
			this.TypeTextBox.Size = new System.Drawing.Size(479, 20);
			this.TypeTextBox.TabIndex = 1;
			this.TypeTextBox.TextChanged += new System.EventHandler(this.TypeTextBox_TextChanged);
			// 
			// CaratWeightLabel
			// 
			this.CaratWeightLabel.Location = new System.Drawing.Point(10, 93);
			this.CaratWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CaratWeightLabel.Name = "CaratWeightLabel";
			this.CaratWeightLabel.Size = new System.Drawing.Size(480, 19);
			this.CaratWeightLabel.TabIndex = 2;
			this.CaratWeightLabel.Text = "Введите количество жил кабеля (целое число):";
			// 
			// CoresNumTextBox
			// 
			this.CoresNumTextBox.Location = new System.Drawing.Point(12, 115);
			this.CoresNumTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.CoresNumTextBox.Name = "CoresNumTextBox";
			this.CoresNumTextBox.Size = new System.Drawing.Size(479, 20);
			this.CoresNumTextBox.TabIndex = 3;
			this.CoresNumTextBox.TextChanged += new System.EventHandler(this.CoresNumTextBox_TextChanged);
			// 
			// CutQualityLabel
			// 
			this.CutQualityLabel.Location = new System.Drawing.Point(9, 149);
			this.CutQualityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CutQualityLabel.Name = "CutQualityLabel";
			this.CutQualityLabel.Size = new System.Drawing.Size(481, 19);
			this.CutQualityLabel.TabIndex = 4;
			this.CutQualityLabel.Text = "Введите диаметр (вещественное число):";
			// 
			// DiameterTextBox
			// 
			this.DiameterTextBox.Location = new System.Drawing.Point(12, 170);
			this.DiameterTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.DiameterTextBox.Name = "DiameterTextBox";
			this.DiameterTextBox.Size = new System.Drawing.Size(479, 20);
			this.DiameterTextBox.TabIndex = 5;
			this.DiameterTextBox.TextChanged += new System.EventHandler(this.DiameterTextBox_TextChanged);
			// 
			// FirstClassRadioButton
			// 
			this.FirstClassRadioButton.AutoSize = true;
			this.FirstClassRadioButton.Checked = true;
			this.FirstClassRadioButton.Location = new System.Drawing.Point(12, 10);
			this.FirstClassRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this.FirstClassRadioButton.Name = "FirstClassRadioButton";
			this.FirstClassRadioButton.Size = new System.Drawing.Size(132, 17);
			this.FirstClassRadioButton.TabIndex = 6;
			this.FirstClassRadioButton.TabStop = true;
			this.FirstClassRadioButton.Text = "Кабель первого типа";
			this.FirstClassRadioButton.UseVisualStyleBackColor = true;
			this.FirstClassRadioButton.CheckedChanged += new System.EventHandler(this.FirstClassRadioButton_CheckedChanged);
			// 
			// SecondClassRadioButton
			// 
			this.SecondClassRadioButton.AutoSize = true;
			this.SecondClassRadioButton.Location = new System.Drawing.Point(153, 10);
			this.SecondClassRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this.SecondClassRadioButton.Name = "SecondClassRadioButton";
			this.SecondClassRadioButton.Size = new System.Drawing.Size(131, 17);
			this.SecondClassRadioButton.TabIndex = 7;
			this.SecondClassRadioButton.Text = "Кабель второго типа";
			this.SecondClassRadioButton.UseVisualStyleBackColor = true;
			this.SecondClassRadioButton.CheckedChanged += new System.EventHandler(this.SecondClassRadioButton_CheckedChanged);
			// 
			// ColorLabel
			// 
			this.ColorLabel.Enabled = false;
			this.ColorLabel.Location = new System.Drawing.Point(9, 202);
			this.ColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ColorLabel.Name = "ColorLabel";
			this.ColorLabel.Size = new System.Drawing.Size(481, 19);
			this.ColorLabel.TabIndex = 8;
			this.ColorLabel.Text = "Наличие оплетки:";
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Enabled = false;
			this.ConfirmButton.Location = new System.Drawing.Point(98, 254);
			this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(128, 50);
			this.ConfirmButton.TabIndex = 10;
			this.ConfirmButton.Text = "OK";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(266, 254);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(128, 50);
			this.CancelButton.TabIndex = 11;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// IsBraidButtonTrue
			// 
			this.IsBraidButtonTrue.AutoSize = true;
			this.IsBraidButtonTrue.Enabled = false;
			this.IsBraidButtonTrue.Location = new System.Drawing.Point(12, 224);
			this.IsBraidButtonTrue.Name = "IsBraidButtonTrue";
			this.IsBraidButtonTrue.Size = new System.Drawing.Size(40, 17);
			this.IsBraidButtonTrue.TabIndex = 12;
			this.IsBraidButtonTrue.TabStop = true;
			this.IsBraidButtonTrue.Text = "Да";
			this.IsBraidButtonTrue.UseVisualStyleBackColor = true;
			// 
			// IsBraidButtonFalse
			// 
			this.IsBraidButtonFalse.AutoSize = true;
			this.IsBraidButtonFalse.Enabled = false;
			this.IsBraidButtonFalse.Location = new System.Drawing.Point(58, 224);
			this.IsBraidButtonFalse.Name = "IsBraidButtonFalse";
			this.IsBraidButtonFalse.Size = new System.Drawing.Size(44, 17);
			this.IsBraidButtonFalse.TabIndex = 13;
			this.IsBraidButtonFalse.TabStop = true;
			this.IsBraidButtonFalse.Text = "Нет";
			this.IsBraidButtonFalse.UseVisualStyleBackColor = true;
			// 
			// AddCableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 314);
			this.Controls.Add(this.IsBraidButtonFalse);
			this.Controls.Add(this.IsBraidButtonTrue);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.ColorLabel);
			this.Controls.Add(this.SecondClassRadioButton);
			this.Controls.Add(this.FirstClassRadioButton);
			this.Controls.Add(this.DiameterTextBox);
			this.Controls.Add(this.CutQualityLabel);
			this.Controls.Add(this.CoresNumTextBox);
			this.Controls.Add(this.CaratWeightLabel);
			this.Controls.Add(this.TypeTextBox);
			this.Controls.Add(this.NameLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddCableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddCableForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label CaratWeightLabel;
        private System.Windows.Forms.TextBox CoresNumTextBox;
        private System.Windows.Forms.Label CutQualityLabel;
        private System.Windows.Forms.TextBox DiameterTextBox;
        private System.Windows.Forms.RadioButton FirstClassRadioButton;
        private System.Windows.Forms.RadioButton SecondClassRadioButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.RadioButton IsBraidButtonTrue;
		private System.Windows.Forms.RadioButton IsBraidButtonFalse;
	}
}