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
            this.startingSoonTimer = new System.Windows.Forms.Timer(this.components);
            this.halftimeTimer = new System.Windows.Forms.Timer(this.components);
            this.livescoreupdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HalftimeLiveOutputTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HalftimeMsgTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.HalftimeResetButton = new System.Windows.Forms.Button();
            this.HalfTimeStartButton2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.HalfTimeH = new System.Windows.Forms.NumericUpDown();
            this.HalfTimeM = new System.Windows.Forms.NumericUpDown();
            this.HalfTimeS = new System.Windows.Forms.NumericUpDown();
            this.startingSoonCountdown1 = new StreamingSetupV2.StartingSoonCountdown();
            this.StartingSoonCountdownControl = new StreamingSetupV2.StartingSoonCountdown();
            this.LiveScoreGroupBox.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.LiveScoreLeftTableLayout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeS)).BeginInit();
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
            // startingSoonTimer
            // 
            this.startingSoonTimer.Interval = 1000;
            this.startingSoonTimer.Tick += new System.EventHandler(this.startingSoonTimer_Tick);
            // 
            // halftimeTimer
            // 
            this.halftimeTimer.Interval = 1000;
            this.halftimeTimer.Tick += new System.EventHandler(this.halftimeTimer_Tick);
            // 
            // livescoreupdate
            // 
            this.livescoreupdate.Interval = 1000;
            this.livescoreupdate.Tick += new System.EventHandler(this.livescoreupdate_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "";
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(390, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hafltime Countdown";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.HalftimeLiveOutputTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.HalftimeMsgTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 161);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Starting in:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(95, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "$m minute(s) and $s second(s)";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Output Format:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Live Output:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HalftimeLiveOutputTextBox
            // 
            this.HalftimeLiveOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HalftimeLiveOutputTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HalftimeLiveOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HalftimeLiveOutputTextBox.Location = new System.Drawing.Point(95, 65);
            this.HalftimeLiveOutputTextBox.Name = "HalftimeLiveOutputTextBox";
            this.HalftimeLiveOutputTextBox.ReadOnly = true;
            this.HalftimeLiveOutputTextBox.Size = new System.Drawing.Size(266, 20);
            this.HalftimeLiveOutputTextBox.TabIndex = 2;
            this.HalftimeLiveOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Msg when done:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HalftimeMsgTextBox
            // 
            this.HalftimeMsgTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HalftimeMsgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HalftimeMsgTextBox.Location = new System.Drawing.Point(95, 95);
            this.HalftimeMsgTextBox.Name = "HalftimeMsgTextBox";
            this.HalftimeMsgTextBox.Size = new System.Drawing.Size(266, 20);
            this.HalftimeMsgTextBox.TabIndex = 2;
            this.HalftimeMsgTextBox.Text = "Stream to Resume Shortly";
            this.HalftimeMsgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.HalftimeResetButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.HalfTimeStartButton2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(95, 123);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(266, 33);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // HalftimeResetButton
            // 
            this.HalftimeResetButton.Location = new System.Drawing.Point(175, 3);
            this.HalftimeResetButton.Name = "HalftimeResetButton";
            this.HalftimeResetButton.Size = new System.Drawing.Size(88, 25);
            this.HalftimeResetButton.TabIndex = 1;
            this.HalftimeResetButton.Text = "Reset";
            this.HalftimeResetButton.UseVisualStyleBackColor = true;
            this.HalftimeResetButton.Click += new System.EventHandler(this.HalftimeResetButton_Click);
            // 
            // HalfTimeStartButton2
            // 
            this.HalfTimeStartButton2.Location = new System.Drawing.Point(3, 3);
            this.HalfTimeStartButton2.Name = "HalfTimeStartButton2";
            this.HalfTimeStartButton2.Size = new System.Drawing.Size(166, 25);
            this.HalfTimeStartButton2.TabIndex = 2;
            this.HalfTimeStartButton2.Text = "Start";
            this.HalfTimeStartButton2.UseVisualStyleBackColor = true;
            this.HalfTimeStartButton2.Click += new System.EventHandler(this.HalfTimeStartButton2_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.HalfTimeH, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.HalfTimeM, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.HalfTimeS, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(95, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(266, 24);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // HalfTimeH
            // 
            this.HalfTimeH.Location = new System.Drawing.Point(3, 3);
            this.HalfTimeH.Name = "HalfTimeH";
            this.HalfTimeH.Size = new System.Drawing.Size(82, 20);
            this.HalfTimeH.TabIndex = 0;
            this.HalfTimeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HalfTimeM
            // 
            this.HalfTimeM.Location = new System.Drawing.Point(91, 3);
            this.HalfTimeM.Name = "HalfTimeM";
            this.HalfTimeM.Size = new System.Drawing.Size(82, 20);
            this.HalfTimeM.TabIndex = 0;
            this.HalfTimeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HalfTimeM.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // HalfTimeS
            // 
            this.HalfTimeS.Location = new System.Drawing.Point(179, 3);
            this.HalfTimeS.Name = "HalfTimeS";
            this.HalfTimeS.Size = new System.Drawing.Size(84, 20);
            this.HalfTimeS.TabIndex = 0;
            this.HalfTimeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HalfTimeS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startingSoonCountdown1
            // 
            this.startingSoonCountdown1.BackColor = System.Drawing.Color.White;
            this.startingSoonCountdown1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.startingSoonCountdown1.Location = new System.Drawing.Point(43, 261);
            this.startingSoonCountdown1.Name = "startingSoonCountdown1";
            this.startingSoonCountdown1.Size = new System.Drawing.Size(383, 192);
            this.startingSoonCountdown1.TabIndex = 9;
            this.startingSoonCountdown1.Load += new System.EventHandler(this.startingSoonCountdown1_Load);
            // 
            // StartingSoonCountdownControl
            // 
            this.StartingSoonCountdownControl.Location = new System.Drawing.Point(0, 0);
            this.StartingSoonCountdownControl.Name = "StartingSoonCountdownControl";
            this.StartingSoonCountdownControl.Size = new System.Drawing.Size(383, 192);
            this.StartingSoonCountdownControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 601);
            this.Controls.Add(this.startingSoonCountdown1);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeS)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Timer startingSoonTimer;
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
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox HalftimeLiveOutputTextBox;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox HalftimeMsgTextBox;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        internal System.Windows.Forms.Button HalftimeResetButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.NumericUpDown HalfTimeH;
        private System.Windows.Forms.NumericUpDown HalfTimeM;
        private System.Windows.Forms.NumericUpDown HalfTimeS;
        private System.Windows.Forms.Button HalfTimeStartButton2;

        private StartingSoonCountdown StartingSoonCountdownControl;
        public StartingSoonCountdown startingSoonCountdown1;
    }
}

