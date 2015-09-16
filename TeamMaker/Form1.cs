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
            if (!Int32.TryParse(txtBuildTeams.Text, out teamSize))
            {
                MessageBox.Show("Could not read number. (Did you type something other than a number?)", "Error");
            }
            if (teamSize <= 0) 
            {
                MessageBox.Show("Team size cannot be lower than 1.", "Error");
            }

        }
    }
}
