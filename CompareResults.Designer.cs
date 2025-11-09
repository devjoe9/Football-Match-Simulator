namespace Football_Match_Simulator
{
    partial class formCompareResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompareResults));
            this.labelTitleScreen = new System.Windows.Forms.Label();
            this.labelTitleLeague = new System.Windows.Forms.Label();
            this.labelTitleTeam1 = new System.Windows.Forms.Label();
            this.panelTeamsAndGetResults = new System.Windows.Forms.Panel();
            this.labelVs = new System.Windows.Forms.Label();
            this.buttonGetResults = new System.Windows.Forms.Button();
            this.comboBoxSelectTeam2 = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectTeam1 = new System.Windows.Forms.ComboBox();
            this.labelTitleTeam2 = new System.Windows.Forms.Label();
            this.panelLeague = new System.Windows.Forms.Panel();
            this.comboBoxSelectLeague = new System.Windows.Forms.ComboBox();
            this.dataGridRealResults = new System.Windows.Forms.DataGridView();
            this.colRealHTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealATeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScoreline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealHXG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRealAXG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatePlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridSimResults = new System.Windows.Forms.DataGridView();
            this.colDetailsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colResultID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSimHTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSimATeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1stScoreline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSimHXG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSimAXG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumSims = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateSimmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitleRealResults = new System.Windows.Forms.Label();
            this.labelTitleSimResults = new System.Windows.Forms.Label();
            this.panelRealResults = new System.Windows.Forms.Panel();
            this.panelSimResults = new System.Windows.Forms.Panel();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.helpCompareResults = new System.Windows.Forms.HelpProvider();
            this.panelTeamsAndGetResults.SuspendLayout();
            this.panelLeague.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRealResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSimResults)).BeginInit();
            this.panelRealResults.SuspendLayout();
            this.panelSimResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleScreen
            // 
            this.labelTitleScreen.AutoSize = true;
            this.labelTitleScreen.BackColor = System.Drawing.Color.White;
            this.labelTitleScreen.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleScreen.Location = new System.Drawing.Point(341, 18);
            this.labelTitleScreen.Name = "labelTitleScreen";
            this.labelTitleScreen.Size = new System.Drawing.Size(503, 41);
            this.labelTitleScreen.TabIndex = 6;
            this.labelTitleScreen.Text = "FOOTBALL MATCH SIMULATOR";
            // 
            // labelTitleLeague
            // 
            this.labelTitleLeague.AutoSize = true;
            this.labelTitleLeague.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCompareResults.SetHelpString(this.labelTitleLeague, "A league is a group of football teams that compete with each other over a period " +
        "of time for a championship");
            this.labelTitleLeague.Location = new System.Drawing.Point(29, 16);
            this.labelTitleLeague.Name = "labelTitleLeague";
            this.helpCompareResults.SetShowHelp(this.labelTitleLeague, true);
            this.labelTitleLeague.Size = new System.Drawing.Size(55, 16);
            this.labelTitleLeague.TabIndex = 51;
            this.labelTitleLeague.Text = "League";
            // 
            // labelTitleTeam1
            // 
            this.labelTitleTeam1.AutoSize = true;
            this.labelTitleTeam1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCompareResults.SetHelpString(this.labelTitleTeam1, resources.GetString("labelTitleTeam1.HelpString"));
            this.labelTitleTeam1.Location = new System.Drawing.Point(-3, 1);
            this.labelTitleTeam1.Name = "labelTitleTeam1";
            this.helpCompareResults.SetShowHelp(this.labelTitleTeam1, true);
            this.labelTitleTeam1.Size = new System.Drawing.Size(56, 16);
            this.labelTitleTeam1.TabIndex = 8;
            this.labelTitleTeam1.Text = "Team 1";
            // 
            // panelTeamsAndGetResults
            // 
            this.panelTeamsAndGetResults.Controls.Add(this.labelVs);
            this.panelTeamsAndGetResults.Controls.Add(this.buttonGetResults);
            this.panelTeamsAndGetResults.Controls.Add(this.comboBoxSelectTeam2);
            this.panelTeamsAndGetResults.Controls.Add(this.comboBoxSelectTeam1);
            this.panelTeamsAndGetResults.Controls.Add(this.labelTitleTeam1);
            this.panelTeamsAndGetResults.Controls.Add(this.labelTitleTeam2);
            this.panelTeamsAndGetResults.Location = new System.Drawing.Point(433, 138);
            this.panelTeamsAndGetResults.Name = "panelTeamsAndGetResults";
            this.panelTeamsAndGetResults.Size = new System.Drawing.Size(319, 185);
            this.panelTeamsAndGetResults.TabIndex = 52;
            this.panelTeamsAndGetResults.Visible = false;
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCompareResults.SetHelpString(this.labelVs, "A league is a group of football teams that compete with each other over a period " +
        "of time for a championship");
            this.labelVs.Location = new System.Drawing.Point(147, 21);
            this.labelVs.Name = "labelVs";
            this.helpCompareResults.SetShowHelp(this.labelVs, true);
            this.labelVs.Size = new System.Drawing.Size(22, 16);
            this.labelVs.TabIndex = 52;
            this.labelVs.Text = "vs";
            // 
            // buttonGetResults
            // 
            this.buttonGetResults.BackColor = System.Drawing.Color.White;
            this.buttonGetResults.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCompareResults.SetHelpString(this.buttonGetResults, "When pressed, displays the real and simulated results involving the seleted team(" +
        "s)");
            this.buttonGetResults.Location = new System.Drawing.Point(83, 99);
            this.buttonGetResults.Name = "buttonGetResults";
            this.helpCompareResults.SetShowHelp(this.buttonGetResults, true);
            this.buttonGetResults.Size = new System.Drawing.Size(153, 86);
            this.buttonGetResults.TabIndex = 53;
            this.buttonGetResults.Text = "Get real and simulated results";
            this.buttonGetResults.UseVisualStyleBackColor = false;
            this.buttonGetResults.Click += new System.EventHandler(this.buttonGetResults_Click);
            // 
            // comboBoxSelectTeam2
            // 
            this.comboBoxSelectTeam2.BackColor = System.Drawing.Color.White;
            this.comboBoxSelectTeam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectTeam2.FormattingEnabled = true;
            this.helpCompareResults.SetHelpString(this.comboBoxSelectTeam2, "Select a team from the drop-down menu");
            this.comboBoxSelectTeam2.Location = new System.Drawing.Point(198, 20);
            this.comboBoxSelectTeam2.Name = "comboBoxSelectTeam2";
            this.helpCompareResults.SetShowHelp(this.comboBoxSelectTeam2, true);
            this.comboBoxSelectTeam2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectTeam2.TabIndex = 9;
            // 
            // comboBoxSelectTeam1
            // 
            this.comboBoxSelectTeam1.BackColor = System.Drawing.Color.White;
            this.comboBoxSelectTeam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectTeam1.FormattingEnabled = true;
            this.helpCompareResults.SetHelpString(this.comboBoxSelectTeam1, "Select a team from the drop-down menu");
            this.comboBoxSelectTeam1.Location = new System.Drawing.Point(0, 20);
            this.comboBoxSelectTeam1.Name = "comboBoxSelectTeam1";
            this.helpCompareResults.SetShowHelp(this.comboBoxSelectTeam1, true);
            this.comboBoxSelectTeam1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectTeam1.TabIndex = 7;
            // 
            // labelTitleTeam2
            // 
            this.labelTitleTeam2.AutoSize = true;
            this.labelTitleTeam2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCompareResults.SetHelpString(this.labelTitleTeam2, resources.GetString("labelTitleTeam2.HelpString"));
            this.labelTitleTeam2.Location = new System.Drawing.Point(263, 1);
            this.labelTitleTeam2.Name = "labelTitleTeam2";
            this.helpCompareResults.SetShowHelp(this.labelTitleTeam2, true);
            this.labelTitleTeam2.Size = new System.Drawing.Size(56, 16);
            this.labelTitleTeam2.TabIndex = 10;
            this.labelTitleTeam2.Text = "Team 2";
            // 
            // panelLeague
            // 
            this.panelLeague.Controls.Add(this.labelTitleLeague);
            this.panelLeague.Controls.Add(this.comboBoxSelectLeague);
            this.panelLeague.Location = new System.Drawing.Point(536, 62);
            this.panelLeague.Name = "panelLeague";
            this.panelLeague.Size = new System.Drawing.Size(121, 57);
            this.panelLeague.TabIndex = 53;
            // 
            // comboBoxSelectLeague
            // 
            this.comboBoxSelectLeague.BackColor = System.Drawing.Color.White;
            this.comboBoxSelectLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectLeague.FormattingEnabled = true;
            this.helpCompareResults.SetHelpString(this.comboBoxSelectLeague, "Select a league from the drop-down menu");
            this.comboBoxSelectLeague.Location = new System.Drawing.Point(0, 35);
            this.comboBoxSelectLeague.Name = "comboBoxSelectLeague";
            this.helpCompareResults.SetShowHelp(this.comboBoxSelectLeague, true);
            this.comboBoxSelectLeague.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectLeague.TabIndex = 50;
            this.comboBoxSelectLeague.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectLeague_SelectedIndexChanged);
            // 
            // dataGridRealResults
            // 
            this.dataGridRealResults.AllowUserToAddRows = false;
            this.dataGridRealResults.AllowUserToDeleteRows = false;
            this.dataGridRealResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRealResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRealHTeam,
            this.colRealATeam,
            this.colScoreline,
            this.colRealHXG,
            this.colRealAXG,
            this.colDatePlayed});
            this.helpCompareResults.SetHelpString(this.dataGridRealResults, resources.GetString("dataGridRealResults.HelpString"));
            this.dataGridRealResults.Location = new System.Drawing.Point(0, 42);
            this.dataGridRealResults.Name = "dataGridRealResults";
            this.dataGridRealResults.RowHeadersVisible = false;
            this.helpCompareResults.SetShowHelp(this.dataGridRealResults, true);
            this.dataGridRealResults.Size = new System.Drawing.Size(412, 294);
            this.dataGridRealResults.TabIndex = 54;
            // 
            // colRealHTeam
            // 
            this.colRealHTeam.HeaderText = "Home team";
            this.colRealHTeam.Name = "colRealHTeam";
            this.colRealHTeam.ReadOnly = true;
            // 
            // colRealATeam
            // 
            this.colRealATeam.HeaderText = "Away team";
            this.colRealATeam.Name = "colRealATeam";
            this.colRealATeam.ReadOnly = true;
            // 
            // colScoreline
            // 
            this.colScoreline.HeaderText = "Score-line";
            this.colScoreline.Name = "colScoreline";
            this.colScoreline.ReadOnly = true;
            // 
            // colRealHXG
            // 
            this.colRealHXG.HeaderText = "Home xG";
            this.colRealHXG.Name = "colRealHXG";
            this.colRealHXG.ReadOnly = true;
            // 
            // colRealAXG
            // 
            this.colRealAXG.HeaderText = "Away xG";
            this.colRealAXG.Name = "colRealAXG";
            this.colRealAXG.ReadOnly = true;
            // 
            // colDatePlayed
            // 
            this.colDatePlayed.HeaderText = "Date played";
            this.colDatePlayed.Name = "colDatePlayed";
            this.colDatePlayed.ReadOnly = true;
            // 
            // dataGridSimResults
            // 
            this.dataGridSimResults.AllowUserToAddRows = false;
            this.dataGridSimResults.AllowUserToDeleteRows = false;
            this.dataGridSimResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSimResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailsButton,
            this.colResultID,
            this.colSimHTeam,
            this.colSimATeam,
            this.col1stScoreline,
            this.colSimHXG,
            this.colSimAXG,
            this.colNumSims,
            this.colDateSimmed});
            this.helpCompareResults.SetHelpString(this.dataGridSimResults, resources.GetString("dataGridSimResults.HelpString"));
            this.dataGridSimResults.Location = new System.Drawing.Point(0, 42);
            this.dataGridSimResults.Name = "dataGridSimResults";
            this.dataGridSimResults.RowHeadersVisible = false;
            this.helpCompareResults.SetShowHelp(this.dataGridSimResults, true);
            this.dataGridSimResults.Size = new System.Drawing.Size(412, 294);
            this.dataGridSimResults.TabIndex = 55;
            this.dataGridSimResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSimResults_CellContentClick);
            // 
            // colDetailsButton
            // 
            this.colDetailsButton.HeaderText = "See details";
            this.colDetailsButton.Name = "colDetailsButton";
            this.colDetailsButton.ReadOnly = true;
            this.colDetailsButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDetailsButton.Width = 45;
            // 
            // colResultID
            // 
            this.colResultID.HeaderText = "ResultID";
            this.colResultID.Name = "colResultID";
            this.colResultID.ReadOnly = true;
            this.colResultID.Visible = false;
            // 
            // colSimHTeam
            // 
            this.colSimHTeam.HeaderText = "Home team";
            this.colSimHTeam.Name = "colSimHTeam";
            this.colSimHTeam.ReadOnly = true;
            // 
            // colSimATeam
            // 
            this.colSimATeam.HeaderText = "Away team";
            this.colSimATeam.Name = "colSimATeam";
            this.colSimATeam.ReadOnly = true;
            // 
            // col1stScoreline
            // 
            this.col1stScoreline.HeaderText = "Most likely score-line";
            this.col1stScoreline.Name = "col1stScoreline";
            this.col1stScoreline.ReadOnly = true;
            // 
            // colSimHXG
            // 
            this.colSimHXG.HeaderText = "Home xG";
            this.colSimHXG.Name = "colSimHXG";
            this.colSimHXG.ReadOnly = true;
            // 
            // colSimAXG
            // 
            this.colSimAXG.HeaderText = "Away xG";
            this.colSimAXG.Name = "colSimAXG";
            this.colSimAXG.ReadOnly = true;
            // 
            // colNumSims
            // 
            this.colNumSims.HeaderText = "No. of simulations run";
            this.colNumSims.Name = "colNumSims";
            this.colNumSims.ReadOnly = true;
            // 
            // colDateSimmed
            // 
            this.colDateSimmed.HeaderText = "Date simulated";
            this.colDateSimmed.Name = "colDateSimmed";
            this.colDateSimmed.ReadOnly = true;
            // 
            // labelTitleRealResults
            // 
            this.labelTitleRealResults.BackColor = System.Drawing.Color.White;
            this.labelTitleRealResults.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpCompareResults.SetHelpString(this.labelTitleRealResults, "\'Real results\' refers to matches that have already happened in real life");
            this.labelTitleRealResults.Location = new System.Drawing.Point(0, 25);
            this.labelTitleRealResults.Name = "labelTitleRealResults";
            this.helpCompareResults.SetShowHelp(this.labelTitleRealResults, true);
            this.labelTitleRealResults.Size = new System.Drawing.Size(412, 17);
            this.labelTitleRealResults.TabIndex = 60;
            this.labelTitleRealResults.Text = "Real results";
            this.labelTitleRealResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleSimResults
            // 
            this.labelTitleSimResults.BackColor = System.Drawing.Color.White;
            this.labelTitleSimResults.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSimResults.Location = new System.Drawing.Point(0, 25);
            this.labelTitleSimResults.Name = "labelTitleSimResults";
            this.labelTitleSimResults.Size = new System.Drawing.Size(412, 17);
            this.labelTitleSimResults.TabIndex = 61;
            this.labelTitleSimResults.Text = "Simulated results";
            this.labelTitleSimResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRealResults
            // 
            this.panelRealResults.Controls.Add(this.dataGridRealResults);
            this.panelRealResults.Controls.Add(this.labelTitleRealResults);
            this.panelRealResults.Location = new System.Drawing.Point(12, 97);
            this.panelRealResults.Name = "panelRealResults";
            this.panelRealResults.Size = new System.Drawing.Size(412, 349);
            this.panelRealResults.TabIndex = 62;
            this.panelRealResults.Visible = false;
            // 
            // panelSimResults
            // 
            this.panelSimResults.Controls.Add(this.labelTitleSimResults);
            this.panelSimResults.Controls.Add(this.dataGridSimResults);
            this.panelSimResults.Location = new System.Drawing.Point(760, 97);
            this.panelSimResults.Name = "panelSimResults";
            this.panelSimResults.Size = new System.Drawing.Size(412, 349);
            this.panelSimResults.TabIndex = 63;
            this.panelSimResults.Visible = false;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoBack.BackgroundImage = global::Football_Match_Simulator.Properties.Resources.back_arrow;
            this.buttonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGoBack.FlatAppearance.BorderSize = 0;
            this.buttonGoBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.Location = new System.Drawing.Point(12, 507);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(78, 42);
            this.buttonGoBack.TabIndex = 59;
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // formCompareResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.panelLeague);
            this.Controls.Add(this.panelTeamsAndGetResults);
            this.Controls.Add(this.labelTitleScreen);
            this.Controls.Add(this.panelRealResults);
            this.Controls.Add(this.panelSimResults);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCompareResults";
            this.Text = "CompareResultsScreen";
            this.panelTeamsAndGetResults.ResumeLayout(false);
            this.panelTeamsAndGetResults.PerformLayout();
            this.panelLeague.ResumeLayout(false);
            this.panelLeague.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRealResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSimResults)).EndInit();
            this.panelRealResults.ResumeLayout(false);
            this.panelSimResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleScreen;
        private System.Windows.Forms.Label labelTitleLeague;
        private System.Windows.Forms.Label labelTitleTeam1;
        private System.Windows.Forms.Panel panelTeamsAndGetResults;
        private System.Windows.Forms.ComboBox comboBoxSelectTeam2;
        private System.Windows.Forms.ComboBox comboBoxSelectTeam1;
        private System.Windows.Forms.Label labelTitleTeam2;
        private System.Windows.Forms.Button buttonGetResults;
        private System.Windows.Forms.Panel panelLeague;
        private System.Windows.Forms.ComboBox comboBoxSelectLeague;
        private System.Windows.Forms.DataGridView dataGridRealResults;
        private System.Windows.Forms.DataGridView dataGridSimResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealHTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealATeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScoreline;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealHXG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRealAXG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatePlayed;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.DataGridViewButtonColumn colDetailsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSimHTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSimATeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1stScoreline;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSimHXG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSimAXG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumSims;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateSimmed;
        private System.Windows.Forms.Label labelTitleRealResults;
        private System.Windows.Forms.Label labelTitleSimResults;
        private System.Windows.Forms.Panel panelRealResults;
        private System.Windows.Forms.Panel panelSimResults;
        private System.Windows.Forms.HelpProvider helpCompareResults;
        private System.Windows.Forms.Label labelVs;
    }
}