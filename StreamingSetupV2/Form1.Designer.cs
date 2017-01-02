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
            this.components = new System.ComponentModel.Container();
            this.LiveScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.GameShotClock = new System.Windows.Forms.Label();
            this.GamePeriod = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Label();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LiveScoreLeftTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AwayName = new System.Windows.Forms.TextBox();
            this.AwayScore = new System.Windows.Forms.TextBox();
            this.AwayTimeouts = new System.Windows.Forms.TextBox();
            this.AwayBonus = new System.Windows.Forms.TextBox();
            this.AwayFouls = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.HomeName = new System.Windows.Forms.TextBox();
            this.HomeScore = new System.Windows.Forms.TextBox();
            this.HomeTimeouts = new System.Windows.Forms.TextBox();
            this.HomeBonus = new System.Windows.Forms.TextBox();
            this.HomeFouls = new System.Windows.Forms.TextBox();
            this.halftimeTimer = new System.Windows.Forms.Timer(this.components);
            this.livescoreupdate = new System.Windows.Forms.Timer(this.components);
            this.StartingSoonCountdownControl = new StreamingSetupV2.StartingSoonCountdown();
            this.startingSoonCountdown1 = new StreamingSetupV2.StartingSoonCountdown();
            this.halftimeCountdown1 = new StreamingSetupV2.HalftimeCountdown();
            this.LiveScoreGroupBox.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.LiveScoreLeftTableLayout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LiveScoreGroupBox
            // 
            this.LiveScoreGroupBox.AccessibleName = "";
            this.LiveScoreGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LiveScoreGroupBox.Controls.Add(this.GameShotClock);
            this.LiveScoreGroupBox.Controls.Add(this.GamePeriod);
            this.LiveScoreGroupBox.Controls.Add(this.GameTime);
            this.LiveScoreGroupBox.Controls.Add(this.TableLayoutPanel3);
            this.LiveScoreGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LiveScoreGroupBox.Location = new System.Drawing.Point(789, 20);
            this.LiveScoreGroupBox.Name = "LiveScoreGroupBox";
            this.LiveScoreGroupBox.Size = new System.Drawing.Size(395, 258);
            this.LiveScoreGroupBox.TabIndex = 8;
            this.LiveScoreGroupBox.TabStop = false;
            this.LiveScoreGroupBox.Text = "LiveScore Information";
            // 
            // GameShotClock
            // 
            this.GameShotClock.AutoSize = true;
            this.GameShotClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameShotClock.Location = new System.Drawing.Point(260, 34);
            this.GameShotClock.Name = "GameShotClock";
            this.GameShotClock.Size = new System.Drawing.Size(86, 20);
            this.GameShotClock.TabIndex = 2;
            this.GameShotClock.Text = "Shot Clock";
            this.GameShotClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GamePeriod
            // 
            this.GamePeriod.AutoSize = true;
            this.GamePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePeriod.Location = new System.Drawing.Point(94, 34);
            this.GamePeriod.Name = "GamePeriod";
            this.GamePeriod.Size = new System.Drawing.Size(54, 20);
            this.GamePeriod.TabIndex = 2;
            this.GamePeriod.Text = "Period";
            this.GamePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GameTime
            // 
            this.GameTime.AutoSize = true;
            this.GameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTime.Location = new System.Drawing.Point(151, 18);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(103, 39);
            this.GameTime.TabIndex = 1;
            this.GameTime.Text = "00:00";
            this.GameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 2;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel3.Controls.Add(this.LiveScoreLeftTableLayout, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.Label2, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.TableLayoutPanel3.Location = new System.Drawing.Point(9, 67);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(385, 184);
            this.TableLayoutPanel3.TabIndex = 0;
            // 
            // LiveScoreLeftTableLayout
            // 
            this.LiveScoreLeftTableLayout.ColumnCount = 1;
            this.LiveScoreLeftTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.LiveScoreLeftTableLayout.Controls.Add(this.AwayName, 0, 0);
            this.LiveScoreLeftTableLayout.Controls.Add(this.AwayScore, 0, 1);
            this.LiveScoreLeftTableLayout.Controls.Add(this.AwayTimeouts, 0, 2);
            this.LiveScoreLeftTableLayout.Controls.Add(this.AwayBonus, 0, 3);
            this.LiveScoreLeftTableLayout.Controls.Add(this.AwayFouls, 0, 4);
            this.LiveScoreLeftTableLayout.Location = new System.Drawing.Point(3, 33);
            this.LiveScoreLeftTableLayout.Name = "LiveScoreLeftTableLayout";
            this.LiveScoreLeftTableLayout.RowCount = 5;
            this.LiveScoreLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LiveScoreLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LiveScoreLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LiveScoreLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LiveScoreLeftTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LiveScoreLeftTableLayout.Size = new System.Drawing.Size(186, 148);
            this.LiveScoreLeftTableLayout.TabIndex = 1;
            // 
            // AwayName
            // 
            this.AwayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AwayName.Location = new System.Drawing.Point(3, 5);
            this.AwayName.Name = "AwayName";
            this.AwayName.ReadOnly = true;
            this.AwayName.Size = new System.Drawing.Size(180, 20);
            this.AwayName.TabIndex = 2;
            this.AwayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AwayScore
            // 
            this.AwayScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AwayScore.Location = new System.Drawing.Point(3, 35);
            this.AwayScore.Name = "AwayScore";
            this.AwayScore.ReadOnly = true;
            this.AwayScore.Size = new System.Drawing.Size(180, 20);
            this.AwayScore.TabIndex = 2;
            this.AwayScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AwayTimeouts
            // 
            this.AwayTimeouts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayTimeouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AwayTimeouts.Location = new System.Drawing.Point(3, 65);
            this.AwayTimeouts.Name = "AwayTimeouts";
            this.AwayTimeouts.ReadOnly = true;
            this.AwayTimeouts.Size = new System.Drawing.Size(180, 20);
            this.AwayTimeouts.TabIndex = 2;
            this.AwayTimeouts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AwayBonus
            // 
            this.AwayBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AwayBonus.Location = new System.Drawing.Point(3, 95);
            this.AwayBonus.Name = "AwayBonus";
            this.AwayBonus.ReadOnly = true;
            this.AwayBonus.Size = new System.Drawing.Size(180, 20);
            this.AwayBonus.TabIndex = 2;
            this.AwayBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AwayFouls
            // 
            this.AwayFouls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AwayFouls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AwayFouls.Location = new System.Drawing.Point(3, 125);
            this.AwayFouls.Name = "AwayFouls";
            this.AwayFouls.ReadOnly = true;
            this.AwayFouls.Size = new System.Drawing.Size(180, 20);
            this.AwayFouls.TabIndex = 2;
            this.AwayFouls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(240, 7);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label2.Size = new System.Drawing.Size(97, 23);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Home (Right)";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(55, 7);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label1.Size = new System.Drawing.Size(81, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Away (Left)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.HomeName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.HomeScore, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.HomeTimeouts, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.HomeBonus, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.HomeFouls, 0, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(195, 33);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(187, 148);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // HomeName
            // 
            this.HomeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HomeName.Location = new System.Drawing.Point(3, 5);
            this.HomeName.Name = "HomeName";
            this.HomeName.ReadOnly = true;
            this.HomeName.Size = new System.Drawing.Size(181, 20);
            this.HomeName.TabIndex = 2;
            this.HomeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HomeScore
            // 
            this.HomeScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HomeScore.Location = new System.Drawing.Point(3, 35);
            this.HomeScore.Name = "HomeScore";
            this.HomeScore.ReadOnly = true;
            this.HomeScore.Size = new System.Drawing.Size(181, 20);
            this.HomeScore.TabIndex = 2;
            this.HomeScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HomeTimeouts
            // 
            this.HomeTimeouts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTimeouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HomeTimeouts.Location = new System.Drawing.Point(3, 65);
            this.HomeTimeouts.Name = "HomeTimeouts";
            this.HomeTimeouts.ReadOnly = true;
            this.HomeTimeouts.Size = new System.Drawing.Size(181, 20);
            this.HomeTimeouts.TabIndex = 2;
            this.HomeTimeouts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HomeBonus
            // 
            this.HomeBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HomeBonus.Location = new System.Drawing.Point(3, 95);
            this.HomeBonus.Name = "HomeBonus";
            this.HomeBonus.ReadOnly = true;
            this.HomeBonus.Size = new System.Drawing.Size(181, 20);
            this.HomeBonus.TabIndex = 2;
            this.HomeBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HomeFouls
            // 
            this.HomeFouls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeFouls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HomeFouls.Location = new System.Drawing.Point(3, 125);
            this.HomeFouls.Name = "HomeFouls";
            this.HomeFouls.ReadOnly = true;
            this.HomeFouls.Size = new System.Drawing.Size(181, 20);
            this.HomeFouls.TabIndex = 2;
            this.HomeFouls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // halftimeTimer
            // 
            this.halftimeTimer.Interval = 1000;
            // 
            // livescoreupdate
            // 
            this.livescoreupdate.Interval = 1000;
            this.livescoreupdate.Tick += new System.EventHandler(this.livescoreupdate_Tick);
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
            // startingSoonCountdown1
            // 
            this.startingSoonCountdown1.AutoSize = true;
            this.startingSoonCountdown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startingSoonCountdown1.Location = new System.Drawing.Point(12, 20);
            this.startingSoonCountdown1.Name = "startingSoonCountdown1";
            this.startingSoonCountdown1.Size = new System.Drawing.Size(384, 194);
            this.startingSoonCountdown1.TabIndex = 9;
            // 
            // halftimeCountdown1
            // 
            this.halftimeCountdown1.AutoSize = true;
            this.halftimeCountdown1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.halftimeCountdown1.Location = new System.Drawing.Point(12, 215);
            this.halftimeCountdown1.Name = "halftimeCountdown1";
            this.halftimeCountdown1.Size = new System.Drawing.Size(384, 194);
            this.halftimeCountdown1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 601);
            this.Controls.Add(this.halftimeCountdown1);
            this.Controls.Add(this.startingSoonCountdown1);
            this.Controls.Add(this.LiveScoreGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Stream Tools";
            this.TopMost = true;
            this.LiveScoreGroupBox.ResumeLayout(false);
            this.LiveScoreGroupBox.PerformLayout();
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            this.LiveScoreLeftTableLayout.ResumeLayout(false);
            this.LiveScoreLeftTableLayout.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.GroupBox LiveScoreGroupBox;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.TableLayoutPanel LiveScoreLeftTableLayout;
        internal System.Windows.Forms.TextBox AwayName;
        internal System.Windows.Forms.TextBox AwayScore;
        internal System.Windows.Forms.TextBox AwayTimeouts;
        internal System.Windows.Forms.TextBox AwayBonus;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer halftimeTimer;
        private System.Windows.Forms.Timer livescoreupdate;
        internal System.Windows.Forms.TextBox AwayFouls;
        private System.Windows.Forms.Label GameTime;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.TextBox HomeName;
        internal System.Windows.Forms.TextBox HomeScore;
        internal System.Windows.Forms.TextBox HomeTimeouts;
        internal System.Windows.Forms.TextBox HomeBonus;
        internal System.Windows.Forms.TextBox HomeFouls;
        private System.Windows.Forms.Label GameShotClock;
        private System.Windows.Forms.Label GamePeriod;

        private StartingSoonCountdown StartingSoonCountdownControl;
        private HalftimeCountdown HalftimeCountdownControl;
        private StartingSoonCountdown startingSoonCountdown1;
        private HalftimeCountdown halftimeCountdown1;
    }
}

