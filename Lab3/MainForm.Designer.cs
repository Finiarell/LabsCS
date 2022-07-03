
namespace Lab3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TheatreListBox = new System.Windows.Forms.ListBox();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.ActionToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.AskInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WatchVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangeVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BuyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MoneyTextLabel = new System.Windows.Forms.Label();
			this.MoneyLabel = new System.Windows.Forms.Label();
			this.ToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TheatreListBox
			// 
			this.TheatreListBox.FormattingEnabled = true;
			this.TheatreListBox.Location = new System.Drawing.Point(10, 39);
			this.TheatreListBox.Margin = new System.Windows.Forms.Padding(2);
			this.TheatreListBox.Name = "TheatreListBox";
			this.TheatreListBox.Size = new System.Drawing.Size(704, 316);
			this.TheatreListBox.TabIndex = 0;
			this.TheatreListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VideoPlayerListBox_MouseDoubleClick);
			// 
			// ToolStrip
			// 
			this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripButton,
            this.DeleteToolStripButton,
            this.ActionToolStripButton});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Size = new System.Drawing.Size(722, 25);
			this.ToolStrip.TabIndex = 1;
			this.ToolStrip.Text = "toolStrip1";
			// 
			// AddToolStripButton
			// 
			this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
			this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddToolStripButton.Name = "AddToolStripButton";
			this.AddToolStripButton.Size = new System.Drawing.Size(63, 22);
			this.AddToolStripButton.Text = "Добавить";
			this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
			// 
			// DeleteToolStripButton
			// 
			this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
			this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteToolStripButton.Name = "DeleteToolStripButton";
			this.DeleteToolStripButton.Size = new System.Drawing.Size(55, 22);
			this.DeleteToolStripButton.Text = "Удалить";
			this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
			// 
			// ActionToolStripButton
			// 
			this.ActionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ActionToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AskInfoToolStripMenuItem,
            this.WatchVideoToolStripMenuItem,
            this.ChangeVolumeToolStripMenuItem,
            this.BuyToolStripMenuItem,
            this.RateToolStripMenuItem});
			this.ActionToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActionToolStripButton.Image")));
			this.ActionToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ActionToolStripButton.Name = "ActionToolStripButton";
			this.ActionToolStripButton.Size = new System.Drawing.Size(128, 22);
			this.ActionToolStripButton.Text = "Действия с театром";
			// 
			// AskInfoToolStripMenuItem
			// 
			this.AskInfoToolStripMenuItem.Name = "AskInfoToolStripMenuItem";
			this.AskInfoToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.AskInfoToolStripMenuItem.Text = "Отобразить полную информацию";
			this.AskInfoToolStripMenuItem.Click += new System.EventHandler(this.AskInfoToolStripMenuItem_Click);
			// 
			// WatchVideoToolStripMenuItem
			// 
			this.WatchVideoToolStripMenuItem.Name = "WatchVideoToolStripMenuItem";
			this.WatchVideoToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.WatchVideoToolStripMenuItem.Text = "Посмотреть представление";
			this.WatchVideoToolStripMenuItem.Click += new System.EventHandler(this.WatchVideoToolStripMenuItem_Click);
			// 
			// ChangeVolumeToolStripMenuItem
			// 
			this.ChangeVolumeToolStripMenuItem.Name = "ChangeVolumeToolStripMenuItem";
			this.ChangeVolumeToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.ChangeVolumeToolStripMenuItem.Text = "Пересесть на другое место";
			this.ChangeVolumeToolStripMenuItem.Click += new System.EventHandler(this.ChangeVolumeToolStripMenuItem_Click);
			// 
			// BuyToolStripMenuItem
			// 
			this.BuyToolStripMenuItem.Name = "BuyToolStripMenuItem";
			this.BuyToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.BuyToolStripMenuItem.Text = "Купить здание";
			this.BuyToolStripMenuItem.Click += new System.EventHandler(this.BuyToolStripMenuItem_Click);
			// 
			// RateToolStripMenuItem
			// 
			this.RateToolStripMenuItem.Name = "RateToolStripMenuItem";
			this.RateToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.RateToolStripMenuItem.Text = "Посмотреть популярность здания";
			this.RateToolStripMenuItem.Click += new System.EventHandler(this.RateToolStripMenuItem_Click);
			// 
			// MoneyTextLabel
			// 
			this.MoneyTextLabel.Location = new System.Drawing.Point(602, 18);
			this.MoneyTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MoneyTextLabel.Name = "MoneyTextLabel";
			this.MoneyTextLabel.Size = new System.Drawing.Size(75, 19);
			this.MoneyTextLabel.TabIndex = 2;
			this.MoneyTextLabel.Text = "Ваши деньги:";
			// 
			// MoneyLabel
			// 
			this.MoneyLabel.Location = new System.Drawing.Point(682, 18);
			this.MoneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.MoneyLabel.Name = "MoneyLabel";
			this.MoneyLabel.Size = new System.Drawing.Size(31, 19);
			this.MoneyLabel.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 379);
			this.Controls.Add(this.MoneyLabel);
			this.Controls.Add(this.MoneyTextLabel);
			this.Controls.Add(this.ToolStrip);
			this.Controls.Add(this.TheatreListBox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ToolStrip.ResumeLayout(false);
			this.ToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TheatreListBox;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton ActionToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem AskInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WatchVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeVolumeToolStripMenuItem;
        private System.Windows.Forms.Label MoneyTextLabel;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.ToolStripMenuItem BuyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RateToolStripMenuItem;
    }
}

