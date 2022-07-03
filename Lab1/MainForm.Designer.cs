
namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.FirstFractionLabel = new System.Windows.Forms.Label();
			this.SecondFractionLabel = new System.Windows.Forms.Label();
			this.CountryButton = new System.Windows.Forms.Button();
			this.CapitalButton = new System.Windows.Forms.Button();
			this.RegionNumButton = new System.Windows.Forms.Button();
			this.SquareButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FirstFractionLabel
			// 
			this.FirstFractionLabel.Location = new System.Drawing.Point(106, 9);
			this.FirstFractionLabel.Name = "FirstFractionLabel";
			this.FirstFractionLabel.Size = new System.Drawing.Size(96, 39);
			this.FirstFractionLabel.TabIndex = 3;
			// 
			// SecondFractionLabel
			// 
			this.SecondFractionLabel.Location = new System.Drawing.Point(107, 48);
			this.SecondFractionLabel.Name = "SecondFractionLabel";
			this.SecondFractionLabel.Size = new System.Drawing.Size(95, 49);
			this.SecondFractionLabel.TabIndex = 4;
			// 
			// CountryButton
			// 
			this.CountryButton.Location = new System.Drawing.Point(208, 24);
			this.CountryButton.Name = "CountryButton";
			this.CountryButton.Size = new System.Drawing.Size(167, 83);
			this.CountryButton.TabIndex = 5;
			this.CountryButton.Text = "Ввести страну";
			this.CountryButton.UseVisualStyleBackColor = true;
			this.CountryButton.Click += new System.EventHandler(this.CountryButton_Click_1);
			// 
			// CapitalButton
			// 
			this.CapitalButton.Enabled = false;
			this.CapitalButton.Location = new System.Drawing.Point(23, 124);
			this.CapitalButton.Name = "CapitalButton";
			this.CapitalButton.Size = new System.Drawing.Size(162, 76);
			this.CapitalButton.TabIndex = 6;
			this.CapitalButton.Text = "Показать столицу";
			this.CapitalButton.UseVisualStyleBackColor = true;
			this.CapitalButton.Click += new System.EventHandler(this.CapitalButton_Click);
			// 
			// RegionNumButton
			// 
			this.RegionNumButton.Enabled = false;
			this.RegionNumButton.Location = new System.Drawing.Point(213, 124);
			this.RegionNumButton.Name = "RegionNumButton";
			this.RegionNumButton.Size = new System.Drawing.Size(162, 76);
			this.RegionNumButton.TabIndex = 7;
			this.RegionNumButton.Text = "Показать количество областей";
			this.RegionNumButton.UseVisualStyleBackColor = true;
			this.RegionNumButton.Click += new System.EventHandler(this.RegionNumButton_Click);
			// 
			// SquareButton
			// 
			this.SquareButton.Enabled = false;
			this.SquareButton.Location = new System.Drawing.Point(400, 124);
			this.SquareButton.Name = "SquareButton";
			this.SquareButton.Size = new System.Drawing.Size(162, 76);
			this.SquareButton.TabIndex = 8;
			this.SquareButton.Text = "Показать площадь страны";
			this.SquareButton.UseVisualStyleBackColor = true;
			this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.ClientSize = new System.Drawing.Size(598, 224);
			this.Controls.Add(this.SquareButton);
			this.Controls.Add(this.RegionNumButton);
			this.Controls.Add(this.CapitalButton);
			this.Controls.Add(this.CountryButton);
			this.Controls.Add(this.SecondFractionLabel);
			this.Controls.Add(this.FirstFractionLabel);
			this.Enabled = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label FirstFractionLabel;
        private System.Windows.Forms.Label SecondFractionLabel;
		private System.Windows.Forms.Button CapitalButton;
		private System.Windows.Forms.Button RegionNumButton;
		private System.Windows.Forms.Button SquareButton;
		public System.Windows.Forms.Button CountryButton;
	}
}

