
namespace Lab1
{
    partial class AddCountryForm
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
			this.CapitalLabel = new System.Windows.Forms.Label();
			this.CapitalTextBox = new System.Windows.Forms.TextBox();
			this.RegionNumLabel = new System.Windows.Forms.Label();
			this.RegionNumTextBox = new System.Windows.Forms.TextBox();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SquareLabel = new System.Windows.Forms.Label();
			this.SquareTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CapitalLabel
			// 
			this.CapitalLabel.Location = new System.Drawing.Point(7, 7);
			this.CapitalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CapitalLabel.Name = "CapitalLabel";
			this.CapitalLabel.Size = new System.Drawing.Size(134, 19);
			this.CapitalLabel.TabIndex = 0;
			this.CapitalLabel.Text = "Введите столицу";
			// 
			// CapitalTextBox
			// 
			this.CapitalTextBox.Location = new System.Drawing.Point(9, 28);
			this.CapitalTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.CapitalTextBox.Name = "CapitalTextBox";
			this.CapitalTextBox.Size = new System.Drawing.Size(398, 20);
			this.CapitalTextBox.TabIndex = 1;
			this.CapitalTextBox.TextChanged += new System.EventHandler(this.CapitalTextBox_TextChanged);
			// 
			// RegionNumLabel
			// 
			this.RegionNumLabel.Location = new System.Drawing.Point(7, 69);
			this.RegionNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RegionNumLabel.Name = "RegionNumLabel";
			this.RegionNumLabel.Size = new System.Drawing.Size(174, 19);
			this.RegionNumLabel.TabIndex = 2;
			this.RegionNumLabel.Text = "Введите количество областей:";
			// 
			// RegionNumTextBox
			// 
			this.RegionNumTextBox.Location = new System.Drawing.Point(9, 90);
			this.RegionNumTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.RegionNumTextBox.Name = "RegionNumTextBox";
			this.RegionNumTextBox.Size = new System.Drawing.Size(398, 20);
			this.RegionNumTextBox.TabIndex = 3;
			this.RegionNumTextBox.TextChanged += new System.EventHandler(this.RegionNumTextBox_TextChanged);
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Enabled = false;
			this.ConfirmButton.Location = new System.Drawing.Point(44, 202);
			this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(97, 34);
			this.ConfirmButton.TabIndex = 4;
			this.ConfirmButton.Text = "ОК";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(259, 202);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(97, 34);
			this.CancelButton.TabIndex = 5;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SquareLabel
			// 
			this.SquareLabel.AutoSize = true;
			this.SquareLabel.Location = new System.Drawing.Point(6, 132);
			this.SquareLabel.Name = "SquareLabel";
			this.SquareLabel.Size = new System.Drawing.Size(140, 13);
			this.SquareLabel.TabIndex = 6;
			this.SquareLabel.Text = "Введите площадь страны:";
			// 
			// SquareTextBox
			// 
			this.SquareTextBox.Location = new System.Drawing.Point(9, 148);
			this.SquareTextBox.Name = "SquareTextBox";
			this.SquareTextBox.Size = new System.Drawing.Size(398, 20);
			this.SquareTextBox.TabIndex = 7;
			this.SquareTextBox.TextChanged += new System.EventHandler(this.SquareTextBox_TextChanged);
			// 
			// AddCountryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 256);
			this.Controls.Add(this.SquareTextBox);
			this.Controls.Add(this.SquareLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.RegionNumTextBox);
			this.Controls.Add(this.RegionNumLabel);
			this.Controls.Add(this.CapitalTextBox);
			this.Controls.Add(this.CapitalLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddCountryForm";
			this.Text = "AddCountryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CapitalLabel;
        private System.Windows.Forms.TextBox CapitalTextBox;
        private System.Windows.Forms.Label RegionNumLabel;
        private System.Windows.Forms.TextBox RegionNumTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label SquareLabel;
		private System.Windows.Forms.TextBox SquareTextBox;
	}
}