using System.Windows.Forms;
using Lab1.Fraction;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Country country;

       private void ChangeButtonState()
        {
            CapitalButton.Enabled = (country.DisplayCapital() != "Столица: ");
            RegionNumButton.Enabled = (country.DisplayCapital() != "Столица: ");
            SquareButton.Enabled = (country.DisplayCapital() != "Столица: ");
        }
       

		private void RegionNumButton_Click(object sender, System.EventArgs e)
		{
            MessageBox.Show(country.DisplayRegionNum());

        }

		private void SquareButton_Click(object sender, System.EventArgs e)
		{
            MessageBox.Show(country.DisplaySquare());

        }

		private void MainForm_Activated(object sender, System.EventArgs e)
		{
            CountryButton.Enabled = true;
		}

		private void CountryButton_Click_1(object sender, System.EventArgs e)
		{
            AddCountryForm add = new AddCountryForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                country = new Country(add.GetCapital(), int.Parse(add.GetRegionNum()), int.Parse(add.GetSquare()));
                ChangeButtonState();
            }
        }

		private void CapitalButton_Click(object sender, System.EventArgs e)
		{
            MessageBox.Show(country.DisplayCapital());
        }


	}
}
