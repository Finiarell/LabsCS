
namespace Lab4
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
			this.ClassesComboBox = new System.Windows.Forms.ComboBox();
			this.ClassesLabel = new System.Windows.Forms.Label();
			this.MethodsLabel = new System.Windows.Forms.Label();
			this.MethodsComboBox = new System.Windows.Forms.ComboBox();
			this.CreateButton = new System.Windows.Forms.Button();
			this.ObjectPropertiesListBox = new System.Windows.Forms.ListBox();
			this.ObjectPropertiesLabel = new System.Windows.Forms.Label();
			this.MethodParametersListBox = new System.Windows.Forms.ListBox();
			this.MethodParametersLabel = new System.Windows.Forms.Label();
			this.EnterParametersButton = new System.Windows.Forms.Button();
			this.ExecuteMethodButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ClassesComboBox
			// 
			this.ClassesComboBox.FormattingEnabled = true;
			this.ClassesComboBox.Location = new System.Drawing.Point(55, 11);
			this.ClassesComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ClassesComboBox.Name = "ClassesComboBox";
			this.ClassesComboBox.Size = new System.Drawing.Size(96, 21);
			this.ClassesComboBox.TabIndex = 0;
			this.ClassesComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassesComboBox_SelectedIndexChanged);
			// 
			// ClassesLabel
			// 
			this.ClassesLabel.Location = new System.Drawing.Point(9, 11);
			this.ClassesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ClassesLabel.Name = "ClassesLabel";
			this.ClassesLabel.Size = new System.Drawing.Size(41, 20);
			this.ClassesLabel.TabIndex = 1;
			this.ClassesLabel.Text = "Класс:";
			this.ClassesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MethodsLabel
			// 
			this.MethodsLabel.Location = new System.Drawing.Point(154, 11);
			this.MethodsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MethodsLabel.Name = "MethodsLabel";
			this.MethodsLabel.Size = new System.Drawing.Size(48, 20);
			this.MethodsLabel.TabIndex = 2;
			this.MethodsLabel.Text = "Метод:";
			this.MethodsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MethodsComboBox
			// 
			this.MethodsComboBox.Enabled = false;
			this.MethodsComboBox.FormattingEnabled = true;
			this.MethodsComboBox.Location = new System.Drawing.Point(207, 11);
			this.MethodsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MethodsComboBox.Name = "MethodsComboBox";
			this.MethodsComboBox.Size = new System.Drawing.Size(173, 21);
			this.MethodsComboBox.TabIndex = 3;
			this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged);
			// 
			// CreateButton
			// 
			this.CreateButton.Enabled = false;
			this.CreateButton.Location = new System.Drawing.Point(397, 11);
			this.CreateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(129, 20);
			this.CreateButton.TabIndex = 4;
			this.CreateButton.Text = "Создать объект";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// ObjectPropertiesListBox
			// 
			this.ObjectPropertiesListBox.FormattingEnabled = true;
			this.ObjectPropertiesListBox.Location = new System.Drawing.Point(11, 73);
			this.ObjectPropertiesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ObjectPropertiesListBox.Name = "ObjectPropertiesListBox";
			this.ObjectPropertiesListBox.Size = new System.Drawing.Size(278, 186);
			this.ObjectPropertiesListBox.TabIndex = 5;
			this.ObjectPropertiesListBox.SelectedIndexChanged += new System.EventHandler(this.ObjectPropertiesListBox_SelectedIndexChanged);
			// 
			// ObjectPropertiesLabel
			// 
			this.ObjectPropertiesLabel.Location = new System.Drawing.Point(11, 54);
			this.ObjectPropertiesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.ObjectPropertiesLabel.Name = "ObjectPropertiesLabel";
			this.ObjectPropertiesLabel.Size = new System.Drawing.Size(103, 19);
			this.ObjectPropertiesLabel.TabIndex = 6;
			this.ObjectPropertiesLabel.Text = "Свойства объекта";
			// 
			// MethodParametersListBox
			// 
			this.MethodParametersListBox.FormattingEnabled = true;
			this.MethodParametersListBox.Location = new System.Drawing.Point(293, 73);
			this.MethodParametersListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MethodParametersListBox.Name = "MethodParametersListBox";
			this.MethodParametersListBox.Size = new System.Drawing.Size(234, 186);
			this.MethodParametersListBox.TabIndex = 7;
			// 
			// MethodParametersLabel
			// 
			this.MethodParametersLabel.AutoSize = true;
			this.MethodParametersLabel.Location = new System.Drawing.Point(291, 54);
			this.MethodParametersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MethodParametersLabel.Name = "MethodParametersLabel";
			this.MethodParametersLabel.Size = new System.Drawing.Size(170, 13);
			this.MethodParametersLabel.TabIndex = 8;
			this.MethodParametersLabel.Text = "Параметры выбранного метода";
			// 
			// EnterParametersButton
			// 
			this.EnterParametersButton.Enabled = false;
			this.EnterParametersButton.Location = new System.Drawing.Point(293, 263);
			this.EnterParametersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.EnterParametersButton.Name = "EnterParametersButton";
			this.EnterParametersButton.Size = new System.Drawing.Size(121, 30);
			this.EnterParametersButton.TabIndex = 9;
			this.EnterParametersButton.Text = "Ввести параметры";
			this.EnterParametersButton.UseVisualStyleBackColor = true;
			this.EnterParametersButton.Click += new System.EventHandler(this.EnterParametersButton_Click);
			// 
			// ExecuteMethodButton
			// 
			this.ExecuteMethodButton.Enabled = false;
			this.ExecuteMethodButton.Location = new System.Drawing.Point(418, 263);
			this.ExecuteMethodButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ExecuteMethodButton.Name = "ExecuteMethodButton";
			this.ExecuteMethodButton.Size = new System.Drawing.Size(107, 30);
			this.ExecuteMethodButton.TabIndex = 10;
			this.ExecuteMethodButton.Text = "Выполнить метод";
			this.ExecuteMethodButton.UseVisualStyleBackColor = true;
			this.ExecuteMethodButton.Click += new System.EventHandler(this.ExecuteMethodButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 304);
			this.Controls.Add(this.ExecuteMethodButton);
			this.Controls.Add(this.EnterParametersButton);
			this.Controls.Add(this.MethodParametersLabel);
			this.Controls.Add(this.MethodParametersListBox);
			this.Controls.Add(this.ObjectPropertiesLabel);
			this.Controls.Add(this.ObjectPropertiesListBox);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.MethodsComboBox);
			this.Controls.Add(this.MethodsLabel);
			this.Controls.Add(this.ClassesLabel);
			this.Controls.Add(this.ClassesComboBox);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassesComboBox;
        private System.Windows.Forms.Label ClassesLabel;
        private System.Windows.Forms.Label MethodsLabel;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ListBox ObjectPropertiesListBox;
        private System.Windows.Forms.Label ObjectPropertiesLabel;
        private System.Windows.Forms.ListBox MethodParametersListBox;
        private System.Windows.Forms.Label MethodParametersLabel;
        private System.Windows.Forms.Button EnterParametersButton;
        private System.Windows.Forms.Button ExecuteMethodButton;
    }
}

