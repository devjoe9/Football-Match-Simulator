namespace Football_Match_Simulator
{
    partial class formSimResults
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSimResults));
            this.chartWinDrawProb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartScorelines = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitleScreen = new System.Windows.Forms.Label();
            this.tablePanelSummary = new System.Windows.Forms.TableLayoutPanel();
            this.labelHTeam = new System.Windows.Forms.Label();
            this.labelATeam = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelxG = new System.Windows.Forms.Label();
            this.labelScorer = new System.Windows.Forms.Label();
            this.labelAssister = new System.Windows.Forms.Label();
            this.labelHTeamName = new System.Windows.Forms.Label();
            this.labelHxG = new System.Windows.Forms.Label();
            this.labelATeamName = new System.Windows.Forms.Label();
            this.labelHScorer = new System.Windows.Forms.Label();
            this.labelHAssister = new System.Windows.Forms.Label();
            this.labelAxG = new System.Windows.Forms.Label();
            this.labelAScorer = new System.Windows.Forms.Label();
            this.labelAAssister = new System.Windows.Forms.Label();
            this.labelNumSims = new System.Windows.Forms.Label();
            this.buttonSaveResults = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonGoHomeScreen = new System.Windows.Forms.Button();
            this.labelOvers = new System.Windows.Forms.Label();
            this.labelUnders = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelScoreline4 = new System.Windows.Forms.Label();
            this.labelScoreline3 = new System.Windows.Forms.Label();
            this.labelScoreline2 = new System.Windows.Forms.Label();
            this.labelScoreline1 = new System.Windows.Forms.Label();
            this.labelOccurPercent5 = new System.Windows.Forms.Label();
            this.labelScoreline5 = new System.Windows.Forms.Label();
            this.labelTitleOccurencePercent = new System.Windows.Forms.Label();
            this.labelOccurPercent1 = new System.Windows.Forms.Label();
            this.labelOccurPercent2 = new System.Windows.Forms.Label();
            this.labelOccurPercent3 = new System.Windows.Forms.Label();
            this.labelOccurPercent4 = new System.Windows.Forms.Label();
            this.labelTitleScoreline = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleScoreTable = new System.Windows.Forms.Label();
            this.helpSimResults = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.chartWinDrawProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScorelines)).BeginInit();
            this.tablePanelSummary.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartWinDrawProb
            // 
            chartArea7.AxisX.Title = "Match outcome";
            chartArea7.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.AxisY.Title = "%";
            chartArea7.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea7.Name = "ChartArea1";
            this.chartWinDrawProb.ChartAreas.Add(chartArea7);
            legend7.AutoFitMinFontSize = 6;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend7.InterlacedRows = true;
            legend7.IsDockedInsideChartArea = false;
            legend7.IsTextAutoFit = false;
            legend7.Name = "Legend1";
            this.chartWinDrawProb.Legends.Add(legend7);
            this.chartWinDrawProb.Location = new System.Drawing.Point(12, 73);
            this.chartWinDrawProb.Name = "chartWinDrawProb";
            this.chartWinDrawProb.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series10.ChartArea = "ChartArea1";
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.Legend = "Legend1";
            series10.Name = "Expected probability";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Simulation occurences";
            this.chartWinDrawProb.Series.Add(series10);
            this.chartWinDrawProb.Series.Add(series11);
            this.chartWinDrawProb.Size = new System.Drawing.Size(389, 419);
            this.chartWinDrawProb.TabIndex = 0;
            title7.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title7.Name = "Title1";
            title7.Text = "Expected win / draw probabilities vs Simulation outcome";
            this.chartWinDrawProb.Titles.Add(title7);
            // 
            // chartScorelines
            // 
            chartArea8.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea8.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30)));
            chartArea8.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea8.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90)));
            chartArea8.Name = "ChartArea1";
            this.chartScorelines.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartScorelines.Legends.Add(legend8);
            this.chartScorelines.Location = new System.Drawing.Point(407, 73);
            this.chartScorelines.Name = "chartScorelines";
            this.chartScorelines.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartScorelines.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Green,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Violet,
        System.Drawing.Color.LightCoral,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.Goldenrod,
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.DarkViolet,
        System.Drawing.Color.Pink};
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.CustomProperties = "PieLineColor=Black, CollectedSliceExploded=True, PieLabelStyle=Outside";
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            series12.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.Name = "Scorelines";
            series12.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Turquoise;
            series12.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series12.SmartLabelStyle.IsOverlappedHidden = false;
            series12.SmartLabelStyle.MaxMovingDistance = 120D;
            this.chartScorelines.Series.Add(series12);
            this.chartScorelines.Size = new System.Drawing.Size(438, 419);
            this.chartScorelines.TabIndex = 1;
            this.chartScorelines.Text = "chart1";
            title8.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title8.Name = "Title1";
            title8.Text = "Score-line occurences";
            this.chartScorelines.Titles.Add(title8);
            // 
            // labelTitleScreen
            // 
            this.labelTitleScreen.AutoSize = true;
            this.labelTitleScreen.BackColor = System.Drawing.Color.White;
            this.labelTitleScreen.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleScreen.Location = new System.Drawing.Point(341, 18);
            this.labelTitleScreen.Name = "labelTitleScreen";
            this.labelTitleScreen.Size = new System.Drawing.Size(503, 41);
            this.labelTitleScreen.TabIndex = 5;
            this.labelTitleScreen.Text = "FOOTBALL MATCH SIMULATOR";
            // 
            // tablePanelSummary
            // 
            this.tablePanelSummary.BackColor = System.Drawing.Color.YellowGreen;
            this.tablePanelSummary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tablePanelSummary.ColumnCount = 3;
            this.tablePanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33344F));
            this.tablePanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33313F));
            this.tablePanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33343F));
            this.tablePanelSummary.Controls.Add(this.labelHTeam, 1, 0);
            this.tablePanelSummary.Controls.Add(this.labelATeam, 2, 0);
            this.tablePanelSummary.Controls.Add(this.labelTeamName, 0, 1);
            this.tablePanelSummary.Controls.Add(this.labelxG, 0, 2);
            this.tablePanelSummary.Controls.Add(this.labelScorer, 0, 3);
            this.tablePanelSummary.Controls.Add(this.labelAssister, 0, 4);
            this.tablePanelSummary.Controls.Add(this.labelHTeamName, 1, 1);
            this.tablePanelSummary.Controls.Add(this.labelHxG, 1, 2);
            this.tablePanelSummary.Controls.Add(this.labelATeamName, 2, 1);
            this.tablePanelSummary.Controls.Add(this.labelHScorer, 1, 3);
            this.tablePanelSummary.Controls.Add(this.labelHAssister, 1, 4);
            this.tablePanelSummary.Controls.Add(this.labelAxG, 2, 2);
            this.tablePanelSummary.Controls.Add(this.labelAScorer, 2, 3);
            this.tablePanelSummary.Controls.Add(this.labelAAssister, 2, 4);
            this.tablePanelSummary.Location = new System.Drawing.Point(854, 73);
            this.tablePanelSummary.Name = "tablePanelSummary";
            this.tablePanelSummary.RowCount = 5;
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelSummary.Size = new System.Drawing.Size(321, 217);
            this.tablePanelSummary.TabIndex = 15;
            // 
            // labelHTeam
            // 
            this.labelHTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHTeam.AutoSize = true;
            this.labelHTeam.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimResults.SetHelpString(this.labelHTeam, "The home team is the team that plays at their own stadium/football pitch. The hom" +
        "e team is usually said to have an advantage due to crowd support and familiarity" +
        " with the grounds.");
            this.labelHTeam.Location = new System.Drawing.Point(112, 3);
            this.labelHTeam.Name = "labelHTeam";
            this.helpSimResults.SetShowHelp(this.labelHTeam, true);
            this.labelHTeam.Size = new System.Drawing.Size(96, 39);
            this.labelHTeam.TabIndex = 0;
            this.labelHTeam.Text = "Home team";
            this.labelHTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelATeam
            // 
            this.labelATeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelATeam.AutoSize = true;
            this.labelATeam.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimResults.SetHelpString(this.labelATeam, resources.GetString("labelATeam.HelpString"));
            this.labelATeam.Location = new System.Drawing.Point(217, 3);
            this.labelATeam.Name = "labelATeam";
            this.helpSimResults.SetShowHelp(this.labelATeam, true);
            this.labelATeam.Size = new System.Drawing.Size(98, 39);
            this.labelATeam.TabIndex = 1;
            this.labelATeam.Text = "Away team";
            this.labelATeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTeamName
            // 
            this.labelTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.Location = new System.Drawing.Point(6, 45);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(97, 39);
            this.labelTeamName.TabIndex = 2;
            this.labelTeamName.Text = "Team name";
            this.labelTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelxG
            // 
            this.labelxG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelxG.AutoSize = true;
            this.labelxG.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpSimResults.SetHelpString(this.labelxG, "Stands for \'expected goals\'. Describes the number of goals the team would be expe" +
        "cted to score given the circumstances");
            this.labelxG.Location = new System.Drawing.Point(6, 87);
            this.labelxG.Name = "labelxG";
            this.helpSimResults.SetShowHelp(this.labelxG, true);
            this.labelxG.Size = new System.Drawing.Size(97, 39);
            this.labelxG.TabIndex = 3;
            this.labelxG.Text = "xG";
            this.labelxG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScorer
            // 
            this.labelScorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScorer.AutoSize = true;
            this.labelScorer.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorer.Location = new System.Drawing.Point(6, 129);
            this.labelScorer.Name = "labelScorer";
            this.labelScorer.Size = new System.Drawing.Size(97, 39);
            this.labelScorer.TabIndex = 4;
            this.labelScorer.Text = "Most likely scorer";
            this.labelScorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAssister
            // 
            this.labelAssister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAssister.AutoSize = true;
            this.labelAssister.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssister.Location = new System.Drawing.Point(6, 171);
            this.labelAssister.Name = "labelAssister";
            this.labelAssister.Size = new System.Drawing.Size(97, 43);
            this.labelAssister.TabIndex = 5;
            this.labelAssister.Text = "Most likely assister";
            this.labelAssister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHTeamName
            // 
            this.labelHTeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHTeamName.AutoSize = true;
            this.labelHTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHTeamName.Location = new System.Drawing.Point(112, 45);
            this.labelHTeamName.Name = "labelHTeamName";
            this.labelHTeamName.Size = new System.Drawing.Size(96, 39);
            this.labelHTeamName.TabIndex = 6;
            this.labelHTeamName.Text = "text";
            this.labelHTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHxG
            // 
            this.labelHxG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHxG.AutoSize = true;
            this.labelHxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHxG.Location = new System.Drawing.Point(112, 87);
            this.labelHxG.Name = "labelHxG";
            this.labelHxG.Size = new System.Drawing.Size(96, 39);
            this.labelHxG.TabIndex = 7;
            this.labelHxG.Text = "text";
            this.labelHxG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelATeamName
            // 
            this.labelATeamName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelATeamName.AutoSize = true;
            this.labelATeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelATeamName.Location = new System.Drawing.Point(217, 45);
            this.labelATeamName.Name = "labelATeamName";
            this.labelATeamName.Size = new System.Drawing.Size(98, 39);
            this.labelATeamName.TabIndex = 10;
            this.labelATeamName.Text = "text";
            this.labelATeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHScorer
            // 
            this.labelHScorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHScorer.AutoSize = true;
            this.labelHScorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHScorer.Location = new System.Drawing.Point(112, 129);
            this.labelHScorer.Name = "labelHScorer";
            this.labelHScorer.Size = new System.Drawing.Size(96, 39);
            this.labelHScorer.TabIndex = 11;
            this.labelHScorer.Text = "text";
            this.labelHScorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHAssister
            // 
            this.labelHAssister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHAssister.AutoSize = true;
            this.labelHAssister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHAssister.Location = new System.Drawing.Point(112, 171);
            this.labelHAssister.Name = "labelHAssister";
            this.labelHAssister.Size = new System.Drawing.Size(96, 43);
            this.labelHAssister.TabIndex = 12;
            this.labelHAssister.Text = "text";
            this.labelHAssister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAxG
            // 
            this.labelAxG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAxG.AutoSize = true;
            this.labelAxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAxG.Location = new System.Drawing.Point(217, 87);
            this.labelAxG.Name = "labelAxG";
            this.labelAxG.Size = new System.Drawing.Size(98, 39);
            this.labelAxG.TabIndex = 13;
            this.labelAxG.Text = "text";
            this.labelAxG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAScorer
            // 
            this.labelAScorer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAScorer.AutoSize = true;
            this.labelAScorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAScorer.Location = new System.Drawing.Point(217, 129);
            this.labelAScorer.Name = "labelAScorer";
            this.labelAScorer.Size = new System.Drawing.Size(98, 39);
            this.labelAScorer.TabIndex = 14;
            this.labelAScorer.Text = "text";
            this.labelAScorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAAssister
            // 
            this.labelAAssister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAAssister.AutoSize = true;
            this.labelAAssister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAAssister.Location = new System.Drawing.Point(217, 171);
            this.labelAAssister.Name = "labelAAssister";
            this.labelAAssister.Size = new System.Drawing.Size(98, 43);
            this.labelAAssister.TabIndex = 15;
            this.labelAAssister.Text = "text";
            this.labelAAssister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumSims
            // 
            this.labelNumSims.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumSims.ForeColor = System.Drawing.Color.White;
            this.labelNumSims.Location = new System.Drawing.Point(851, 18);
            this.labelNumSims.Name = "labelNumSims";
            this.labelNumSims.Size = new System.Drawing.Size(315, 23);
            this.labelNumSims.TabIndex = 16;
            this.labelNumSims.Text = "Number of simulations run = ";
            // 
            // buttonSaveResults
            // 
            this.buttonSaveResults.BackColor = System.Drawing.Color.White;
            this.buttonSaveResults.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveResults.Location = new System.Drawing.Point(533, 507);
            this.buttonSaveResults.Name = "buttonSaveResults";
            this.buttonSaveResults.Size = new System.Drawing.Size(121, 42);
            this.buttonSaveResults.TabIndex = 55;
            this.buttonSaveResults.Text = "Save results";
            this.buttonSaveResults.UseVisualStyleBackColor = false;
            this.buttonSaveResults.Click += new System.EventHandler(this.buttonSaveResults_Click);
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
            this.buttonGoBack.TabIndex = 58;
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonGoHomeScreen
            // 
            this.buttonGoHomeScreen.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoHomeScreen.BackgroundImage = global::Football_Match_Simulator.Properties.Resources.home_screen_arrow;
            this.buttonGoHomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGoHomeScreen.FlatAppearance.BorderSize = 0;
            this.buttonGoHomeScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGoHomeScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGoHomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoHomeScreen.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoHomeScreen.Location = new System.Drawing.Point(1097, 507);
            this.buttonGoHomeScreen.Name = "buttonGoHomeScreen";
            this.buttonGoHomeScreen.Size = new System.Drawing.Size(78, 42);
            this.buttonGoHomeScreen.TabIndex = 59;
            this.buttonGoHomeScreen.UseVisualStyleBackColor = false;
            this.buttonGoHomeScreen.Click += new System.EventHandler(this.buttonGoHomeScreen_Click);
            // 
            // labelOvers
            // 
            this.labelOvers.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOvers.ForeColor = System.Drawing.Color.White;
            this.helpSimResults.SetHelpString(this.labelOvers, "A betting term. A bet that the number of goals in a match will be higher than thi" +
        "s number");
            this.labelOvers.Location = new System.Drawing.Point(850, 41);
            this.labelOvers.Name = "labelOvers";
            this.helpSimResults.SetShowHelp(this.labelOvers, true);
            this.labelOvers.Size = new System.Drawing.Size(106, 23);
            this.labelOvers.TabIndex = 60;
            this.labelOvers.Text = "Overs: ";
            // 
            // labelUnders
            // 
            this.labelUnders.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnders.ForeColor = System.Drawing.Color.White;
            this.helpSimResults.SetHelpString(this.labelUnders, "A betting term. A bet that the number of goals in a match will be lower than this" +
        " number");
            this.labelUnders.Location = new System.Drawing.Point(962, 41);
            this.labelUnders.Name = "labelUnders";
            this.helpSimResults.SetShowHelp(this.labelUnders, true);
            this.labelUnders.Size = new System.Drawing.Size(106, 23);
            this.labelUnders.TabIndex = 61;
            this.labelUnders.Text = "Unders: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.YellowGreen;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelScoreline4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreline3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreline2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreline1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOccurPercent5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreline5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTitleOccurencePercent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelOccurPercent1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOccurPercent2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelOccurPercent3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelOccurPercent4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelTitleScoreline, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(854, 331);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 161);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // labelScoreline4
            // 
            this.labelScoreline4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreline4.AutoSize = true;
            this.labelScoreline4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreline4.Location = new System.Drawing.Point(6, 107);
            this.labelScoreline4.Name = "labelScoreline4";
            this.labelScoreline4.Size = new System.Drawing.Size(150, 23);
            this.labelScoreline4.TabIndex = 66;
            this.labelScoreline4.Text = "text";
            this.labelScoreline4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScoreline3
            // 
            this.labelScoreline3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreline3.AutoSize = true;
            this.labelScoreline3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreline3.Location = new System.Drawing.Point(6, 81);
            this.labelScoreline3.Name = "labelScoreline3";
            this.labelScoreline3.Size = new System.Drawing.Size(150, 23);
            this.labelScoreline3.TabIndex = 65;
            this.labelScoreline3.Text = "text";
            this.labelScoreline3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScoreline2
            // 
            this.labelScoreline2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreline2.AutoSize = true;
            this.labelScoreline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreline2.Location = new System.Drawing.Point(6, 55);
            this.labelScoreline2.Name = "labelScoreline2";
            this.labelScoreline2.Size = new System.Drawing.Size(150, 23);
            this.labelScoreline2.TabIndex = 64;
            this.labelScoreline2.Text = "text";
            this.labelScoreline2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScoreline1
            // 
            this.labelScoreline1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreline1.AutoSize = true;
            this.labelScoreline1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreline1.Location = new System.Drawing.Point(6, 29);
            this.labelScoreline1.Name = "labelScoreline1";
            this.labelScoreline1.Size = new System.Drawing.Size(150, 23);
            this.labelScoreline1.TabIndex = 63;
            this.labelScoreline1.Text = "text";
            this.labelScoreline1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOccurPercent5
            // 
            this.labelOccurPercent5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOccurPercent5.AutoSize = true;
            this.labelOccurPercent5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccurPercent5.Location = new System.Drawing.Point(165, 133);
            this.labelOccurPercent5.Name = "labelOccurPercent5";
            this.labelOccurPercent5.Size = new System.Drawing.Size(150, 25);
            this.labelOccurPercent5.TabIndex = 15;
            this.labelOccurPercent5.Text = "text";
            this.labelOccurPercent5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScoreline5
            // 
            this.labelScoreline5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScoreline5.AutoSize = true;
            this.labelScoreline5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreline5.Location = new System.Drawing.Point(6, 133);
            this.labelScoreline5.Name = "labelScoreline5";
            this.labelScoreline5.Size = new System.Drawing.Size(150, 25);
            this.labelScoreline5.TabIndex = 14;
            this.labelScoreline5.Text = "text";
            this.labelScoreline5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleOccurencePercent
            // 
            this.labelTitleOccurencePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleOccurencePercent.AutoSize = true;
            this.labelTitleOccurencePercent.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOccurencePercent.Location = new System.Drawing.Point(165, 3);
            this.labelTitleOccurencePercent.Name = "labelTitleOccurencePercent";
            this.labelTitleOccurencePercent.Size = new System.Drawing.Size(150, 23);
            this.labelTitleOccurencePercent.TabIndex = 0;
            this.labelTitleOccurencePercent.Text = "Occurences (%)";
            this.labelTitleOccurencePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOccurPercent1
            // 
            this.labelOccurPercent1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOccurPercent1.AutoSize = true;
            this.labelOccurPercent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccurPercent1.Location = new System.Drawing.Point(165, 29);
            this.labelOccurPercent1.Name = "labelOccurPercent1";
            this.labelOccurPercent1.Size = new System.Drawing.Size(150, 23);
            this.labelOccurPercent1.TabIndex = 6;
            this.labelOccurPercent1.Text = "text";
            this.labelOccurPercent1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOccurPercent2
            // 
            this.labelOccurPercent2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOccurPercent2.AutoSize = true;
            this.labelOccurPercent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccurPercent2.Location = new System.Drawing.Point(165, 55);
            this.labelOccurPercent2.Name = "labelOccurPercent2";
            this.labelOccurPercent2.Size = new System.Drawing.Size(150, 23);
            this.labelOccurPercent2.TabIndex = 7;
            this.labelOccurPercent2.Text = "text";
            this.labelOccurPercent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOccurPercent3
            // 
            this.labelOccurPercent3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOccurPercent3.AutoSize = true;
            this.labelOccurPercent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccurPercent3.Location = new System.Drawing.Point(165, 81);
            this.labelOccurPercent3.Name = "labelOccurPercent3";
            this.labelOccurPercent3.Size = new System.Drawing.Size(150, 23);
            this.labelOccurPercent3.TabIndex = 11;
            this.labelOccurPercent3.Text = "text";
            this.labelOccurPercent3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOccurPercent4
            // 
            this.labelOccurPercent4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOccurPercent4.AutoSize = true;
            this.labelOccurPercent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOccurPercent4.Location = new System.Drawing.Point(165, 107);
            this.labelOccurPercent4.Name = "labelOccurPercent4";
            this.labelOccurPercent4.Size = new System.Drawing.Size(150, 23);
            this.labelOccurPercent4.TabIndex = 12;
            this.labelOccurPercent4.Text = "text";
            this.labelOccurPercent4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleScoreline
            // 
            this.labelTitleScoreline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleScoreline.AutoSize = true;
            this.labelTitleScoreline.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleScoreline.Location = new System.Drawing.Point(6, 3);
            this.labelTitleScoreline.Name = "labelTitleScoreline";
            this.labelTitleScoreline.Size = new System.Drawing.Size(150, 23);
            this.labelTitleScoreline.TabIndex = 13;
            this.labelTitleScoreline.Text = "Score-line";
            this.labelTitleScoreline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.YellowGreen;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelTitleScoreTable, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(854, 304);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(321, 30);
            this.tableLayoutPanel2.TabIndex = 62;
            // 
            // labelTitleScoreTable
            // 
            this.labelTitleScoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleScoreTable.AutoSize = true;
            this.labelTitleScoreTable.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleScoreTable.Location = new System.Drawing.Point(6, 3);
            this.labelTitleScoreTable.Name = "labelTitleScoreTable";
            this.labelTitleScoreTable.Size = new System.Drawing.Size(309, 24);
            this.labelTitleScoreTable.TabIndex = 13;
            this.labelTitleScoreTable.Text = "5 Highest occuring score-lines";
            this.labelTitleScoreTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formSimResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelUnders);
            this.Controls.Add(this.labelOvers);
            this.Controls.Add(this.buttonGoHomeScreen);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonSaveResults);
            this.Controls.Add(this.labelNumSims);
            this.Controls.Add(this.tablePanelSummary);
            this.Controls.Add(this.labelTitleScreen);
            this.Controls.Add(this.chartScorelines);
            this.Controls.Add(this.chartWinDrawProb);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSimResults";
            this.Text = "SimResultsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.chartWinDrawProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScorelines)).EndInit();
            this.tablePanelSummary.ResumeLayout(false);
            this.tablePanelSummary.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartWinDrawProb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScorelines;
        private System.Windows.Forms.Label labelTitleScreen;
        private System.Windows.Forms.TableLayoutPanel tablePanelSummary;
        private System.Windows.Forms.Label labelHTeam;
        private System.Windows.Forms.Label labelATeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelxG;
        private System.Windows.Forms.Label labelScorer;
        private System.Windows.Forms.Label labelAssister;
        private System.Windows.Forms.Label labelHTeamName;
        private System.Windows.Forms.Label labelHxG;
        private System.Windows.Forms.Label labelATeamName;
        private System.Windows.Forms.Label labelHScorer;
        private System.Windows.Forms.Label labelHAssister;
        private System.Windows.Forms.Label labelAxG;
        private System.Windows.Forms.Label labelAScorer;
        private System.Windows.Forms.Label labelAAssister;
        private System.Windows.Forms.Label labelNumSims;
        private System.Windows.Forms.Button buttonSaveResults;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonGoHomeScreen;
        private System.Windows.Forms.Label labelOvers;
        private System.Windows.Forms.Label labelUnders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelScoreline4;
        private System.Windows.Forms.Label labelScoreline3;
        private System.Windows.Forms.Label labelScoreline2;
        private System.Windows.Forms.Label labelScoreline1;
        private System.Windows.Forms.Label labelOccurPercent5;
        private System.Windows.Forms.Label labelScoreline5;
        private System.Windows.Forms.Label labelTitleOccurencePercent;
        private System.Windows.Forms.Label labelOccurPercent1;
        private System.Windows.Forms.Label labelOccurPercent2;
        private System.Windows.Forms.Label labelOccurPercent3;
        private System.Windows.Forms.Label labelOccurPercent4;
        private System.Windows.Forms.Label labelTitleScoreline;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTitleScoreTable;
        private System.Windows.Forms.HelpProvider helpSimResults;
    }
}