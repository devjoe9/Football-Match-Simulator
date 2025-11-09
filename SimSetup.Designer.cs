namespace Football_Match_Simulator
{
    partial class formSimSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSimSetup));
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.labelTitleLeague = new System.Windows.Forms.Label();
            this.comboBoxHTeam = new System.Windows.Forms.ComboBox();
            this.labelTitleHTeam = new System.Windows.Forms.Label();
            this.comboBoxATeam = new System.Windows.Forms.ComboBox();
            this.labelTitleATeam = new System.Windows.Forms.Label();
            this.comboBoxHTeamP2 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP3 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP4 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP5 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP1 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP6 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP7 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP8 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP9 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP10 = new System.Windows.Forms.ComboBox();
            this.comboBoxHTeamP11 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP11 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP10 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP9 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP8 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP7 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP6 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP1 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP5 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP4 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP3 = new System.Windows.Forms.ComboBox();
            this.comboBoxATeamP2 = new System.Windows.Forms.ComboBox();
            this.TitleHSheet = new System.Windows.Forms.Label();
            this.TitleASheet = new System.Windows.Forms.Label();
            this.panelTeams = new System.Windows.Forms.Panel();
            this.checkBoxSkipPlay = new System.Windows.Forms.CheckBox();
            this.labelTitleNumSims = new System.Windows.Forms.Label();
            this.textboxNumSims = new System.Windows.Forms.TextBox();
            this.labelTitleAMorale = new System.Windows.Forms.Label();
            this.labelTitleHMorale = new System.Windows.Forms.Label();
            this.labelTitleATactic = new System.Windows.Forms.Label();
            this.labelTitleHTactic = new System.Windows.Forms.Label();
            this.comboBoxHMorale = new System.Windows.Forms.ComboBox();
            this.comboBoxATactic = new System.Windows.Forms.ComboBox();
            this.comboBoxHTactic = new System.Windows.Forms.ComboBox();
            this.checkBoxFormBias = new System.Windows.Forms.CheckBox();
            this.comboBoxAMorale = new System.Windows.Forms.ComboBox();
            this.panelVariables = new System.Windows.Forms.Panel();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.panelATeamSheet = new System.Windows.Forms.Panel();
            this.panelHTeamSheet = new System.Windows.Forms.Panel();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.helpSimSetup = new System.Windows.Forms.HelpProvider();
            this.panelTeams.SuspendLayout();
            this.panelVariables.SuspendLayout();
            this.panelATeamSheet.SuspendLayout();
            this.panelHTeamSheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(341, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(503, 41);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "FOOTBALL MATCH SIMULATOR";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.BackColor = System.Drawing.Color.White;
            this.comboBoxLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeague.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxLeague, "Select a league from the drop-down menu");
            this.comboBoxLeague.Location = new System.Drawing.Point(531, 94);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.helpSimSetup.SetShowHelp(this.comboBoxLeague, true);
            this.comboBoxLeague.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeague.TabIndex = 5;
            this.comboBoxLeague.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeague_SelectedIndexChanged);
            // 
            // labelTitleLeague
            // 
            this.labelTitleLeague.AutoSize = true;
            this.labelTitleLeague.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleLeague, "A league is a group of football teams that compete with each other over a period " +
        "of time for a championship");
            this.labelTitleLeague.Location = new System.Drawing.Point(560, 75);
            this.labelTitleLeague.Name = "labelTitleLeague";
            this.helpSimSetup.SetShowHelp(this.labelTitleLeague, true);
            this.labelTitleLeague.Size = new System.Drawing.Size(55, 16);
            this.labelTitleLeague.TabIndex = 6;
            this.labelTitleLeague.Text = "League";
            // 
            // comboBoxHTeam
            // 
            this.comboBoxHTeam.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeam.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxHTeam, "Select a team from the drop-down menu");
            this.comboBoxHTeam.Location = new System.Drawing.Point(0, 20);
            this.comboBoxHTeam.Name = "comboBoxHTeam";
            this.helpSimSetup.SetShowHelp(this.comboBoxHTeam, true);
            this.comboBoxHTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHTeam.TabIndex = 7;
            this.comboBoxHTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxHTeam_SelectedIndexChanged);
            // 
            // labelTitleHTeam
            // 
            this.labelTitleHTeam.AutoSize = true;
            this.labelTitleHTeam.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleHTeam, "The home team is the team that plays at their own stadium/football pitch. The hom" +
        "e team is usually said to have an advantage due to crowd support and familiarity" +
        " with the grounds.");
            this.labelTitleHTeam.Location = new System.Drawing.Point(-3, 1);
            this.labelTitleHTeam.Name = "labelTitleHTeam";
            this.helpSimSetup.SetShowHelp(this.labelTitleHTeam, true);
            this.labelTitleHTeam.Size = new System.Drawing.Size(81, 16);
            this.labelTitleHTeam.TabIndex = 8;
            this.labelTitleHTeam.Text = "Home team";
            // 
            // comboBoxATeam
            // 
            this.comboBoxATeam.BackColor = System.Drawing.Color.White;
            this.comboBoxATeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeam.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxATeam, "Select a team from the drop-down menu");
            this.comboBoxATeam.Location = new System.Drawing.Point(198, 20);
            this.comboBoxATeam.Name = "comboBoxATeam";
            this.helpSimSetup.SetShowHelp(this.comboBoxATeam, true);
            this.comboBoxATeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxATeam.TabIndex = 9;
            this.comboBoxATeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeam_SelectedIndexChanged);
            // 
            // labelTitleATeam
            // 
            this.labelTitleATeam.AutoSize = true;
            this.labelTitleATeam.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleATeam, resources.GetString("labelTitleATeam.HelpString"));
            this.labelTitleATeam.Location = new System.Drawing.Point(240, 1);
            this.labelTitleATeam.Name = "labelTitleATeam";
            this.helpSimSetup.SetShowHelp(this.labelTitleATeam, true);
            this.labelTitleATeam.Size = new System.Drawing.Size(77, 16);
            this.labelTitleATeam.TabIndex = 10;
            this.labelTitleATeam.Text = "Away team";
            // 
            // comboBoxHTeamP2
            // 
            this.comboBoxHTeamP2.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP2.FormattingEnabled = true;
            this.comboBoxHTeamP2.Location = new System.Drawing.Point(6, 50);
            this.comboBoxHTeamP2.Name = "comboBoxHTeamP2";
            this.comboBoxHTeamP2.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP2.TabIndex = 25;
            // 
            // comboBoxHTeamP3
            // 
            this.comboBoxHTeamP3.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP3.FormattingEnabled = true;
            this.comboBoxHTeamP3.Location = new System.Drawing.Point(6, 70);
            this.comboBoxHTeamP3.Name = "comboBoxHTeamP3";
            this.comboBoxHTeamP3.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP3.TabIndex = 26;
            // 
            // comboBoxHTeamP4
            // 
            this.comboBoxHTeamP4.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP4.FormattingEnabled = true;
            this.comboBoxHTeamP4.Location = new System.Drawing.Point(6, 89);
            this.comboBoxHTeamP4.Name = "comboBoxHTeamP4";
            this.comboBoxHTeamP4.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP4.TabIndex = 27;
            // 
            // comboBoxHTeamP5
            // 
            this.comboBoxHTeamP5.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP5.FormattingEnabled = true;
            this.comboBoxHTeamP5.Location = new System.Drawing.Point(6, 108);
            this.comboBoxHTeamP5.Name = "comboBoxHTeamP5";
            this.comboBoxHTeamP5.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP5.TabIndex = 28;
            // 
            // comboBoxHTeamP1
            // 
            this.comboBoxHTeamP1.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP1.DropDownWidth = 197;
            this.comboBoxHTeamP1.FormattingEnabled = true;
            this.comboBoxHTeamP1.Location = new System.Drawing.Point(6, 30);
            this.comboBoxHTeamP1.Name = "comboBoxHTeamP1";
            this.comboBoxHTeamP1.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP1.TabIndex = 29;
            // 
            // comboBoxHTeamP6
            // 
            this.comboBoxHTeamP6.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP6.FormattingEnabled = true;
            this.comboBoxHTeamP6.Location = new System.Drawing.Point(6, 125);
            this.comboBoxHTeamP6.Name = "comboBoxHTeamP6";
            this.comboBoxHTeamP6.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP6.TabIndex = 30;
            // 
            // comboBoxHTeamP7
            // 
            this.comboBoxHTeamP7.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP7.FormattingEnabled = true;
            this.comboBoxHTeamP7.Location = new System.Drawing.Point(6, 143);
            this.comboBoxHTeamP7.Name = "comboBoxHTeamP7";
            this.comboBoxHTeamP7.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP7.TabIndex = 31;
            // 
            // comboBoxHTeamP8
            // 
            this.comboBoxHTeamP8.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP8.FormattingEnabled = true;
            this.comboBoxHTeamP8.Location = new System.Drawing.Point(6, 162);
            this.comboBoxHTeamP8.Name = "comboBoxHTeamP8";
            this.comboBoxHTeamP8.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP8.TabIndex = 32;
            // 
            // comboBoxHTeamP9
            // 
            this.comboBoxHTeamP9.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP9.FormattingEnabled = true;
            this.comboBoxHTeamP9.Location = new System.Drawing.Point(6, 181);
            this.comboBoxHTeamP9.Name = "comboBoxHTeamP9";
            this.comboBoxHTeamP9.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP9.TabIndex = 33;
            // 
            // comboBoxHTeamP10
            // 
            this.comboBoxHTeamP10.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP10.FormattingEnabled = true;
            this.comboBoxHTeamP10.Location = new System.Drawing.Point(6, 201);
            this.comboBoxHTeamP10.Name = "comboBoxHTeamP10";
            this.comboBoxHTeamP10.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP10.TabIndex = 34;
            // 
            // comboBoxHTeamP11
            // 
            this.comboBoxHTeamP11.BackColor = System.Drawing.Color.White;
            this.comboBoxHTeamP11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTeamP11.FormattingEnabled = true;
            this.comboBoxHTeamP11.Location = new System.Drawing.Point(6, 222);
            this.comboBoxHTeamP11.Name = "comboBoxHTeamP11";
            this.comboBoxHTeamP11.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHTeamP11.TabIndex = 35;
            // 
            // comboBoxATeamP11
            // 
            this.comboBoxATeamP11.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP11.FormattingEnabled = true;
            this.comboBoxATeamP11.Location = new System.Drawing.Point(80, 222);
            this.comboBoxATeamP11.Name = "comboBoxATeamP11";
            this.comboBoxATeamP11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP11.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP11.TabIndex = 46;
            this.comboBoxATeamP11.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP11_SelectedIndexChanged);
            // 
            // comboBoxATeamP10
            // 
            this.comboBoxATeamP10.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP10.FormattingEnabled = true;
            this.comboBoxATeamP10.Location = new System.Drawing.Point(80, 201);
            this.comboBoxATeamP10.Name = "comboBoxATeamP10";
            this.comboBoxATeamP10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP10.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP10.TabIndex = 45;
            this.comboBoxATeamP10.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP10_SelectedIndexChanged);
            // 
            // comboBoxATeamP9
            // 
            this.comboBoxATeamP9.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP9.FormattingEnabled = true;
            this.comboBoxATeamP9.Location = new System.Drawing.Point(80, 181);
            this.comboBoxATeamP9.Name = "comboBoxATeamP9";
            this.comboBoxATeamP9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP9.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP9.TabIndex = 44;
            this.comboBoxATeamP9.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP9_SelectedIndexChanged);
            // 
            // comboBoxATeamP8
            // 
            this.comboBoxATeamP8.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP8.FormattingEnabled = true;
            this.comboBoxATeamP8.Location = new System.Drawing.Point(80, 162);
            this.comboBoxATeamP8.Name = "comboBoxATeamP8";
            this.comboBoxATeamP8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP8.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP8.TabIndex = 43;
            this.comboBoxATeamP8.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP8_SelectedIndexChanged);
            // 
            // comboBoxATeamP7
            // 
            this.comboBoxATeamP7.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP7.FormattingEnabled = true;
            this.comboBoxATeamP7.Location = new System.Drawing.Point(80, 143);
            this.comboBoxATeamP7.Name = "comboBoxATeamP7";
            this.comboBoxATeamP7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP7.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP7.TabIndex = 42;
            this.comboBoxATeamP7.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP7_SelectedIndexChanged);
            // 
            // comboBoxATeamP6
            // 
            this.comboBoxATeamP6.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP6.FormattingEnabled = true;
            this.comboBoxATeamP6.Location = new System.Drawing.Point(80, 125);
            this.comboBoxATeamP6.Name = "comboBoxATeamP6";
            this.comboBoxATeamP6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP6.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP6.TabIndex = 41;
            this.comboBoxATeamP6.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP6_SelectedIndexChanged);
            // 
            // comboBoxATeamP1
            // 
            this.comboBoxATeamP1.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP1.FormattingEnabled = true;
            this.comboBoxATeamP1.Location = new System.Drawing.Point(80, 30);
            this.comboBoxATeamP1.Name = "comboBoxATeamP1";
            this.comboBoxATeamP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP1.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP1.TabIndex = 40;
            this.comboBoxATeamP1.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP1_SelectedIndexChanged);
            // 
            // comboBoxATeamP5
            // 
            this.comboBoxATeamP5.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP5.FormattingEnabled = true;
            this.comboBoxATeamP5.Location = new System.Drawing.Point(80, 108);
            this.comboBoxATeamP5.Name = "comboBoxATeamP5";
            this.comboBoxATeamP5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP5.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP5.TabIndex = 39;
            this.comboBoxATeamP5.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP5_SelectedIndexChanged);
            // 
            // comboBoxATeamP4
            // 
            this.comboBoxATeamP4.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP4.FormattingEnabled = true;
            this.comboBoxATeamP4.Location = new System.Drawing.Point(80, 89);
            this.comboBoxATeamP4.Name = "comboBoxATeamP4";
            this.comboBoxATeamP4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP4.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP4.TabIndex = 38;
            this.comboBoxATeamP4.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP4_SelectedIndexChanged);
            // 
            // comboBoxATeamP3
            // 
            this.comboBoxATeamP3.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP3.FormattingEnabled = true;
            this.comboBoxATeamP3.Location = new System.Drawing.Point(80, 70);
            this.comboBoxATeamP3.Name = "comboBoxATeamP3";
            this.comboBoxATeamP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP3.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP3.TabIndex = 37;
            this.comboBoxATeamP3.SelectedIndexChanged += new System.EventHandler(this.comboBoxATeamP3_SelectedIndexChanged);
            // 
            // comboBoxATeamP2
            // 
            this.comboBoxATeamP2.BackColor = System.Drawing.Color.White;
            this.comboBoxATeamP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATeamP2.FormattingEnabled = true;
            this.comboBoxATeamP2.Location = new System.Drawing.Point(80, 50);
            this.comboBoxATeamP2.Name = "comboBoxATeamP2";
            this.comboBoxATeamP2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxATeamP2.Size = new System.Drawing.Size(197, 21);
            this.comboBoxATeamP2.TabIndex = 36;
            // 
            // TitleHSheet
            // 
            this.TitleHSheet.AutoSize = true;
            this.TitleHSheet.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.TitleHSheet, resources.GetString("TitleHSheet.HelpString"));
            this.TitleHSheet.Location = new System.Drawing.Point(3, 12);
            this.TitleHSheet.Name = "TitleHSheet";
            this.helpSimSetup.SetShowHelp(this.TitleHSheet, true);
            this.TitleHSheet.Size = new System.Drawing.Size(119, 16);
            this.TitleHSheet.TabIndex = 47;
            this.TitleHSheet.Text = "Home team sheet";
            // 
            // TitleASheet
            // 
            this.TitleASheet.AutoSize = true;
            this.TitleASheet.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.TitleASheet, resources.GetString("TitleASheet.HelpString"));
            this.TitleASheet.Location = new System.Drawing.Point(162, 12);
            this.TitleASheet.Name = "TitleASheet";
            this.helpSimSetup.SetShowHelp(this.TitleASheet, true);
            this.TitleASheet.Size = new System.Drawing.Size(115, 16);
            this.TitleASheet.TabIndex = 48;
            this.TitleASheet.Text = "Away team sheet";
            // 
            // panelTeams
            // 
            this.panelTeams.Controls.Add(this.comboBoxATeam);
            this.panelTeams.Controls.Add(this.comboBoxHTeam);
            this.panelTeams.Controls.Add(this.labelTitleHTeam);
            this.panelTeams.Controls.Add(this.labelTitleATeam);
            this.panelTeams.Location = new System.Drawing.Point(428, 134);
            this.panelTeams.Name = "panelTeams";
            this.panelTeams.Size = new System.Drawing.Size(319, 44);
            this.panelTeams.TabIndex = 49;
            this.panelTeams.Visible = false;
            this.panelTeams.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeams_Paint);
            // 
            // checkBoxSkipPlay
            // 
            this.checkBoxSkipPlay.AutoSize = true;
            this.checkBoxSkipPlay.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.checkBoxSkipPlay, "If unchecked, a playback of the most frequent simulated match outcome will be pla" +
        "yed when the \'Simulate\' button is pressed, before going to the results screen.  " +
        "If checked, this step will be skipped ");
            this.checkBoxSkipPlay.Location = new System.Drawing.Point(199, 182);
            this.checkBoxSkipPlay.Name = "checkBoxSkipPlay";
            this.helpSimSetup.SetShowHelp(this.checkBoxSkipPlay, true);
            this.checkBoxSkipPlay.Size = new System.Drawing.Size(117, 20);
            this.checkBoxSkipPlay.TabIndex = 23;
            this.checkBoxSkipPlay.Text = "Skip playback";
            this.checkBoxSkipPlay.UseVisualStyleBackColor = true;
            this.checkBoxSkipPlay.CheckedChanged += new System.EventHandler(this.checkBoxSkipPlay_CheckedChanged);
            // 
            // labelTitleNumSims
            // 
            this.labelTitleNumSims.AutoSize = true;
            this.labelTitleNumSims.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleNumSims.Location = new System.Drawing.Point(26, 233);
            this.labelTitleNumSims.Name = "labelTitleNumSims";
            this.labelTitleNumSims.Size = new System.Drawing.Size(260, 16);
            this.labelTitleNumSims.TabIndex = 22;
            this.labelTitleNumSims.Text = "Number of simulations (1-1,000,000):";
            // 
            // textboxNumSims
            // 
            this.helpSimSetup.SetHelpString(this.textboxNumSims, "Enter the number of simulations you would like to run");
            this.textboxNumSims.Location = new System.Drawing.Point(103, 252);
            this.textboxNumSims.Name = "textboxNumSims";
            this.helpSimSetup.SetShowHelp(this.textboxNumSims, true);
            this.textboxNumSims.Size = new System.Drawing.Size(108, 20);
            this.textboxNumSims.TabIndex = 21;
            this.textboxNumSims.TextChanged += new System.EventHandler(this.textboxNumSims_TextChanged);
            // 
            // labelTitleAMorale
            // 
            this.labelTitleAMorale.AutoSize = true;
            this.labelTitleAMorale.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleAMorale, "The morale of the whole team. Affects the performance of the whole team. Higher m" +
        "orale = better in attack and defense, lower morale = worse in attack and defense" +
        "");
            this.labelTitleAMorale.Location = new System.Drawing.Point(196, 113);
            this.labelTitleAMorale.Name = "labelTitleAMorale";
            this.helpSimSetup.SetShowHelp(this.labelTitleAMorale, true);
            this.labelTitleAMorale.Size = new System.Drawing.Size(126, 16);
            this.labelTitleAMorale.TabIndex = 20;
            this.labelTitleAMorale.Text = "Away team morale";
            // 
            // labelTitleHMorale
            // 
            this.labelTitleHMorale.AutoSize = true;
            this.labelTitleHMorale.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleHMorale, "The morale of the whole team. Affects the performance of the whole team. Higher m" +
        "orale = better in attack and defense, lower morale = worse in attack and defense" +
        "");
            this.labelTitleHMorale.Location = new System.Drawing.Point(-3, 113);
            this.labelTitleHMorale.Name = "labelTitleHMorale";
            this.helpSimSetup.SetShowHelp(this.labelTitleHMorale, true);
            this.labelTitleHMorale.Size = new System.Drawing.Size(130, 16);
            this.labelTitleHMorale.TabIndex = 19;
            this.labelTitleHMorale.Text = "Home team morale";
            // 
            // labelTitleATactic
            // 
            this.labelTitleATactic.AutoSize = true;
            this.labelTitleATactic.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleATactic, resources.GetString("labelTitleATactic.HelpString"));
            this.labelTitleATactic.Location = new System.Drawing.Point(202, 31);
            this.labelTitleATactic.Name = "labelTitleATactic";
            this.helpSimSetup.SetShowHelp(this.labelTitleATactic, true);
            this.labelTitleATactic.Size = new System.Drawing.Size(117, 16);
            this.labelTitleATactic.TabIndex = 18;
            this.labelTitleATactic.Text = "Away team tactic";
            this.labelTitleATactic.Click += new System.EventHandler(this.labelTitleATactic_Click);
            // 
            // labelTitleHTactic
            // 
            this.labelTitleHTactic.AutoSize = true;
            this.labelTitleHTactic.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.labelTitleHTactic, resources.GetString("labelTitleHTactic.HelpString"));
            this.labelTitleHTactic.Location = new System.Drawing.Point(-3, 31);
            this.labelTitleHTactic.Name = "labelTitleHTactic";
            this.helpSimSetup.SetShowHelp(this.labelTitleHTactic, true);
            this.labelTitleHTactic.Size = new System.Drawing.Size(121, 16);
            this.labelTitleHTactic.TabIndex = 17;
            this.labelTitleHTactic.Text = "Home team tactic";
            // 
            // comboBoxHMorale
            // 
            this.comboBoxHMorale.BackColor = System.Drawing.Color.White;
            this.comboBoxHMorale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHMorale.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxHMorale, "Select a morale option from the drop-down menu");
            this.comboBoxHMorale.Location = new System.Drawing.Point(0, 132);
            this.comboBoxHMorale.Name = "comboBoxHMorale";
            this.helpSimSetup.SetShowHelp(this.comboBoxHMorale, true);
            this.comboBoxHMorale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHMorale.TabIndex = 15;
            this.comboBoxHMorale.SelectedIndexChanged += new System.EventHandler(this.comboBoxHMorale_SelectedIndexChanged);
            // 
            // comboBoxATactic
            // 
            this.comboBoxATactic.BackColor = System.Drawing.Color.White;
            this.comboBoxATactic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxATactic.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxATactic, "Select a tactic from the drop-down menu");
            this.comboBoxATactic.Location = new System.Drawing.Point(198, 50);
            this.comboBoxATactic.Name = "comboBoxATactic";
            this.helpSimSetup.SetShowHelp(this.comboBoxATactic, true);
            this.comboBoxATactic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxATactic.TabIndex = 12;
            this.comboBoxATactic.SelectedIndexChanged += new System.EventHandler(this.comboBoxATactic_SelectedIndexChanged);
            // 
            // comboBoxHTactic
            // 
            this.comboBoxHTactic.BackColor = System.Drawing.Color.White;
            this.comboBoxHTactic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHTactic.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxHTactic, "Select a tactic from the drop-down menu");
            this.comboBoxHTactic.Location = new System.Drawing.Point(0, 50);
            this.comboBoxHTactic.Name = "comboBoxHTactic";
            this.helpSimSetup.SetShowHelp(this.comboBoxHTactic, true);
            this.comboBoxHTactic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHTactic.TabIndex = 11;
            this.comboBoxHTactic.SelectedIndexChanged += new System.EventHandler(this.comboBoxHTactic_SelectedIndexChanged);
            // 
            // checkBoxFormBias
            // 
            this.checkBoxFormBias.AutoSize = true;
            this.checkBoxFormBias.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.checkBoxFormBias, resources.GetString("checkBoxFormBias.HelpString"));
            this.checkBoxFormBias.Location = new System.Drawing.Point(3, 182);
            this.checkBoxFormBias.Name = "checkBoxFormBias";
            this.helpSimSetup.SetShowHelp(this.checkBoxFormBias, true);
            this.checkBoxFormBias.Size = new System.Drawing.Size(136, 20);
            this.checkBoxFormBias.TabIndex = 50;
            this.checkBoxFormBias.Text = "Recent form bias";
            this.checkBoxFormBias.UseVisualStyleBackColor = true;
            this.checkBoxFormBias.CheckedChanged += new System.EventHandler(this.checkBoxFormBias_CheckedChanged);
            // 
            // comboBoxAMorale
            // 
            this.comboBoxAMorale.BackColor = System.Drawing.Color.White;
            this.comboBoxAMorale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAMorale.FormattingEnabled = true;
            this.helpSimSetup.SetHelpString(this.comboBoxAMorale, "Select a morale option from the drop-down menu");
            this.comboBoxAMorale.Location = new System.Drawing.Point(198, 132);
            this.comboBoxAMorale.Name = "comboBoxAMorale";
            this.helpSimSetup.SetShowHelp(this.comboBoxAMorale, true);
            this.comboBoxAMorale.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAMorale.TabIndex = 16;
            this.comboBoxAMorale.SelectedIndexChanged += new System.EventHandler(this.comboBoxAMorale_SelectedIndexChanged);
            // 
            // panelVariables
            // 
            this.panelVariables.Controls.Add(this.buttonSimulate);
            this.panelVariables.Controls.Add(this.comboBoxAMorale);
            this.panelVariables.Controls.Add(this.checkBoxFormBias);
            this.panelVariables.Controls.Add(this.comboBoxHTactic);
            this.panelVariables.Controls.Add(this.comboBoxATactic);
            this.panelVariables.Controls.Add(this.comboBoxHMorale);
            this.panelVariables.Controls.Add(this.labelTitleHTactic);
            this.panelVariables.Controls.Add(this.labelTitleATactic);
            this.panelVariables.Controls.Add(this.labelTitleHMorale);
            this.panelVariables.Controls.Add(this.labelTitleAMorale);
            this.panelVariables.Controls.Add(this.textboxNumSims);
            this.panelVariables.Controls.Add(this.labelTitleNumSims);
            this.panelVariables.Controls.Add(this.checkBoxSkipPlay);
            this.panelVariables.Location = new System.Drawing.Point(428, 194);
            this.panelVariables.Name = "panelVariables";
            this.panelVariables.Size = new System.Drawing.Size(319, 344);
            this.panelVariables.TabIndex = 51;
            this.panelVariables.Visible = false;
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.BackColor = System.Drawing.Color.White;
            this.buttonSimulate.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimSetup.SetHelpString(this.buttonSimulate, "Press to run the simulation(s). Will then take you to the playback screen (if des" +
        "ired) before taking you to the results of the simulation(s)");
            this.buttonSimulate.Location = new System.Drawing.Point(103, 299);
            this.buttonSimulate.Name = "buttonSimulate";
            this.helpSimSetup.SetShowHelp(this.buttonSimulate, true);
            this.buttonSimulate.Size = new System.Drawing.Size(108, 42);
            this.buttonSimulate.TabIndex = 54;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = false;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // panelATeamSheet
            // 
            this.panelATeamSheet.Controls.Add(this.TitleASheet);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP2);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP3);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP4);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP11);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP5);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP10);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP1);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP9);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP6);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP8);
            this.panelATeamSheet.Controls.Add(this.comboBoxATeamP7);
            this.panelATeamSheet.Location = new System.Drawing.Point(788, 164);
            this.panelATeamSheet.Name = "panelATeamSheet";
            this.panelATeamSheet.Size = new System.Drawing.Size(289, 253);
            this.panelATeamSheet.TabIndex = 53;
            this.panelATeamSheet.Visible = false;
            // 
            // panelHTeamSheet
            // 
            this.panelHTeamSheet.Controls.Add(this.TitleHSheet);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP2);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP3);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP4);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP5);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP1);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP6);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP7);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP8);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP9);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP10);
            this.panelHTeamSheet.Controls.Add(this.comboBoxHTeamP11);
            this.panelHTeamSheet.Location = new System.Drawing.Point(91, 164);
            this.panelHTeamSheet.Name = "panelHTeamSheet";
            this.panelHTeamSheet.Size = new System.Drawing.Size(276, 253);
            this.panelHTeamSheet.TabIndex = 52;
            this.panelHTeamSheet.Visible = false;
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
            // formSimSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.panelATeamSheet);
            this.Controls.Add(this.panelHTeamSheet);
            this.Controls.Add(this.panelVariables);
            this.Controls.Add(this.panelTeams);
            this.Controls.Add(this.labelTitleLeague);
            this.Controls.Add(this.comboBoxLeague);
            this.Controls.Add(this.labelTitle);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSimSetup";
            this.Text = "SimSetup";
            this.panelTeams.ResumeLayout(false);
            this.panelTeams.PerformLayout();
            this.panelVariables.ResumeLayout(false);
            this.panelVariables.PerformLayout();
            this.panelATeamSheet.ResumeLayout(false);
            this.panelATeamSheet.PerformLayout();
            this.panelHTeamSheet.ResumeLayout(false);
            this.panelHTeamSheet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.Label labelTitleLeague;
        private System.Windows.Forms.ComboBox comboBoxHTeam;
        private System.Windows.Forms.Label labelTitleHTeam;
        private System.Windows.Forms.ComboBox comboBoxATeam;
        private System.Windows.Forms.Label labelTitleATeam;
        private System.Windows.Forms.ComboBox comboBoxHTeamP2;
        private System.Windows.Forms.ComboBox comboBoxHTeamP3;
        private System.Windows.Forms.ComboBox comboBoxHTeamP4;
        private System.Windows.Forms.ComboBox comboBoxHTeamP5;
        private System.Windows.Forms.ComboBox comboBoxHTeamP1;
        private System.Windows.Forms.ComboBox comboBoxHTeamP6;
        private System.Windows.Forms.ComboBox comboBoxHTeamP7;
        private System.Windows.Forms.ComboBox comboBoxHTeamP8;
        private System.Windows.Forms.ComboBox comboBoxHTeamP9;
        private System.Windows.Forms.ComboBox comboBoxHTeamP10;
        private System.Windows.Forms.ComboBox comboBoxHTeamP11;
        private System.Windows.Forms.ComboBox comboBoxATeamP11;
        private System.Windows.Forms.ComboBox comboBoxATeamP10;
        private System.Windows.Forms.ComboBox comboBoxATeamP9;
        private System.Windows.Forms.ComboBox comboBoxATeamP8;
        private System.Windows.Forms.ComboBox comboBoxATeamP7;
        private System.Windows.Forms.ComboBox comboBoxATeamP6;
        private System.Windows.Forms.ComboBox comboBoxATeamP1;
        private System.Windows.Forms.ComboBox comboBoxATeamP5;
        private System.Windows.Forms.ComboBox comboBoxATeamP4;
        private System.Windows.Forms.ComboBox comboBoxATeamP3;
        private System.Windows.Forms.ComboBox comboBoxATeamP2;
        private System.Windows.Forms.Label TitleHSheet;
        private System.Windows.Forms.Label TitleASheet;
        private System.Windows.Forms.Panel panelTeams;
        private System.Windows.Forms.CheckBox checkBoxSkipPlay;
        private System.Windows.Forms.Label labelTitleNumSims;
        private System.Windows.Forms.TextBox textboxNumSims;
        private System.Windows.Forms.Label labelTitleAMorale;
        private System.Windows.Forms.Label labelTitleHMorale;
        private System.Windows.Forms.Label labelTitleATactic;
        private System.Windows.Forms.Label labelTitleHTactic;
        private System.Windows.Forms.ComboBox comboBoxHMorale;
        private System.Windows.Forms.ComboBox comboBoxATactic;
        private System.Windows.Forms.ComboBox comboBoxHTactic;
        private System.Windows.Forms.CheckBox checkBoxFormBias;
        private System.Windows.Forms.ComboBox comboBoxAMorale;
        private System.Windows.Forms.Panel panelVariables;
        private System.Windows.Forms.Panel panelATeamSheet;
        private System.Windows.Forms.Panel panelHTeamSheet;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.HelpProvider helpSimSetup;
    }
}