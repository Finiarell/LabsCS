using Lab2.Cable;
using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FirstTypeCable firstCable = null;

        SecondTypeCable secondCable = null;

        private void InputButton_Click(object sender, EventArgs e)
        {
            AddCableForm add = new AddCableForm();
            if (add.ShowDialog() == DialogResult.OK)
            {
                if (add.IsSecondType() == false)
                {
                    firstCable = new FirstTypeCable(add.GetType(), int.Parse(add.GetCoresNum()), double.Parse(add.GetDiameter()));
                    secondCable = null;
                }
                else
                {
                    secondCable = new SecondTypeCable(add.GetType(), int.Parse(add.GetCoresNum()), double.Parse(add.GetDiameter()), add.GetBraid());
                    firstCable = null;
                }
                DiamondTextLabel.Text = "";
            }    
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            if (firstCable == null && secondCable == null)
            {
                DiamondTextLabel.Text = "";
                MessageBox.Show("Сначала введите данные о кабеле!");
            }
            else if (secondCable == null)
            {
                DiamondTextLabel.Text = firstCable.ToString();
            }
            else if (firstCable == null)
            {
                DiamondTextLabel.Text = secondCable.ToString();
            }
        }

        private void QualityButton_Click(object sender, EventArgs e)
        {
            if (firstCable == null && secondCable == null)
            {
                DiamondTextLabel.Text = "";
                MessageBox.Show("Сначала введите данные о кабеле!");
            }
            else if (secondCable == null)
            {
                MessageBox.Show("Диаметр кабеля первого типа: " + firstCable.Quality());
            }
            else if (firstCable == null)
            {
                MessageBox.Show("Диаметр кабеля второго типа: " + secondCable.Quality());
            }
        }
    }
}
