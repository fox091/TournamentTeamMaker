using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TeamMaker
{
    public partial class Form1 : Form
    {
        private PlayerList pList;

        public Form1()
        {
            this.InitializeComponent();
            this.pList = new PlayerList();
        }

        #region UI control event stubs
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
                lblCount.Text = $"Total Players: { pList.TotalPlayers }";
            }
        }
        #endregion

        /// <summary>
        /// Validates user input and adds a solo player to the player list.
        /// </summary>
        private void AddSolo()
        {
            if (String.IsNullOrWhiteSpace(this.txtSolo.Text) || this.txtSolo.Text.Length <= 0)
            {
                return;
            }
            var soloPlayer = new Player(null, this.txtSolo.Text, 1);
            this.lbCurrentPlayers.Items.Add(soloPlayer.GetPlayerOrDuoNames());
            this.pList.AddSolo(soloPlayer);
            this.txtSolo.Clear();
            this.txtSolo.Select();
            this.txtSolo.Focus();
            this.lblCount.Text = $"Total Players: { this.pList.TotalPlayers }";
        }

        /// <summary>
        /// Validates user input and adds a solo player to the player list.
        /// </summary>
        private void AddDuo()
        {
            if (String.IsNullOrWhiteSpace(this.txtDuo1.Text) || this.txtDuo1.Text.Length <= 0 || String.IsNullOrWhiteSpace(this.txtDuo2.Text) || this.txtDuo2.Text.Length <= 0)
            {
                return;
            }
            Player teammate = new Player(null, this.txtDuo2.Text, 0);
            var duoPlayer = new Player(teammate, this.txtDuo1.Text, 2);
            this.pList.AddDuo(duoPlayer);
            this.lbCurrentPlayers.Items.Add(duoPlayer.GetPlayerOrDuoNames());
            this.txtDuo1.Clear();
            this.txtDuo2.Clear();
            this.txtDuo1.Select();
            this.txtDuo1.Focus();
            this.lblCount.Text = $"Total Players: { pList.TotalPlayers }";
        }

        /// <summary>
        /// Validates solo and duo counts for the selected team size as well as user input followed by shuffling and ouputing the teams.
        /// </summary>
        private void BuildTeams()
        {
            #region input validation
            if (!Int32.TryParse(txtBuildTeams.Text, out int teamSize))
            {
                MessageBox.Show("Could not read number. (Did you type something other than a number?)", "Error");
                return;
            }
            if (teamSize <= 0)
            {
                MessageBox.Show("Team size cannot be lower than 1.", "Error");
                return;
            }
            if (pList.HasEnoughPlayersForTeamSize(teamSize))
            {
                MessageBox.Show($"There are not enough players to fill all teams.  Add { pList.GetRemainingNumberOfPlayerssForTeamSize(teamSize) } more player(s).", "Error");
                return;
            }
            if (pList.HasEnoughSolosForTeamSize(teamSize))
            {
                MessageBox.Show($"There too many duos in order to create full even teams.  Add { pList.GetRemainingNumberOfSolosForTeamSize(teamSize) } more solo(s).", "Error");
                return;
            }
            #endregion

            // TODO: Change this to get a "Team" data structure that better represents the generated teams.
            IList<Player> playerList = this.pList.BuildTeams(teamSize);
            DialogResult dr = this.sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(this.sfd.FileName))
                {
                    int teamCount = 0;
                    ResetAllBoxes();
                    for (int i = 0; i < this.pList.TotalPlayers; i++)
                    {
                        if (teamSize > 1)
                        {
                            if (i == 0 || i % teamSize == 0)
                            {
                                ++teamCount;
                                this.lbResults.Items.Add($"Team { teamCount }:");
                                sw.WriteLine();
                                sw.WriteLine($"Team { teamCount }:");
                            }
                        }
                        this.lbResults.Items.Add(playerList[i].Name);
                        sw.WriteLine(playerList[i].Name);
                    }
                    sw.Flush();
                }
            }
        }

        /// <summary>
        /// Clears all the boxes so we can run again.
        /// </summary>
        private void ResetAllBoxes()
        {
            this.txtBuildTeams.Clear();
            this.txtDuo1.Clear();
            this.txtDuo2.Clear();
            this.txtSolo.Clear();
            this.lbResults.Items.Clear();
            this.lbCurrentPlayers.Items.Clear();
        }
    }
}
