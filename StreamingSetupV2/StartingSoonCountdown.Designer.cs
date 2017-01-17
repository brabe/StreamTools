namespace StreamingSetupV2
{
    partial class StartingSoonCountdown
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
            this.StartGroupBox = new System.Windows.Forms.GroupBox();
            this.StartTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.StartOutputFormatTextBox = new System.Windows.Forms.TextBox();
            this.StartOutputFormatLabel = new System.Windows.Forms.Label();
            this.StartLiveOutputLabel = new System.Windows.Forms.Label();
            this.StartLiveOutputTextBox = new System.Windows.Forms.TextBox();
            this.StartMsgLabel = new System.Windows.Forms.Label();
            this.StartMsgTextBox = new System.Windows.Forms.TextBox();
            this.StartButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartResetButton = new System.Windows.Forms.Button();
            this.StartStartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StartTimeH = new System.Windows.Forms.NumericUpDown();
            this.StartTimeM = new System.Windows.Forms.NumericUpDown();
            this.StartTimeS = new System.Windows.Forms.NumericUpDown();
            this.startingSoonTimer = new System.Windows.Forms.Timer(this.components);
            this.StartGroupBox.SuspendLayout();
            this.StartTableLayout.SuspendLayout();
            this.StartButtonsTableLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeS)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGroupBox
            // 
            this.StartGroupBox.AccessibleName = "";
            this.StartGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartGroupBox.Controls.Add(this.StartTableLayout);
            this.StartGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartGroupBox.Location = new System.Drawing.Point(3, 3);
            this.StartGroupBox.Name = "StartGroupBox";
            this.StartGroupBox.Size = new System.Drawing.Size(378, 188);
            this.StartGroupBox.TabIndex = 6;
            this.StartGroupBox.TabStop = false;
            this.StartGroupBox.Text = "Starting Soon Countdown";
            // 
            // StartTableLayout
            // 
            this.StartTableLayout.ColumnCount = 2;
            this.StartTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StartTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StartTableLayout.Controls.Add(this.StartTimeLabel, 0, 0);
            this.StartTableLayout.Controls.Add(this.StartOutputFormatTextBox, 1, 1);
            this.StartTableLayout.Controls.Add(this.StartOutputFormatLabel, 0, 1);
            this.StartTableLayout.Controls.Add(this.StartLiveOutputLabel, 0, 2);
            this.StartTableLayout.Controls.Add(this.StartLiveOutputTextBox, 1, 2);
            this.StartTableLayout.Controls.Add(this.StartMsgLabel, 0, 3);
            this.StartTableLayout.Controls.Add(this.StartMsgTextBox, 1, 3);
            this.StartTableLayout.Controls.Add(this.StartButtonsTableLayout, 1, 4);
            this.StartTableLayout.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.StartTableLayout.Location = new System.Drawing.Point(9, 17);
            this.StartTableLayout.Name = "StartTableLayout";
            this.StartTableLayout.RowCount = 5;
            this.StartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.StartTableLayout.Size = new System.Drawing.Size(364, 161);
            this.StartTableLayout.TabIndex = 1;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(32, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(57, 30);
            this.StartTimeLabel.TabIndex = 0;
            this.StartTimeLabel.Text = "Starting in:";
            this.StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartOutputFormatTextBox
            // 
            this.StartOutputFormatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartOutputFormatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartOutputFormatTextBox.Location = new System.Drawing.Point(95, 35);
            this.StartOutputFormatTextBox.Name = "StartOutputFormatTextBox";
            this.StartOutputFormatTextBox.Size = new System.Drawing.Size(266, 20);
            this.StartOutputFormatTextBox.TabIndex = 2;
            this.StartOutputFormatTextBox.TabStop = false;
            this.StartOutputFormatTextBox.Text = "$m minute(s) and $s second(s)";
            this.StartOutputFormatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartOutputFormatLabel
            // 
            this.StartOutputFormatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartOutputFormatLabel.AutoSize = true;
            this.StartOutputFormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartOutputFormatLabel.Location = new System.Drawing.Point(12, 30);
            this.StartOutputFormatLabel.Name = "StartOutputFormatLabel";
            this.StartOutputFormatLabel.Size = new System.Drawing.Size(77, 30);
            this.StartOutputFormatLabel.TabIndex = 0;
            this.StartOutputFormatLabel.Text = "Output Format:";
            this.StartOutputFormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartLiveOutputLabel
            // 
            this.StartLiveOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartLiveOutputLabel.AutoSize = true;
            this.StartLiveOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLiveOutputLabel.Location = new System.Drawing.Point(24, 60);
            this.StartLiveOutputLabel.Name = "StartLiveOutputLabel";
            this.StartLiveOutputLabel.Size = new System.Drawing.Size(65, 30);
            this.StartLiveOutputLabel.TabIndex = 0;
            this.StartLiveOutputLabel.Text = "Live Output:";
            this.StartLiveOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartLiveOutputTextBox
            // 
            this.StartLiveOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartLiveOutputTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StartLiveOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartLiveOutputTextBox.Location = new System.Drawing.Point(95, 65);
            this.StartLiveOutputTextBox.Name = "StartLiveOutputTextBox";
            this.StartLiveOutputTextBox.ReadOnly = true;
            this.StartLiveOutputTextBox.Size = new System.Drawing.Size(266, 20);
            this.StartLiveOutputTextBox.TabIndex = 2;
            this.StartLiveOutputTextBox.TabStop = false;
            this.StartLiveOutputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartMsgLabel
            // 
            this.StartMsgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartMsgLabel.AutoSize = true;
            this.StartMsgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMsgLabel.Location = new System.Drawing.Point(3, 90);
            this.StartMsgLabel.Name = "StartMsgLabel";
            this.StartMsgLabel.Size = new System.Drawing.Size(86, 30);
            this.StartMsgLabel.TabIndex = 0;
            this.StartMsgLabel.Text = "Msg when done:";
            this.StartMsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartMsgTextBox
            // 
            this.StartMsgTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartMsgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartMsgTextBox.Location = new System.Drawing.Point(95, 95);
            this.StartMsgTextBox.Name = "StartMsgTextBox";
            this.StartMsgTextBox.Size = new System.Drawing.Size(266, 20);
            this.StartMsgTextBox.TabIndex = 2;
            this.StartMsgTextBox.TabStop = false;
            this.StartMsgTextBox.Text = "Stream to Begin Shortly";
            this.StartMsgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButtonsTableLayout
            // 
            this.StartButtonsTableLayout.ColumnCount = 2;
            this.StartButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.StartButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.StartButtonsTableLayout.Controls.Add(this.StartResetButton, 1, 0);
            this.StartButtonsTableLayout.Controls.Add(this.StartStartButton, 0, 0);
            this.StartButtonsTableLayout.Location = new System.Drawing.Point(95, 123);
            this.StartButtonsTableLayout.Name = "StartButtonsTableLayout";
            this.StartButtonsTableLayout.RowCount = 1;
            this.StartButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.StartButtonsTableLayout.Size = new System.Drawing.Size(266, 33);
            this.StartButtonsTableLayout.TabIndex = 3;
            // 
            // StartResetButton
            // 
            this.StartResetButton.Location = new System.Drawing.Point(175, 3);
            this.StartResetButton.Name = "StartResetButton";
            this.StartResetButton.Size = new System.Drawing.Size(88, 25);
            this.StartResetButton.TabIndex = 1;
            this.StartResetButton.TabStop = false;
            this.StartResetButton.Text = "Reset";
            this.StartResetButton.UseVisualStyleBackColor = true;
            this.StartResetButton.Click += new System.EventHandler(this.StartResetButton_Click);
            // 
            // StartStartButton
            // 
            this.StartStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartStartButton.Location = new System.Drawing.Point(3, 3);
            this.StartStartButton.Name = "StartStartButton";
            this.StartStartButton.Size = new System.Drawing.Size(166, 25);
            this.StartStartButton.TabIndex = 0;
            this.StartStartButton.TabStop = false;
            this.StartStartButton.Text = "Start";
            this.StartStartButton.UseVisualStyleBackColor = true;
            this.StartStartButton.Click += new System.EventHandler(this.StartStartButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.StartTimeH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartTimeM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartTimeS, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(95, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 24);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // StartTimeH
            // 
            this.StartTimeH.Location = new System.Drawing.Point(3, 3);
            this.StartTimeH.Name = "StartTimeH";
            this.StartTimeH.Size = new System.Drawing.Size(82, 20);
            this.StartTimeH.TabIndex = 0;
            this.StartTimeH.TabStop = false;
            this.StartTimeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartTimeM
            // 
            this.StartTimeM.Location = new System.Drawing.Point(91, 3);
            this.StartTimeM.Name = "StartTimeM";
            this.StartTimeM.Size = new System.Drawing.Size(82, 20);
            this.StartTimeM.TabIndex = 0;
            this.StartTimeM.TabStop = false;
            this.StartTimeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTimeM.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // StartTimeS
            // 
            this.StartTimeS.Location = new System.Drawing.Point(179, 3);
            this.StartTimeS.Name = "StartTimeS";
            this.StartTimeS.Size = new System.Drawing.Size(84, 20);
            this.StartTimeS.TabIndex = 0;
            this.StartTimeS.TabStop = false;
            this.StartTimeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTimeS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startingSoonTimer
            // 
            this.startingSoonTimer.Interval = 1000;
            this.startingSoonTimer.Tick += new System.EventHandler(this.startingSoonTimer_Tick);
            // 
            // StartingSoonCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.StartGroupBox);
            this.Name = "StartingSoonCountdown";
            this.Size = new System.Drawing.Size(384, 194);
            this.StartGroupBox.ResumeLayout(false);
            this.StartTableLayout.ResumeLayout(false);
            this.StartTableLayout.PerformLayout();
            this.StartButtonsTableLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox StartGroupBox;
        internal System.Windows.Forms.TableLayoutPanel StartTableLayout;
        internal System.Windows.Forms.Label StartTimeLabel;
        internal System.Windows.Forms.TextBox StartOutputFormatTextBox;
        internal System.Windows.Forms.Label StartOutputFormatLabel;
        internal System.Windows.Forms.Label StartLiveOutputLabel;
        internal System.Windows.Forms.TextBox StartLiveOutputTextBox;
        internal System.Windows.Forms.Label StartMsgLabel;
        internal System.Windows.Forms.TextBox StartMsgTextBox;
        internal System.Windows.Forms.TableLayoutPanel StartButtonsTableLayout;
        internal System.Windows.Forms.Button StartResetButton;
        internal System.Windows.Forms.Button StartStartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown StartTimeH;
        private System.Windows.Forms.NumericUpDown StartTimeM;
        private System.Windows.Forms.NumericUpDown StartTimeS;
        private System.Windows.Forms.Timer startingSoonTimer;
    }
}
