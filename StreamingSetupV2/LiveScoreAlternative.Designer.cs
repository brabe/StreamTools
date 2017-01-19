namespace StreamingSetupV2
{
    partial class LiveScoreAlternative
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreboardUpdate = new System.Windows.Forms.Timer(this.components);
            this.timeClock = new System.Windows.Forms.Timer(this.components);
            this.scoreboardGroupBox = new System.Windows.Forms.GroupBox();
            this.resetGame = new System.Windows.Forms.Button();
            this.TimeClockM = new System.Windows.Forms.NumericUpDown();
            this.TimeClockS = new System.Windows.Forms.NumericUpDown();
            this.button14 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.period2 = new System.Windows.Forms.Button();
            this.GamePeriod = new System.Windows.Forms.Label();
            this.KeyboardStatus = new System.Windows.Forms.Label();
            this.period1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rightScoreText = new System.Windows.Forms.NumericUpDown();
            this.rightName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.leftScoreText = new System.Windows.Forms.NumericUpDown();
            this.leftName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.scoreboardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeClockM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeClockS)).BeginInit();
            this.TableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightScoreText)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftScoreText)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeClock
            // 
            this.timeClock.Interval = 1000;
            this.timeClock.Tick += new System.EventHandler(this.timeClock_Tick);
            // 
            // scoreboardGroupBox
            // 
            this.scoreboardGroupBox.Controls.Add(this.resetGame);
            this.scoreboardGroupBox.Controls.Add(this.TimeClockM);
            this.scoreboardGroupBox.Controls.Add(this.TimeClockS);
            this.scoreboardGroupBox.Controls.Add(this.button14);
            this.scoreboardGroupBox.Controls.Add(this.button19);
            this.scoreboardGroupBox.Controls.Add(this.button13);
            this.scoreboardGroupBox.Controls.Add(this.period2);
            this.scoreboardGroupBox.Controls.Add(this.GamePeriod);
            this.scoreboardGroupBox.Controls.Add(this.KeyboardStatus);
            this.scoreboardGroupBox.Controls.Add(this.period1);
            this.scoreboardGroupBox.Controls.Add(this.button9);
            this.scoreboardGroupBox.Controls.Add(this.button6);
            this.scoreboardGroupBox.Controls.Add(this.button12);
            this.scoreboardGroupBox.Controls.Add(this.button3);
            this.scoreboardGroupBox.Controls.Add(this.button8);
            this.scoreboardGroupBox.Controls.Add(this.button7);
            this.scoreboardGroupBox.Controls.Add(this.button5);
            this.scoreboardGroupBox.Controls.Add(this.button11);
            this.scoreboardGroupBox.Controls.Add(this.button4);
            this.scoreboardGroupBox.Controls.Add(this.button10);
            this.scoreboardGroupBox.Controls.Add(this.button2);
            this.scoreboardGroupBox.Controls.Add(this.button1);
            this.scoreboardGroupBox.Controls.Add(this.TableLayoutPanel3);
            this.scoreboardGroupBox.Controls.Add(this.GameTime);
            this.scoreboardGroupBox.Location = new System.Drawing.Point(3, 3);
            this.scoreboardGroupBox.Name = "scoreboardGroupBox";
            this.scoreboardGroupBox.Size = new System.Drawing.Size(592, 380);
            this.scoreboardGroupBox.TabIndex = 0;
            this.scoreboardGroupBox.TabStop = false;
            this.scoreboardGroupBox.Text = "Scoreboard";
            // 
            // resetGame
            // 
            this.resetGame.Location = new System.Drawing.Point(224, 339);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(142, 28);
            this.resetGame.TabIndex = 8;
            this.resetGame.TabStop = false;
            this.resetGame.Text = "Reset Game";
            this.resetGame.UseVisualStyleBackColor = true;
            this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
            // 
            // TimeClockM
            // 
            this.TimeClockM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TimeClockM.Location = new System.Drawing.Point(430, 73);
            this.TimeClockM.Name = "TimeClockM";
            this.TimeClockM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeClockM.Size = new System.Drawing.Size(55, 20);
            this.TimeClockM.TabIndex = 1;
            this.TimeClockM.TabStop = false;
            this.TimeClockM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeClockM.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // TimeClockS
            // 
            this.TimeClockS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TimeClockS.Location = new System.Drawing.Point(491, 73);
            this.TimeClockS.Name = "TimeClockS";
            this.TimeClockS.Size = new System.Drawing.Size(55, 20);
            this.TimeClockS.TabIndex = 2;
            this.TimeClockS.TabStop = false;
            this.TimeClockS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(268, 99);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 28);
            this.button14.TabIndex = 7;
            this.button14.TabStop = false;
            this.button14.Text = "Reset";
            this.toolTip.SetToolTip(this.button14, "M");
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(255, 248);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(79, 57);
            this.button19.TabIndex = 7;
            this.button19.TabStop = false;
            this.button19.Text = "Toggle Keyboard";
            this.toolTip.SetToolTip(this.button19, "Ctrl + Space");
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(255, 65);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 28);
            this.button13.TabIndex = 7;
            this.button13.TabStop = false;
            this.button13.Text = "Start/Stop";
            this.toolTip.SetToolTip(this.button13, "Space");
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // period2
            // 
            this.period2.Location = new System.Drawing.Point(77, 99);
            this.period2.Name = "period2";
            this.period2.Size = new System.Drawing.Size(56, 28);
            this.period2.TabIndex = 7;
            this.period2.TabStop = false;
            this.period2.Text = "-1";
            this.toolTip.SetToolTip(this.period2, "D1");
            this.period2.UseVisualStyleBackColor = true;
            this.period2.Click += new System.EventHandler(this.period2_Click);
            // 
            // GamePeriod
            // 
            this.GamePeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamePeriod.AutoSize = true;
            this.GamePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePeriod.Location = new System.Drawing.Point(90, 39);
            this.GamePeriod.Name = "GamePeriod";
            this.GamePeriod.Size = new System.Drawing.Size(31, 20);
            this.GamePeriod.TabIndex = 3;
            this.GamePeriod.Text = "1st";
            this.GamePeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // KeyboardStatus
            // 
            this.KeyboardStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeyboardStatus.AutoSize = true;
            this.KeyboardStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyboardStatus.Location = new System.Drawing.Point(279, 308);
            this.KeyboardStatus.Name = "KeyboardStatus";
            this.KeyboardStatus.Size = new System.Drawing.Size(31, 20);
            this.KeyboardStatus.TabIndex = 3;
            this.KeyboardStatus.Text = "Off";
            this.KeyboardStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // period1
            // 
            this.period1.Location = new System.Drawing.Point(77, 65);
            this.period1.Name = "period1";
            this.period1.Size = new System.Drawing.Size(56, 28);
            this.period1.TabIndex = 7;
            this.period1.TabStop = false;
            this.period1.Text = "+1";
            this.toolTip.SetToolTip(this.period1, "D2");
            this.period1.UseVisualStyleBackColor = true;
            this.period1.Click += new System.EventHandler(this.period1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(385, 330);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 37);
            this.button9.TabIndex = 6;
            this.button9.TabStop = false;
            this.button9.Text = "-1";
            this.toolTip.SetToolTip(this.button9, "V");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 330);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 37);
            this.button6.TabIndex = 6;
            this.button6.TabStop = false;
            this.button6.Text = "-1";
            this.toolTip.SetToolTip(this.button6, "X");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(494, 330);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 37);
            this.button12.TabIndex = 6;
            this.button12.TabStop = false;
            this.button12.Text = "+1";
            this.toolTip.SetToolTip(this.button12, "B");
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 37);
            this.button3.TabIndex = 6;
            this.button3.TabStop = false;
            this.button3.Text = "+1";
            this.toolTip.SetToolTip(this.button3, "C");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(385, 287);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 37);
            this.button8.TabIndex = 5;
            this.button8.TabStop = false;
            this.button8.Text = "-3";
            this.toolTip.SetToolTip(this.button8, "F");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(385, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 37);
            this.button7.TabIndex = 4;
            this.button7.TabStop = false;
            this.button7.Text = "-2";
            this.toolTip.SetToolTip(this.button7, "R");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 37);
            this.button5.TabIndex = 5;
            this.button5.TabStop = false;
            this.button5.Text = "-3";
            this.toolTip.SetToolTip(this.button5, "S");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(494, 287);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 37);
            this.button11.TabIndex = 5;
            this.button11.TabStop = false;
            this.button11.Text = "+3";
            this.toolTip.SetToolTip(this.button11, "G");
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 37);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "-2";
            this.toolTip.SetToolTip(this.button4, "W");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(494, 244);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 37);
            this.button10.TabIndex = 4;
            this.button10.TabStop = false;
            this.button10.Text = "+2";
            this.toolTip.SetToolTip(this.button10, "T");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 37);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.Text = "+3";
            this.toolTip.SetToolTip(this.button2, "D");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "+2";
            this.toolTip.SetToolTip(this.button1, "E");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableLayoutPanel3.ColumnCount = 3;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.TableLayoutPanel3.Controls.Add(this.Label2, 2, 0);
            this.TableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.TableLayoutPanel3.Location = new System.Drawing.Point(9, 143);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 2;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(573, 99);
            this.TableLayoutPanel3.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(65, 7);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label1.Size = new System.Drawing.Size(81, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Away (Left)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.rightScoreText, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rightName, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(373, 33);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(187, 60);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // rightScoreText
            // 
            this.rightScoreText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightScoreText.Enabled = false;
            this.rightScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rightScoreText.Location = new System.Drawing.Point(3, 35);
            this.rightScoreText.Name = "rightScoreText";
            this.rightScoreText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightScoreText.Size = new System.Drawing.Size(181, 20);
            this.rightScoreText.TabIndex = 1;
            this.rightScoreText.TabStop = false;
            this.rightScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightScoreText.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // rightName
            // 
            this.rightName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rightName.Location = new System.Drawing.Point(3, 5);
            this.rightName.Name = "rightName";
            this.rightName.Size = new System.Drawing.Size(181, 20);
            this.rightName.TabIndex = 0;
            this.rightName.TabStop = false;
            this.rightName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightName.TextChanged += new System.EventHandler(this.HomeName_TextChanged);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(418, 7);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Label2.Size = new System.Drawing.Size(97, 23);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Home (Right)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.leftScoreText, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.leftName, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(187, 60);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // leftScoreText
            // 
            this.leftScoreText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftScoreText.Enabled = false;
            this.leftScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leftScoreText.Location = new System.Drawing.Point(3, 35);
            this.leftScoreText.Name = "leftScoreText";
            this.leftScoreText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leftScoreText.Size = new System.Drawing.Size(181, 20);
            this.leftScoreText.TabIndex = 1;
            this.leftScoreText.TabStop = false;
            this.leftScoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftScoreText.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // leftName
            // 
            this.leftName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.leftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leftName.Location = new System.Drawing.Point(3, 5);
            this.leftName.Name = "leftName";
            this.leftName.Size = new System.Drawing.Size(181, 20);
            this.leftName.TabIndex = 0;
            this.leftName.TabStop = false;
            this.leftName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(215, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(142, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 33);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Score";
            // 
            // GameTime
            // 
            this.GameTime.AutoSize = true;
            this.GameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTime.Location = new System.Drawing.Point(248, 16);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(103, 39);
            this.GameTime.TabIndex = 2;
            this.GameTime.Text = "08:00";
            this.GameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LiveScoreAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.scoreboardGroupBox);
            this.Name = "LiveScoreAlternative";
            this.Size = new System.Drawing.Size(604, 387);
            this.scoreboardGroupBox.ResumeLayout(false);
            this.scoreboardGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeClockM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeClockS)).EndInit();
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightScoreText)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftScoreText)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.TextBox rightName;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.TextBox leftName;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button period2;
        internal System.Windows.Forms.Button period1;
        internal System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button button12;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button11;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button button10;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button14;
        internal System.Windows.Forms.Button button13;
        internal System.Windows.Forms.Button button19;
        internal System.Windows.Forms.Timer scoreboardUpdate;
        internal System.Windows.Forms.Timer timeClock;
        internal System.Windows.Forms.GroupBox scoreboardGroupBox;
        internal System.Windows.Forms.Label GameTime;
        internal System.Windows.Forms.Label KeyboardStatus;
        internal System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.Label GamePeriod;
        internal System.Windows.Forms.NumericUpDown TimeClockS;
        internal System.Windows.Forms.NumericUpDown TimeClockM;
        internal System.Windows.Forms.NumericUpDown rightScoreText;
        internal System.Windows.Forms.NumericUpDown leftScoreText;
        internal System.Windows.Forms.Button resetGame;
    }
}
