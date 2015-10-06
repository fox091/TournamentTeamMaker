using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamMaker
{
    public partial class Form1 : Form
    {
        private PlayerList pList;
        public Form1()
        {
            InitializeComponent();
            pList = new PlayerList();
        }
        private void btnSolo_Click(object sender, EventArgs e)
        {
            AddSolo();
        }
        private void txtSolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddSolo();
            }
        }
        private void btnDuo_Click(object sender, EventArgs e)
        {
            AddDuo();
        }
        private void txtDuo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtDuo2.Select();
                txtDuo2.Focus();
            }
        }
        private void txtDuo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddDuo();
            }
        }
        private void btnBuildTeams_Click(object sender, EventArgs e)
        {
            BuildTeams();
        }
        private void txtBuildTeams_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuildTeams();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to reset?", "Reset", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                pList = new PlayerList();
                ResetAllBoxes();
                lblCount.Text = "Total Players: " + pList.totalPlayers;
            }
        }
        private void AddSolo()
        {
            if (!String.IsNullOrWhiteSpace(txtSolo.Text) && txtSolo.Text.Length > 0)
            {
                pList.AddSolo(new Player(null, txtSolo.Text, 1));
                txtSolo.Clear();
                txtSolo.Select();
                txtSolo.Focus();
                lblCount.Text = "Total Players: " + pList.totalPlayers;
            }
        }
        private void AddDuo()
        {
            if (!String.IsNullOrWhiteSpace(txtDuo1.Text) && txtDuo1.Text.Length > 0 && !String.IsNullOrWhiteSpace(txtDuo2.Text) && txtDuo2.Text.Length > 0)
            {
                Player teammate = new Player(null, txtDuo2.Text, 0);
                pList.AddDuo(new Player(teammate, txtDuo1.Text, 2));
                txtDuo1.Clear();
                txtDuo2.Clear();
                txtDuo1.Select();
                txtDuo1.Focus();
                lblCount.Text = "Total Players: " + pList.totalPlayers;
            }
        }
        private void BuildTeams()
        {
            int teamSize = 0;
            int teamCount = 0;
            IList<Player> playerList;
            if (!Int32.TryParse(txtBuildTeams.Text, out teamSize))
            {
                MessageBox.Show("Could not read number. (Did you type something other than a number?)", "Error");
                return;
            }
            if (teamSize <= 0) 
            {
                MessageBox.Show("Team size cannot be lower than 1.", "Error");
                return;
            }
            if (pList.totalPlayers % teamSize != 0)
            {
                MessageBox.Show("There are not enough players to fill all teams.  Add " + /*a number*/"more players.", "Error");
                return;
            }
            playerList = pList.BuildTeams(teamSize);
            if (playerList == null)
            {
                MessageBox.Show("There too many duos in order to create full even teams.  Add " + /*a number (again)*/" more solos.", "Error");
                return;
            }
            ResetAllBoxes();
            for (int i = 0; i < pList.totalPlayers; i++)
            {
                if (teamSize > 1)
                {
                    if (i == 0)
                        lbResults.Items.Add("Team " + ++teamCount + ":");
                    else if (i % teamSize == 0)
                        lbResults.Items.Add("Team " + ++teamCount + ":");
                }
                lbResults.Items.Add(playerList[i].name);
            }
        }
        private void ResetAllBoxes()
        {
            txtBuildTeams.Clear();
            txtDuo1.Clear();
            txtDuo2.Clear();
            txtSolo.Clear();
            lbResults.Items.Clear();
        }
    }
}
