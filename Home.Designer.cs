namespace Football_Match_Simulator
{
    partial class formHome
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonGoToSimSetup = new System.Windows.Forms.Button();
            this.buttonGoToCompare = new System.Windows.Forms.Button();
            this.helpHome = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(346, 178);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(505, 43);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "FOOTBALL MATCH SIMULATOR";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // buttonGoToSimSetup
            // 
            this.buttonGoToSimSetup.BackColor = System.Drawing.Color.White;
            this.buttonGoToSimSetup.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpHome.SetHelpString(this.buttonGoToSimSetup, "");
            this.buttonGoToSimSetup.Location = new System.Drawing.Point(353, 255);
            this.buttonGoToSimSetup.Name = "buttonGoToSimSetup";
            this.helpHome.SetShowHelp(this.buttonGoToSimSetup, false);
            this.buttonGoToSimSetup.Size = new System.Drawing.Size(153, 86);
            this.buttonGoToSimSetup.TabIndex = 4;
            this.buttonGoToSimSetup.Text = "Simulate a Match";
            this.buttonGoToSimSetup.UseVisualStyleBackColor = false;
            this.buttonGoToSimSetup.Click += new System.EventHandler(this.buttonGoToSimSetup_Click);
            // 
            // buttonGoToCompare
            // 
            this.buttonGoToCompare.BackColor = System.Drawing.Color.White;
            this.buttonGoToCompare.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToCompare.Location = new System.Drawing.Point(686, 255);
            this.buttonGoToCompare.Name = "buttonGoToCompare";
            this.buttonGoToCompare.Size = new System.Drawing.Size(153, 86);
            this.buttonGoToCompare.TabIndex = 5;
            this.buttonGoToCompare.Text = "Compare Results";
            this.buttonGoToCompare.UseVisualStyleBackColor = false;
            this.buttonGoToCompare.Click += new System.EventHandler(this.buttonGoToCompare_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.buttonGoToCompare);
            this.Controls.Add(this.buttonGoToSimSetup);
            this.Controls.Add(this.labelTitle);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formHome";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonGoToSimSetup;
        private System.Windows.Forms.Button buttonGoToCompare;
        private System.Windows.Forms.HelpProvider helpHome;
    }
}

