using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace TeamMaker
{
    public partial class Form1 : Form
    {
        private PlayerList PlayerList;

        public Form1()
        {
            this.InitializeComponent();
            this.PlayerList = new PlayerList();
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
                PlayerList = new PlayerList();
                ResetAllBoxes();
                lblCount.Text = $"Total Players: { PlayerList.TotalPlayers }";
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
            this.PlayerList.AddSolo(soloPlayer);
            this.txtSolo.Clear();
            this.txtSolo.Select();
            this.txtSolo.Focus();
            this.lblCount.Text = $"Total Players: { this.PlayerList.TotalPlayers }";
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
            this.PlayerList.AddDuo(duoPlayer);
            this.lbCurrentPlayers.Items.Add(duoPlayer.GetPlayerOrDuoNames());
            this.txtDuo1.Clear();
            this.txtDuo2.Clear();
            this.txtDuo1.Select();
            this.txtDuo1.Focus();
            this.lblCount.Text = $"Total Players: { PlayerList.TotalPlayers }";
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
            if (PlayerList.HasEnoughPlayersForTeamSize(teamSize))
            {
                MessageBox.Show($"There are not enough players to fill all teams.  Add { PlayerList.GetRemainingNumberOfPlayerssForTeamSize(teamSize) } more player(s).", "Error");
                return;
            }
            if (PlayerList.HasEnoughSolosForTeamSize(teamSize))
            {
                MessageBox.Show($"There too many duos in order to create full even teams.  Add { PlayerList.GetRemainingNumberOfSolosForTeamSize(teamSize) } more solo(s).", "Error");
                return;
            }
            #endregion
            int teamNumber;
            ResetAllBoxes();
            IEnumerable<Team> teamList = this.PlayerList.BuildTeams(teamSize);

            var confirmResult = MessageBox.Show("Would you like to save the results to a text file?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DialogResult dr = this.sfd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(this.sfd.FileName))
                    {
                        teamNumber = 1;
                        foreach (var team in teamList)
                        {
                            if (teamNumber != 1)
                            {
                                sw.WriteLine();
                            }

                            sw.WriteLine($"Team { teamNumber }:");

                            foreach (var player in team.Players)
                            {
                                sw.WriteLine(player.Name);
                            }
                            teamNumber++;
                        }
                        sw.Flush();
                    }
                }
            }
            // Write to the list box no matter what.
            teamNumber = 1;
            foreach (var team in teamList)
            {
                if (teamNumber != 1)
                {
                    this.lbResults.Items.Add("");
                }

                this.lbResults.Items.Add($"Team { teamNumber }:");

                foreach (var player in team.Players)
                {
                    this.lbResults.Items.Add(player.Name);
                }
                teamNumber++;
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
