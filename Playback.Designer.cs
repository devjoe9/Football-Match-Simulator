namespace Football_Match_Simulator
{
    partial class formPlayback
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
            this.components = new System.ComponentModel.Container();
            this.buttonStartPlayback = new System.Windows.Forms.Button();
            this.clockMatch = new System.Windows.Forms.Timer(this.components);
            this.labelHTeam = new System.Windows.Forms.Label();
            this.labelATeam = new System.Windows.Forms.Label();
            this.labelHGoals = new System.Windows.Forms.Label();
            this.labelMatchClock = new System.Windows.Forms.Label();
            this.panelMatchDisplay = new System.Windows.Forms.Panel();
            this.labelAGoals = new System.Windows.Forms.Label();
            this.labelGoal = new System.Windows.Forms.Label();
            this.clockGoalPause = new System.Windows.Forms.Timer(this.components);
            this.labelHalfTime = new System.Windows.Forms.Label();
            this.clockHalfTimePause = new System.Windows.Forms.Timer(this.components);
            this.labelFullTime = new System.Windows.Forms.Label();
            this.buttonGoToResults = new System.Windows.Forms.Button();
            this.helpPlayback = new System.Windows.Forms.HelpProvider();
            this.panelMatchDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartPlayback
            // 
            this.buttonStartPlayback.BackColor = System.Drawing.Color.White;
            this.buttonStartPlayback.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartPlayback.Location = new System.Drawing.Point(516, 237);
            this.buttonStartPlayback.Name = "buttonStartPlayback";
            this.buttonStartPlayback.Size = new System.Drawing.Size(153, 86);
            this.buttonStartPlayback.TabIndex = 5;
            this.buttonStartPlayback.Text = "Begin match";
            this.buttonStartPlayback.UseVisualStyleBackColor = false;
            this.buttonStartPlayback.Click += new System.EventHandler(this.buttonStartPlayback_Click);
            // 
            // clockMatch
            // 
            this.clockMatch.Interval = 200;
            this.clockMatch.Tick += new System.EventHandler(this.clockMatch_Tick);
            // 
            // labelHTeam
            // 
            this.labelHTeam.AutoSize = true;
            this.labelHTeam.BackColor = System.Drawing.Color.White;
            this.labelHTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHTeam.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHTeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHTeam.Location = new System.Drawing.Point(7, 23);
            this.labelHTeam.Name = "labelHTeam";
            this.labelHTeam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHTeam.Size = new System.Drawing.Size(63, 32);
            this.labelHTeam.TabIndex = 6;
            this.labelHTeam.Text = "ABC";
            // 
            // labelATeam
            // 
            this.labelATeam.AutoSize = true;
            this.labelATeam.BackColor = System.Drawing.Color.White;
            this.labelATeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelATeam.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelATeam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelATeam.Location = new System.Drawing.Point(152, 23);
            this.labelATeam.Name = "labelATeam";
            this.labelATeam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelATeam.Size = new System.Drawing.Size(60, 32);
            this.labelATeam.TabIndex = 7;
            this.labelATeam.Text = "DEF";
            // 
            // labelHGoals
            // 
            this.labelHGoals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHGoals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHGoals.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHGoals.ForeColor = System.Drawing.Color.White;
            this.helpPlayback.SetHelpString(this.labelHGoals, "The number of goals that the home team has scored so far");
            this.labelHGoals.Location = new System.Drawing.Point(76, 23);
            this.labelHGoals.Name = "labelHGoals";
            this.helpPlayback.SetShowHelp(this.labelHGoals, true);
            this.labelHGoals.Size = new System.Drawing.Size(29, 32);
            this.labelHGoals.TabIndex = 8;
            this.labelHGoals.Text = "0";
            // 
            // labelMatchClock
            // 
            this.labelMatchClock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMatchClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMatchClock.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchClock.ForeColor = System.Drawing.Color.White;
            this.helpPlayback.SetHelpString(this.labelMatchClock, "An accelerated 90 minute clock representative of one in a real-life football matc" +
        "h.");
            this.labelMatchClock.Location = new System.Drawing.Point(76, 64);
            this.labelMatchClock.Name = "labelMatchClock";
            this.helpPlayback.SetShowHelp(this.labelMatchClock, true);
            this.labelMatchClock.Size = new System.Drawing.Size(70, 32);
            this.labelMatchClock.TabIndex = 9;
            this.labelMatchClock.Text = "0";
            this.labelMatchClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMatchDisplay
            // 
            this.panelMatchDisplay.BackColor = System.Drawing.Color.Transparent;
            this.panelMatchDisplay.Controls.Add(this.labelAGoals);
            this.panelMatchDisplay.Controls.Add(this.labelHGoals);
            this.panelMatchDisplay.Controls.Add(this.labelMatchClock);
            this.panelMatchDisplay.Controls.Add(this.labelHTeam);
            this.panelMatchDisplay.Controls.Add(this.labelATeam);
            this.panelMatchDisplay.Location = new System.Drawing.Point(479, 61);
            this.panelMatchDisplay.Name = "panelMatchDisplay";
            this.panelMatchDisplay.Size = new System.Drawing.Size(219, 100);
            this.panelMatchDisplay.TabIndex = 10;
            this.panelMatchDisplay.Visible = false;
            this.panelMatchDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMatchDisplay_Paint);
            // 
            // labelAGoals
            // 
            this.labelAGoals.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAGoals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAGoals.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAGoals.ForeColor = System.Drawing.Color.White;
            this.helpPlayback.SetHelpString(this.labelAGoals, "The number of goals that the away team has scored so far");
            this.labelAGoals.Location = new System.Drawing.Point(117, 23);
            this.labelAGoals.Name = "labelAGoals";
            this.helpPlayback.SetShowHelp(this.labelAGoals, true);
            this.labelAGoals.Size = new System.Drawing.Size(29, 32);
            this.labelAGoals.TabIndex = 10;
            this.labelAGoals.Text = "0";
            // 
            // labelGoal
            // 
            this.labelGoal.BackColor = System.Drawing.Color.Transparent;
            this.labelGoal.Font = new System.Drawing.Font("Stencil", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoal.ForeColor = System.Drawing.Color.Gold;
            this.labelGoal.Location = new System.Drawing.Point(479, 248);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(219, 75);
            this.labelGoal.TabIndex = 0;
            this.labelGoal.Text = "GOAL!!";
            this.labelGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGoal.Visible = false;
            this.labelGoal.Click += new System.EventHandler(this.labelGoal_Click);
            // 
            // clockGoalPause
            // 
            this.clockGoalPause.Interval = 2000;
            this.clockGoalPause.Tick += new System.EventHandler(this.clockGoalPause_Tick);
            // 
            // labelHalfTime
            // 
            this.labelHalfTime.BackColor = System.Drawing.Color.Transparent;
            this.labelHalfTime.Font = new System.Drawing.Font("Stencil", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHalfTime.ForeColor = System.Drawing.Color.Gold;
            this.labelHalfTime.Location = new System.Drawing.Point(390, 248);
            this.labelHalfTime.Name = "labelHalfTime";
            this.labelHalfTime.Size = new System.Drawing.Size(400, 75);
            this.labelHalfTime.TabIndex = 11;
            this.labelHalfTime.Text = "Half-time";
            this.labelHalfTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHalfTime.Visible = false;
            // 
            // clockHalfTimePause
            // 
            this.clockHalfTimePause.Interval = 3000;
            this.clockHalfTimePause.Tick += new System.EventHandler(this.clockHalfTimePause_Tick);
            // 
            // labelFullTime
            // 
            this.labelFullTime.BackColor = System.Drawing.Color.Transparent;
            this.labelFullTime.Font = new System.Drawing.Font("Stencil", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullTime.ForeColor = System.Drawing.Color.Gold;
            this.helpPlayback.SetHelpString(this.labelFullTime, "A football match is played for 90 minutes. Full-time means the 90 minutes have be" +
        "en played and that the match is over");
            this.labelFullTime.Location = new System.Drawing.Point(395, 256);
            this.labelFullTime.Name = "labelFullTime";
            this.helpPlayback.SetShowHelp(this.labelFullTime, true);
            this.labelFullTime.Size = new System.Drawing.Size(395, 75);
            this.labelFullTime.TabIndex = 12;
            this.labelFullTime.Text = "Full-time";
            this.labelFullTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFullTime.Visible = false;
            // 
            // buttonGoToResults
            // 
            this.buttonGoToResults.BackColor = System.Drawing.Color.White;
            this.buttonGoToResults.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToResults.Location = new System.Drawing.Point(516, 393);
            this.buttonGoToResults.Name = "buttonGoToResults";
            this.buttonGoToResults.Size = new System.Drawing.Size(153, 86);
            this.buttonGoToResults.TabIndex = 13;
            this.buttonGoToResults.Text = "Go to results";
            this.buttonGoToResults.UseVisualStyleBackColor = false;
            this.buttonGoToResults.Visible = false;
            this.buttonGoToResults.Click += new System.EventHandler(this.buttonGoToResults_Click);
            // 
            // formPlayback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonGoToResults);
            this.Controls.Add(this.labelFullTime);
            this.Controls.Add(this.labelHalfTime);
            this.Controls.Add(this.labelGoal);
            this.Controls.Add(this.panelMatchDisplay);
            this.Controls.Add(this.buttonStartPlayback);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPlayback";
            this.Text = "PlaybackScreen";
            this.Load += new System.EventHandler(this.formPlayback_Load);
            this.panelMatchDisplay.ResumeLayout(false);
            this.panelMatchDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartPlayback;
        private System.Windows.Forms.Timer clockMatch;
        private System.Windows.Forms.Label labelHTeam;
        private System.Windows.Forms.Label labelATeam;
        private System.Windows.Forms.Label labelHGoals;
        private System.Windows.Forms.Label labelMatchClock;
        private System.Windows.Forms.Panel panelMatchDisplay;
        private System.Windows.Forms.Label labelAGoals;
        private System.Windows.Forms.Label labelGoal;
        private System.Windows.Forms.Timer clockGoalPause;
        private System.Windows.Forms.Label labelHalfTime;
        private System.Windows.Forms.Timer clockHalfTimePause;
        private System.Windows.Forms.Label labelFullTime;
        private System.Windows.Forms.Button buttonGoToResults;
        private System.Windows.Forms.HelpProvider helpPlayback;
    }
}