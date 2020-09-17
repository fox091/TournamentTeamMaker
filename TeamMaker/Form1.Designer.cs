namespace TeamMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnBuildTeams = new System.Windows.Forms.Button();
            this.txtBuildTeams = new System.Windows.Forms.TextBox();
            this.lblBuildTeams = new System.Windows.Forms.Label();
            this.gbDuoQueue = new System.Windows.Forms.GroupBox();
            this.btnDuo = new System.Windows.Forms.Button();
            this.txtDuo2 = new System.Windows.Forms.TextBox();
            this.lblDuo2 = new System.Windows.Forms.Label();
            this.txtDuo1 = new System.Windows.Forms.TextBox();
            this.lblDuo1 = new System.Windows.Forms.Label();
            this.gbSoloQueue = new System.Windows.Forms.GroupBox();
            this.txtSolo = new System.Windows.Forms.TextBox();
            this.btnSolo = new System.Windows.Forms.Button();
            this.lblSolo = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.gbCurrentPlayers = new System.Windows.Forms.GroupBox();
            this.lbCurrentPlayers = new System.Windows.Forms.ListBox();
            this.gbResults.SuspendLayout();
            this.gbDuoQueue.SuspendLayout();
            this.gbSoloQueue.SuspendLayout();
            this.gbCurrentPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lbResults);
            this.gbResults.Location = new System.Drawing.Point(569, 12);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(279, 272);
            this.gbResults.TabIndex = 3;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(9, 25);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(264, 238);
            this.lbResults.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 295);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(387, 300);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(80, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Total Players: 0";
            // 
            // btnBuildTeams
            // 
            this.btnBuildTeams.Location = new System.Drawing.Point(771, 295);
            this.btnBuildTeams.Name = "btnBuildTeams";
            this.btnBuildTeams.Size = new System.Drawing.Size(75, 23);
            this.btnBuildTeams.TabIndex = 2;
            this.btnBuildTeams.TabStop = false;
            this.btnBuildTeams.Text = "Build Teams";
            this.btnBuildTeams.UseVisualStyleBackColor = true;
            this.btnBuildTeams.Click += new System.EventHandler(this.btnBuildTeams_Click);
            // 
            // txtBuildTeams
            // 
            this.txtBuildTeams.Location = new System.Drawing.Point(697, 298);
            this.txtBuildTeams.MaxLength = 3;
            this.txtBuildTeams.Name = "txtBuildTeams";
            this.txtBuildTeams.Size = new System.Drawing.Size(68, 20);
            this.txtBuildTeams.TabIndex = 0;
            this.txtBuildTeams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuildTeams_KeyPress);
            // 
            // lblBuildTeams
            // 
            this.lblBuildTeams.AutoSize = true;
            this.lblBuildTeams.Location = new System.Drawing.Point(631, 301);
            this.lblBuildTeams.Name = "lblBuildTeams";
            this.lblBuildTeams.Size = new System.Drawing.Size(60, 13);
            this.lblBuildTeams.TabIndex = 0;
            this.lblBuildTeams.Text = "Team Size:";
            // 
            // gbDuoQueue
            // 
            this.gbDuoQueue.Controls.Add(this.btnDuo);
            this.gbDuoQueue.Controls.Add(this.txtDuo2);
            this.gbDuoQueue.Controls.Add(this.lblDuo2);
            this.gbDuoQueue.Controls.Add(this.txtDuo1);
            this.gbDuoQueue.Controls.Add(this.lblDuo1);
            this.gbDuoQueue.Location = new System.Drawing.Point(12, 152);
            this.gbDuoQueue.Name = "gbDuoQueue";
            this.gbDuoQueue.Size = new System.Drawing.Size(272, 132);
            this.gbDuoQueue.TabIndex = 1;
            this.gbDuoQueue.TabStop = false;
            this.gbDuoQueue.Text = "Duo Queue";
            // 
            // btnDuo
            // 
            this.btnDuo.Location = new System.Drawing.Point(191, 100);
            this.btnDuo.Name = "btnDuo";
            this.btnDuo.Size = new System.Drawing.Size(75, 23);
            this.btnDuo.TabIndex = 3;
            this.btnDuo.TabStop = false;
            this.btnDuo.Text = "Add";
            this.btnDuo.UseVisualStyleBackColor = true;
            this.btnDuo.Click += new System.EventHandler(this.btnDuo_Click);
            // 
            // txtDuo2
            // 
            this.txtDuo2.Location = new System.Drawing.Point(85, 59);
            this.txtDuo2.MaxLength = 30;
            this.txtDuo2.Name = "txtDuo2";
            this.txtDuo2.Size = new System.Drawing.Size(181, 20);
            this.txtDuo2.TabIndex = 1;
            this.txtDuo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuo2_KeyPress);
            // 
            // lblDuo2
            // 
            this.lblDuo2.AutoSize = true;
            this.lblDuo2.Location = new System.Drawing.Point(6, 62);
            this.lblDuo2.Name = "lblDuo2";
            this.lblDuo2.Size = new System.Drawing.Size(73, 13);
            this.lblDuo2.TabIndex = 2;
            this.lblDuo2.Text = "Player Name: ";
            // 
            // txtDuo1
            // 
            this.txtDuo1.Location = new System.Drawing.Point(85, 27);
            this.txtDuo1.MaxLength = 30;
            this.txtDuo1.Name = "txtDuo1";
            this.txtDuo1.Size = new System.Drawing.Size(181, 20);
            this.txtDuo1.TabIndex = 0;
            this.txtDuo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuo1_KeyPress);
            // 
            // lblDuo1
            // 
            this.lblDuo1.AutoSize = true;
            this.lblDuo1.Location = new System.Drawing.Point(6, 30);
            this.lblDuo1.Name = "lblDuo1";
            this.lblDuo1.Size = new System.Drawing.Size(73, 13);
            this.lblDuo1.TabIndex = 0;
            this.lblDuo1.Text = "Player Name: ";
            // 
            // gbSoloQueue
            // 
            this.gbSoloQueue.Controls.Add(this.txtSolo);
            this.gbSoloQueue.Controls.Add(this.btnSolo);
            this.gbSoloQueue.Controls.Add(this.lblSolo);
            this.gbSoloQueue.Location = new System.Drawing.Point(12, 12);
            this.gbSoloQueue.Name = "gbSoloQueue";
            this.gbSoloQueue.Size = new System.Drawing.Size(272, 132);
            this.gbSoloQueue.TabIndex = 0;
            this.gbSoloQueue.TabStop = false;
            this.gbSoloQueue.Text = "Solo Queue";
            // 
            // txtSolo
            // 
            this.txtSolo.Location = new System.Drawing.Point(86, 27);
            this.txtSolo.MaxLength = 30;
            this.txtSolo.Name = "txtSolo";
            this.txtSolo.Size = new System.Drawing.Size(180, 20);
            this.txtSolo.TabIndex = 0;
            this.txtSolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSolo_KeyPress);
            // 
            // btnSolo
            // 
            this.btnSolo.Location = new System.Drawing.Point(191, 95);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(75, 23);
            this.btnSolo.TabIndex = 0;
            this.btnSolo.TabStop = false;
            this.btnSolo.Text = "Add";
            this.btnSolo.UseVisualStyleBackColor = true;
            this.btnSolo.Click += new System.EventHandler(this.btnSolo_Click);
            // 
            // lblSolo
            // 
            this.lblSolo.AutoSize = true;
            this.lblSolo.Location = new System.Drawing.Point(7, 30);
            this.lblSolo.Name = "lblSolo";
            this.lblSolo.Size = new System.Drawing.Size(73, 13);
            this.lblSolo.TabIndex = 1;
            this.lblSolo.Text = "Player Name: ";
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "txt";
            this.sfd.Filter = "Text FIles|*.txt";
            // 
            // gbCurrentPlayers
            // 
            this.gbCurrentPlayers.Controls.Add(this.lbCurrentPlayers);
            this.gbCurrentPlayers.Location = new System.Drawing.Point(292, 12);
            this.gbCurrentPlayers.Name = "gbCurrentPlayers";
            this.gbCurrentPlayers.Size = new System.Drawing.Size(271, 272);
            this.gbCurrentPlayers.TabIndex = 4;
            this.gbCurrentPlayers.TabStop = false;
            this.gbCurrentPlayers.Text = "Current Players";
            // 
            // lbCurrentPlayers
            // 
            this.lbCurrentPlayers.FormattingEnabled = true;
            this.lbCurrentPlayers.Location = new System.Drawing.Point(9, 25);
            this.lbCurrentPlayers.Name = "lbCurrentPlayers";
            this.lbCurrentPlayers.Size = new System.Drawing.Size(256, 238);
            this.lbCurrentPlayers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 330);
            this.Controls.Add(this.btnBuildTeams);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbCurrentPlayers);
            this.Controls.Add(this.txtBuildTeams);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblBuildTeams);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbDuoQueue);
            this.Controls.Add(this.gbSoloQueue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Maker";
            this.gbResults.ResumeLayout(false);
            this.gbDuoQueue.ResumeLayout(false);
            this.gbDuoQueue.PerformLayout();
            this.gbSoloQueue.ResumeLayout(false);
            this.gbSoloQueue.PerformLayout();
            this.gbCurrentPlayers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnBuildTeams;
        private System.Windows.Forms.TextBox txtBuildTeams;
        private System.Windows.Forms.Label lblBuildTeams;
        private System.Windows.Forms.GroupBox gbDuoQueue;
        private System.Windows.Forms.Button btnDuo;
        private System.Windows.Forms.TextBox txtDuo2;
        private System.Windows.Forms.Label lblDuo2;
        private System.Windows.Forms.TextBox txtDuo1;
        private System.Windows.Forms.Label lblDuo1;
        private System.Windows.Forms.GroupBox gbSoloQueue;
        private System.Windows.Forms.TextBox txtSolo;
        private System.Windows.Forms.Button btnSolo;
        private System.Windows.Forms.Label lblSolo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.GroupBox gbCurrentPlayers;
        private System.Windows.Forms.ListBox lbCurrentPlayers;
    }
}

