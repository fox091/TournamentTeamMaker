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
        PlayerList pList;
        public Form1()
        {
            InitializeComponent();
            pList = new PlayerList();
        }

        private void btnAddSingle_Click(object sender, EventArgs e)
        {
            AddSolo();
        }

        private void txtSoloAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddSolo();
            }
        }
        private void btnDuoAdd_Click(object sender, EventArgs e)
        {

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

        private void AddSolo()
        {
            pList.AddSolo(txtSoloAdd.Text);
            txtSoloAdd.Clear();
            txtSoloAdd.Select();
            txtSoloAdd.Focus();
        }

        private void AddDuo()
        {
            pList.AddDuo(txtDuo1.Text, txtDuo2.Text);
            txtDuo1.Clear();
            txtDuo2.Clear();
            txtDuo1.Select();
            txtDuo1.Focus();
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
    }
}
