using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddCableForm : Form
    {
        public AddCableForm()
        {
            InitializeComponent();
        }

        private void ChangeButtonState()
        {
            if (FirstClassRadioButton.Checked)
            {
                ConfirmButton.Enabled = TypeTextBox.TextLength != 0 && int.TryParse(CoresNumTextBox.Text, out int num1)
                    && int.TryParse(DiameterTextBox.Text, out int num2);
            }
            else
            {
                ConfirmButton.Enabled = TypeTextBox.TextLength != 0 && int.TryParse(CoresNumTextBox.Text, out int num1)
                    && int.TryParse(DiameterTextBox.Text, out int num2) && (IsBraidButtonTrue.Checked || IsBraidButtonFalse.Checked);
            }
        }

        private void ChangeColorState(bool state)
        {
            ColorLabel.Enabled = state; 
            IsBraidButtonTrue.Enabled = state;
            IsBraidButtonFalse.Enabled = state;
            if (!state) {
                IsBraidButtonTrue.Enabled = false;
                IsBraidButtonFalse.Enabled = false;           
            };
            ChangeButtonState();
        }

        private void ConfirmButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

        private void CancelButton_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void FirstClassRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeColorState(false);

        private void SecondClassRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeColorState(true);

        private void TypeTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void CoresNumTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        private void DiameterTextBox_TextChanged(object sender, EventArgs e) => ChangeButtonState();

        public string GetType() => TypeTextBox.Text;

        public string GetCoresNum() => CoresNumTextBox.Text;

        public string GetDiameter() => DiameterTextBox.Text;

        public bool GetBraid() => (IsBraidButtonTrue.Checked);

        public bool IsSecondType() => (IsBraidButtonFalse.Checked || IsBraidButtonTrue.Checked);

	}
}
