using Lab3.Technique;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GenerateMoneyCount();
        }

        private void GenerateMoneyCount()
        {
            Random random = new Random();
            MoneyLabel.Text = random.Next(1, 99999).ToString();
        }

        public List<IBuilding> buildings = new List<IBuilding>();

        private void VideoPlayerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                int current = TheatreListBox.SelectedIndex;
                AddForm edit = new AddForm(buildings[current]);
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    TheatreListBox.Items.RemoveAt(current);
                    TheatreListBox.Items.Insert(current, buildings[current]);
                }
            }
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            IBuilding building = new Theatre();
            AddForm add = new AddForm(building);
            if (add.ShowDialog() == DialogResult.OK)
            {
                buildings.Add(building);
                TheatreListBox.Items.Add(building);
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                int current = TheatreListBox.SelectedIndex;
                buildings.RemoveAt(current);
                TheatreListBox.Items.RemoveAt(current);
            }
        }

        private void AskInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                Theatre player = buildings[TheatreListBox.SelectedIndex] as Theatre;
                MessageBox.Show(player.DisplayInformation());
            }
        }

        private void WatchVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                Theatre player = buildings[TheatreListBox.SelectedIndex] as Theatre;
                MessageBox.Show(player.TryWatchPerformance());
            }
        }

        private void ChangeVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                Theatre player = buildings[TheatreListBox.SelectedIndex] as Theatre;
                MessageBox.Show(player.Replace());
            }
        }

        private void RateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                Theatre player = buildings[TheatreListBox.SelectedIndex] as Theatre;
                MessageBox.Show(player.Rate());
            }
        }

        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TheatreListBox.SelectedIndex != -1)
            {
                Theatre player = buildings[TheatreListBox.SelectedIndex] as Theatre;
                int oldMoney = int.Parse(MoneyLabel.Text);
                int money = oldMoney;
                MessageBox.Show(player.Buy(ref money));
                if (money != oldMoney)
                {
                    MoneyLabel.Text = money.ToString();
                }
            }
        }
    }
}
