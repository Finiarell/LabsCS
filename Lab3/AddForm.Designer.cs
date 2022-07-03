
namespace Lab3
{
    partial class AddForm
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
			this.PriceLabel = new System.Windows.Forms.Label();
			this.PriceTextBox = new System.Windows.Forms.TextBox();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.DirectorLabel = new System.Windows.Forms.Label();
			this.DirectorTextBox = new System.Windows.Forms.TextBox();
			this.FoundationYearLabel = new System.Windows.Forms.Label();
			this.FoundationYearTextBox = new System.Windows.Forms.TextBox();
			this.RepairYearLabel = new System.Windows.Forms.Label();
			this.RepairYearTextBox = new System.Windows.Forms.TextBox();
			this.PerformanceLabel = new System.Windows.Forms.Label();
			this.PerfomanceTextBox = new System.Windows.Forms.TextBox();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PriceLabel
			// 
			this.PriceLabel.Location = new System.Drawing.Point(10, 11);
			this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(335, 19);
			this.PriceLabel.TabIndex = 0;
			this.PriceLabel.Text = "Введите цену (целое положительное):";
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Location = new System.Drawing.Point(12, 32);
			this.PriceTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(334, 20);
			this.PriceTextBox.TabIndex = 1;
			this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
			// 
			// AddressLabel
			// 
			this.AddressLabel.Location = new System.Drawing.Point(10, 62);
			this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(335, 19);
			this.AddressLabel.TabIndex = 2;
			this.AddressLabel.Text = "Введите адрес:";
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Location = new System.Drawing.Point(12, 83);
			this.AddressTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(334, 20);
			this.AddressTextBox.TabIndex = 3;
			this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
			// 
			// DirectorLabel
			// 
			this.DirectorLabel.Location = new System.Drawing.Point(10, 111);
			this.DirectorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DirectorLabel.Name = "DirectorLabel";
			this.DirectorLabel.Size = new System.Drawing.Size(335, 19);
			this.DirectorLabel.TabIndex = 4;
			this.DirectorLabel.Text = "Введите ФИО директора:";
			// 
			// DirectorTextBox
			// 
			this.DirectorTextBox.Location = new System.Drawing.Point(12, 132);
			this.DirectorTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.DirectorTextBox.Name = "DirectorTextBox";
			this.DirectorTextBox.Size = new System.Drawing.Size(334, 20);
			this.DirectorTextBox.TabIndex = 5;
			this.DirectorTextBox.TextChanged += new System.EventHandler(this.DirectorTextBox_TextChanged);
			// 
			// FoundationYearLabel
			// 
			this.FoundationYearLabel.Location = new System.Drawing.Point(10, 161);
			this.FoundationYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.FoundationYearLabel.Name = "FoundationYearLabel";
			this.FoundationYearLabel.Size = new System.Drawing.Size(335, 19);
			this.FoundationYearLabel.TabIndex = 6;
			this.FoundationYearLabel.Text = "Введите год основания (целое положительное):";
			// 
			// FoundationYearTextBox
			// 
			this.FoundationYearTextBox.Location = new System.Drawing.Point(12, 182);
			this.FoundationYearTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.FoundationYearTextBox.Name = "FoundationYearTextBox";
			this.FoundationYearTextBox.Size = new System.Drawing.Size(334, 20);
			this.FoundationYearTextBox.TabIndex = 7;
			this.FoundationYearTextBox.TextChanged += new System.EventHandler(this.FoundationYearTextBox_TextChanged);
			// 
			// RepairYearLabel
			// 
			this.RepairYearLabel.Location = new System.Drawing.Point(10, 210);
			this.RepairYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RepairYearLabel.Name = "RepairYearLabel";
			this.RepairYearLabel.Size = new System.Drawing.Size(335, 19);
			this.RepairYearLabel.TabIndex = 8;
			this.RepairYearLabel.Text = "Введите год последней реконструкции (целое положительное):";
			// 
			// RepairYearTextBox
			// 
			this.RepairYearTextBox.Location = new System.Drawing.Point(12, 231);
			this.RepairYearTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.RepairYearTextBox.Name = "RepairYearTextBox";
			this.RepairYearTextBox.Size = new System.Drawing.Size(334, 20);
			this.RepairYearTextBox.TabIndex = 9;
			this.RepairYearTextBox.TextChanged += new System.EventHandler(this.RepairYearTextBox_TextChanged);
			// 
			// PerformanceLabel
			// 
			this.PerformanceLabel.Location = new System.Drawing.Point(10, 260);
			this.PerformanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.PerformanceLabel.Name = "PerformanceLabel";
			this.PerformanceLabel.Size = new System.Drawing.Size(335, 19);
			this.PerformanceLabel.TabIndex = 10;
			this.PerformanceLabel.Text = "Введите название ближайшего представления:";
			// 
			// PerfomanceTextBox
			// 
			this.PerfomanceTextBox.Location = new System.Drawing.Point(12, 281);
			this.PerfomanceTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.PerfomanceTextBox.Name = "PerfomanceTextBox";
			this.PerfomanceTextBox.Size = new System.Drawing.Size(334, 20);
			this.PerfomanceTextBox.TabIndex = 11;
			this.PerfomanceTextBox.TextChanged += new System.EventHandler(this.PerformanceTextBox_TextChanged);
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.Enabled = false;
			this.ConfirmButton.Location = new System.Drawing.Point(58, 316);
			this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(105, 39);
			this.ConfirmButton.TabIndex = 12;
			this.ConfirmButton.Text = "OK";
			this.ConfirmButton.UseVisualStyleBackColor = true;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(183, 316);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(105, 39);
			this.CancelButton.TabIndex = 13;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// AddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 377);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.PerfomanceTextBox);
			this.Controls.Add(this.PerformanceLabel);
			this.Controls.Add(this.RepairYearTextBox);
			this.Controls.Add(this.RepairYearLabel);
			this.Controls.Add(this.FoundationYearTextBox);
			this.Controls.Add(this.FoundationYearLabel);
			this.Controls.Add(this.DirectorTextBox);
			this.Controls.Add(this.DirectorLabel);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.AddressLabel);
			this.Controls.Add(this.PriceTextBox);
			this.Controls.Add(this.PriceLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddForm";
			this.Text = "AddForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.TextBox DirectorTextBox;
        private System.Windows.Forms.Label FoundationYearLabel;
        private System.Windows.Forms.TextBox FoundationYearTextBox;
        private System.Windows.Forms.Label RepairYearLabel;
        private System.Windows.Forms.TextBox RepairYearTextBox;
        private System.Windows.Forms.Label PerformanceLabel;
        private System.Windows.Forms.TextBox PerfomanceTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
    }
}