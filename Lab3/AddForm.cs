using Lab3.Technique;
using System.Windows.Forms;

namespace Lab3
{
    public partial class AddForm : Form
    {
        Theatre videoPlayer = new Theatre();
        public AddForm(IBuilding tech)
        {
            InitializeComponent();
            if (tech is Theatre)
            {
                videoPlayer = tech as Theatre;
                PriceTextBox.Text = videoPlayer.Price.ToString();
                AddressTextBox.Text = videoPlayer.Location;
                DirectorTextBox.Text = videoPlayer.Director;
                FoundationYearTextBox.Text = videoPlayer.FoundationYear.ToString();
                RepairYearTextBox.Text = videoPlayer.LastRepair.ToString();
                PerfomanceTextBox.Text = videoPlayer.Performance;
            }
        }

        private void ChangeButtonState() => ConfirmButton.Enabled = (PriceTextBox.TextLength > 0 && int.TryParse(PriceTextBox.Text, out int num1) && 
                num1 > 0 && AddressTextBox.TextLength > 0 && DirectorTextBox.TextLength > 0 && FoundationYearTextBox.TextLength > 0 && 
                int.TryParse(FoundationYearTextBox.Text, out int num2) && num2 > 0 && RepairYearTextBox.TextLength > 0 &&
                int.TryParse(RepairYearTextBox.Text, out int num3) && num3 > 0 && PerfomanceTextBox.TextLength > 0);

        private void PriceTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void AddressTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void DirectorTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void FoundationYearTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void RepairYearTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void PerformanceTextBox_TextChanged(object sender, System.EventArgs e) => ChangeButtonState();

        private void ConfirmButton_Click(object sender, System.EventArgs e) => SaveInfo();

        private void CancelButton_Click(object sender, System.EventArgs e) => this.DialogResult = DialogResult.Cancel;

        private void SaveInfo()
        {
            videoPlayer.Price = int.Parse(PriceTextBox.Text);
            videoPlayer.Location = AddressTextBox.Text;
            videoPlayer.Director = DirectorTextBox.Text;
            videoPlayer.FoundationYear = int.Parse(FoundationYearTextBox.Text);
            videoPlayer.LastRepair = int.Parse(RepairYearTextBox.Text);
            videoPlayer.Performance = PerfomanceTextBox.Text;
            this.DialogResult = DialogResult.OK;
        }


	}
}
