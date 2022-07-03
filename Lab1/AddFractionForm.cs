using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AddCountryForm : Form
    {
        public AddCountryForm()
        {
            InitializeComponent();
        }

        private void ChangeButtonState() => ConfirmButton.Enabled = (int.TryParse(CapitalTextBox.Text, out int num1) && num1>0 && int.TryParse(RegionNumTextBox.Text, out int num2) && num2 > 0);

        private void CapitalTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

		private void RegionNumTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

		private void SquareTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void ConfirmButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void CancelButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        public string GetCapital() => CapitalTextBox.Text;

        public string GetRegionNum() => RegionNumTextBox.Text;

        public string GetSquare() => SquareTextBox.Text;


    }
}
