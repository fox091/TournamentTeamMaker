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
            this.gbBuildTeams = new System.Windows.Forms.GroupBox();
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
            this.gbResults.SuspendLayout();
            this.gbBuildTeams.SuspendLayout();
            this.gbDuoQueue.SuspendLayout();
            this.gbSoloQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lbResults);
            this.gbResults.Location = new System.Drawing.Point(227, 152);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(200, 160);
            this.gbResults.TabIndex = 3;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(9, 25);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(176, 121);
            this.lbResults.TabIndex = 0;
            // 
            // gbBuildTeams
            // 
            this.gbBuildTeams.Controls.Add(this.btnReset);
            this.gbBuildTeams.Controls.Add(this.lblCount);
            this.gbBuildTeams.Controls.Add(this.btnBuildTeams);
            this.gbBuildTeams.Controls.Add(this.txtBuildTeams);
            this.gbBuildTeams.Controls.Add(this.lblBuildTeams);
            this.gbBuildTeams.Location = new System.Drawing.Point(21, 150);
            this.gbBuildTeams.Name = "gbBuildTeams";
            this.gbBuildTeams.Size = new System.Drawing.Size(200, 162);
            this.gbBuildTeams.TabIndex = 2;
            this.gbBuildTeams.TabStop = false;
            this.gbBuildTeams.Text = "Build Teams";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 125);
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
            this.lblCount.Location = new System.Drawing.Point(97, 92);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(80, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Total Players: 0";
            // 
            // btnBuildTeams
            // 
            this.btnBuildTeams.Location = new System.Drawing.Point(111, 125);
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
            this.txtBuildTeams.Location = new System.Drawing.Point(86, 27);
            this.txtBuildTeams.MaxLength = 3;
            this.txtBuildTeams.Name = "txtBuildTeams";
            this.txtBuildTeams.Size = new System.Drawing.Size(100, 20);
            this.txtBuildTeams.TabIndex = 0;
            this.txtBuildTeams.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuildTeams_KeyPress);
            // 
            // lblBuildTeams
            // 
            this.lblBuildTeams.AutoSize = true;
            this.lblBuildTeams.Location = new System.Drawing.Point(6, 34);
            this.lblBuildTeams.Name = "lblBuildTeams";
            this.lblBuildTeams.Size = new System.Drawing.Size(63, 13);
            this.lblBuildTeams.TabIndex = 0;
            this.lblBuildTeams.Text = "Team Size: ";
            // 
            // gbDuoQueue
            // 
            this.gbDuoQueue.Controls.Add(this.btnDuo);
            this.gbDuoQueue.Controls.Add(this.txtDuo2);
            this.gbDuoQueue.Controls.Add(this.lblDuo2);
            this.gbDuoQueue.Controls.Add(this.txtDuo1);
            this.gbDuoQueue.Controls.Add(this.lblDuo1);
            this.gbDuoQueue.Location = new System.Drawing.Point(227, 12);
            this.gbDuoQueue.Name = "gbDuoQueue";
            this.gbDuoQueue.Size = new System.Drawing.Size(200, 132);
            this.gbDuoQueue.TabIndex = 1;
            this.gbDuoQueue.TabStop = false;
            this.gbDuoQueue.Text = "Duo Queue";
            // 
            // btnDuo
            // 
            this.btnDuo.Location = new System.Drawing.Point(110, 95);
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
            this.txtDuo2.Size = new System.Drawing.Size(100, 20);
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
            this.txtDuo1.Size = new System.Drawing.Size(100, 20);
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
            this.gbSoloQueue.Location = new System.Drawing.Point(21, 12);
            this.gbSoloQueue.Name = "gbSoloQueue";
            this.gbSoloQueue.Size = new System.Drawing.Size(200, 132);
            this.gbSoloQueue.TabIndex = 0;
            this.gbSoloQueue.TabStop = false;
            this.gbSoloQueue.Text = "Solo Queue";
            // 
            // txtSolo
            // 
            this.txtSolo.Location = new System.Drawing.Point(86, 27);
            this.txtSolo.MaxLength = 30;
            this.txtSolo.Name = "txtSolo";
            this.txtSolo.Size = new System.Drawing.Size(100, 20);
            this.txtSolo.TabIndex = 0;
            this.txtSolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSolo_KeyPress);
            // 
            // btnSolo
            // 
            this.btnSolo.Location = new System.Drawing.Point(111, 95);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 324);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbBuildTeams);
            this.Controls.Add(this.gbDuoQueue);
            this.Controls.Add(this.gbSoloQueue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Maker";
            this.gbResults.ResumeLayout(false);
            this.gbBuildTeams.ResumeLayout(false);
            this.gbBuildTeams.PerformLayout();
            this.gbDuoQueue.ResumeLayout(false);
            this.gbDuoQueue.PerformLayout();
            this.gbSoloQueue.ResumeLayout(false);
            this.gbSoloQueue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.GroupBox gbBuildTeams;
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
    }
}

