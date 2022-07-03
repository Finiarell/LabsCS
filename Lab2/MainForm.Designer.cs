
namespace Lab2
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
			this.DiamondLabel = new System.Windows.Forms.Label();
			this.DiamondTextLabel = new System.Windows.Forms.Label();
			this.InputButton = new System.Windows.Forms.Button();
			this.OutputButton = new System.Windows.Forms.Button();
			this.QualityButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DiamondLabel
			// 
			this.DiamondLabel.Location = new System.Drawing.Point(10, 11);
			this.DiamondLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DiamondLabel.Name = "DiamondLabel";
			this.DiamondLabel.Size = new System.Drawing.Size(100, 19);
			this.DiamondLabel.TabIndex = 0;
			this.DiamondLabel.Text = "Текущий кабель:";
			// 
			// DiamondTextLabel
			// 
			this.DiamondTextLabel.Location = new System.Drawing.Point(104, 11);
			this.DiamondTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.DiamondTextLabel.Name = "DiamondTextLabel";
			this.DiamondTextLabel.Size = new System.Drawing.Size(489, 19);
			this.DiamondTextLabel.TabIndex = 1;
			// 
			// InputButton
			// 
			this.InputButton.Location = new System.Drawing.Point(12, 32);
			this.InputButton.Margin = new System.Windows.Forms.Padding(2);
			this.InputButton.Name = "InputButton";
			this.InputButton.Size = new System.Drawing.Size(200, 38);
			this.InputButton.TabIndex = 2;
			this.InputButton.Text = "Ввести кабель";
			this.InputButton.UseVisualStyleBackColor = true;
			this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
			// 
			// OutputButton
			// 
			this.OutputButton.Location = new System.Drawing.Point(216, 32);
			this.OutputButton.Margin = new System.Windows.Forms.Padding(2);
			this.OutputButton.Name = "OutputButton";
			this.OutputButton.Size = new System.Drawing.Size(186, 39);
			this.OutputButton.TabIndex = 3;
			this.OutputButton.Text = "Вывести кабель";
			this.OutputButton.UseVisualStyleBackColor = true;
			this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
			// 
			// QualityButton
			// 
			this.QualityButton.Location = new System.Drawing.Point(406, 32);
			this.QualityButton.Margin = new System.Windows.Forms.Padding(2);
			this.QualityButton.Name = "QualityButton";
			this.QualityButton.Size = new System.Drawing.Size(186, 39);
			this.QualityButton.TabIndex = 4;
			this.QualityButton.Text = "Посчитать диаметр";
			this.QualityButton.UseVisualStyleBackColor = true;
			this.QualityButton.Click += new System.EventHandler(this.QualityButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 80);
			this.Controls.Add(this.QualityButton);
			this.Controls.Add(this.OutputButton);
			this.Controls.Add(this.InputButton);
			this.Controls.Add(this.DiamondTextLabel);
			this.Controls.Add(this.DiamondLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DiamondLabel;
        private System.Windows.Forms.Label DiamondTextLabel;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button QualityButton;
    }
}

