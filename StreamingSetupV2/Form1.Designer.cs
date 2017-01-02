namespace StreamingSetupV2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveScoreInfo1 = new StreamingSetupV2.LiveScoreInfo();
            this.halftimeCountdown1 = new StreamingSetupV2.HalftimeCountdown();
            this.startingSoonCountdown1 = new StreamingSetupV2.StartingSoonCountdown();
            this.StartingSoonCountdownControl = new StreamingSetupV2.StartingSoonCountdown();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.outputDirectoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // outputDirectoryToolStripMenuItem
            // 
            this.outputDirectoryToolStripMenuItem.Name = "outputDirectoryToolStripMenuItem";
            this.outputDirectoryToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.outputDirectoryToolStripMenuItem.Text = "Output Directory";
            this.outputDirectoryToolStripMenuItem.Click += new System.EventHandler(this.outputDirectoryToolStripMenuItem_Click);
            // 
            // liveScoreInfo1
            // 
            this.liveScoreInfo1.AutoSize = true;
            this.liveScoreInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.liveScoreInfo1.Location = new System.Drawing.Point(394, 27);
            this.liveScoreInfo1.Name = "liveScoreInfo1";
            this.liveScoreInfo1.Size = new System.Drawing.Size(401, 264);
            this.liveScoreInfo1.TabIndex = 11;
            // 
            // halftimeCountdown1
            // 
            this.halftimeCountdown1.AutoSize = true;
            this.halftimeCountdown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.halftimeCountdown1.Location = new System.Drawing.Point(5, 222);
            this.halftimeCountdown1.Name = "halftimeCountdown1";
            this.halftimeCountdown1.Size = new System.Drawing.Size(384, 194);
            this.halftimeCountdown1.TabIndex = 10;
            // 
            // startingSoonCountdown1
            // 
            this.startingSoonCountdown1.AutoSize = true;
            this.startingSoonCountdown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startingSoonCountdown1.Location = new System.Drawing.Point(5, 27);
            this.startingSoonCountdown1.Name = "startingSoonCountdown1";
            this.startingSoonCountdown1.Size = new System.Drawing.Size(384, 194);
            this.startingSoonCountdown1.TabIndex = 9;
            // 
            // StartingSoonCountdownControl
            // 
            this.StartingSoonCountdownControl.AutoSize = true;
            this.StartingSoonCountdownControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartingSoonCountdownControl.Location = new System.Drawing.Point(0, 0);
            this.StartingSoonCountdownControl.Name = "StartingSoonCountdownControl";
            this.StartingSoonCountdownControl.Size = new System.Drawing.Size(383, 192);
            this.StartingSoonCountdownControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 424);
            this.Controls.Add(this.liveScoreInfo1);
            this.Controls.Add(this.halftimeCountdown1);
            this.Controls.Add(this.startingSoonCountdown1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Stream Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StartingSoonCountdown StartingSoonCountdownControl;
        private HalftimeCountdown HalftimeCountdownControl;
        private StartingSoonCountdown startingSoonCountdown1;
        private HalftimeCountdown halftimeCountdown1;
        private LiveScoreInfo liveScoreInfo1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputDirectoryToolStripMenuItem;
    }
}

