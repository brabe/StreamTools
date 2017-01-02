namespace StreamingSetupV2
{
    partial class HalftimeCountdown
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
            this.halftimeTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HalfTimeS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "";
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 188);
            this.groupBox1.TabIndex = 6;
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
            // halftimeTimer
            // 
            this.halftimeTimer.Interval = 1000;
            this.halftimeTimer.Tick += new System.EventHandler(this.halftimeTimer_Tick);
            // 
            // HalftimeCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Name = "HalftimeCountdown";
            this.Size = new System.Drawing.Size(384, 194);
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
        private System.Windows.Forms.Button HalfTimeStartButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.NumericUpDown HalfTimeH;
        private System.Windows.Forms.NumericUpDown HalfTimeM;
        private System.Windows.Forms.NumericUpDown HalfTimeS;
        private System.Windows.Forms.Timer halftimeTimer;
    }
}
